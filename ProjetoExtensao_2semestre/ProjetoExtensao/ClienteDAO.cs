using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensao
{
   
    /// DAO adaptado para o banco barbearia_db

    public class ClienteDAO
    {
        // ==================== INSERIR CLIENTE ====================
        public static bool Inserir(Cliente cliente)
        {
            try
            {
                return ConexaoDB.ExecutarTransacao((conexao, transacao) =>
                {
                    // 1. Inserir Cliente
                    string sqlCliente = @"INSERT INTO cliente (nome, cpf, data_cadastro) 
                                        VALUES (@nome, @cpf, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(sqlCliente, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@nome", cliente.getNome());
                        cmd.Parameters.AddWithValue("@cpf", cliente.getCpf());
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Obter ID do cliente inserido
                    long idCliente = 0;
                    using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conexao, transacao))
                    {
                        idCliente = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    // 3. Inserir Telefone
                    if (!string.IsNullOrEmpty(cliente.getTelefone()))
                    {
                        string sqlTelefone = @"INSERT INTO telefone_cliente (telefone, id_cliente) 
                                             VALUES (@telefone, @id_cliente)";
                        using (MySqlCommand cmd = new MySqlCommand(sqlTelefone, conexao, transacao))
                        {
                            cmd.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                            cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 4. Inserir Atendimento (servico escolhido)
                    if (!string.IsNullOrEmpty(cliente.getServicoEscolhido()))
                    {
                        // Buscar id_servico pelo nome
                        int idServico = ObterIdServicoPorNome(cliente.getServicoEscolhido(), conexao, transacao);
                        int idFuncionario = ObterIdFuncionarioPorNome(cliente.getFuncioEscolhido(), conexao, transacao);

                        if (idServico > 0 && idFuncionario > 0)
                        {
                            string sqlAtendimento = @"INSERT INTO atendimento 
                                (id_cliente, id_funcionario, id_servico, data_atendimento, observacoes) 
                                VALUES (@id_cliente, @id_funcionario, @id_servico, @data_atendimento, @obs)";

                            using (MySqlCommand cmd = new MySqlCommand(sqlAtendimento, conexao, transacao))
                            {
                                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                                cmd.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                                cmd.Parameters.AddWithValue("@id_servico", idServico);
                                cmd.Parameters.AddWithValue("@data_atendimento", cliente.getHorarioMarcado());
                                cmd.Parameters.AddWithValue("@obs", "Agendamento via sistema");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 5. Inserir Compras
                    foreach (Compra compra in cliente.getCompras())
                    {
                        InserirCompra(compra, (int)idCliente, conexao, transacao);
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir cliente: {ex.Message}");
            }
        }

        // ==================== ATUALIZAR ====================
        public static bool Atualizar(Cliente cliente)
        {
            try
            {
                return ConexaoDB.ExecutarTransacao((conexao, transacao) =>
                {
                    // 1. Buscar ID do cliente pelo CPF
                    int idCliente = ObterIdClientePorCPF(cliente.getCpf(), conexao, transacao);

                    if (idCliente == 0)
                        throw new Exception("Cliente não encontrado.");

                    // 2. Atualizar dados do cliente
                    string sqlCliente = @"UPDATE cliente SET nome = @nome, cpf = @cpf 
                                        WHERE id_cliente = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sqlCliente, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@nome", cliente.getNome());
                        cmd.Parameters.AddWithValue("@cpf", cliente.getCpf());
                        cmd.Parameters.AddWithValue("@id", idCliente);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Atualizar telefone
                    string sqlTelefone = @"UPDATE telefone_cliente SET telefone = @telefone 
                                         WHERE id_cliente = @id_cliente";
                    using (MySqlCommand cmd = new MySqlCommand(sqlTelefone, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        int linhas = cmd.ExecuteNonQuery();

                        // Se não existe telefone, inserir
                        if (linhas == 0)
                        {
                            string sqlInsertTel = @"INSERT INTO telefone_cliente (telefone, id_cliente) 
                                                  VALUES (@telefone, @id_cliente)";
                            using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsertTel, conexao, transacao))
                            {
                                cmdInsert.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                                cmdInsert.Parameters.AddWithValue("@id_cliente", idCliente);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar cliente: {ex.Message}");
            }
        }

        // ==================== REMOVER ====================
        public static bool Remover(string cpf)
        {
            try
            {
                string sql = "DELETE FROM cliente WHERE cpf = @cpf";
                MySqlParameter[] parametros = {
                    new MySqlParameter("@cpf", cpf)
                };

                int linhasAfetadas = ConexaoDB.ExecutarComando(sql, parametros);
                return linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao remover cliente: {ex.Message}");
            }
        }

        // ==================== BUSCAR POR CPF ====================
        public static Cliente BuscarPorCPF(string cpf)
        {
            try
            {
                string sql = @"SELECT c.*, 
                             t.telefone,
                             e.email
                             FROM cliente c
                             LEFT JOIN telefone_cliente t ON c.id_cliente = t.id_cliente
                             LEFT JOIN email_cliente e ON c.id_cliente = e.id_cliente
                             WHERE c.cpf = @cpf
                             LIMIT 1";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@cpf", cpf)
                };

                DataTable dt = ConexaoDB.ExecutarConsulta(sql, parametros);

                if (dt.Rows.Count > 0)
                {
                    return ConverterDataRowParaCliente(dt.Rows[0]);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar cliente: {ex.Message}");
            }
        }

        // ==================== LISTAR TODOS ====================
        public static List<Cliente> ListarTodos()
        {
            try
            {
                string sql = @"SELECT c.*, 
                             t.telefone,
                             e.email
                             FROM cliente c
                             LEFT JOIN telefone_cliente t ON c.id_cliente = t.id_cliente
                             LEFT JOIN email_cliente e ON c.id_cliente = e.id_cliente
                             ORDER BY c.nome";

                DataTable dt = ConexaoDB.ExecutarConsulta(sql);

                List<Cliente> clientes = new List<Cliente>();
                foreach (DataRow row in dt.Rows)
                {
                    clientes.Add(ConverterDataRowParaCliente(row));
                }

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar clientes: {ex.Message}");
            }
        }

        // ==================== VERIFICAR SE CPF EXISTE ====================
        public static bool CPFExiste(string cpf)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM cliente WHERE cpf = @cpf";
                MySqlParameter[] parametros = {
                    new MySqlParameter("@cpf", cpf)
                };

                object resultado = ConexaoDB.ExecutarScalar(sql, parametros);
                return Convert.ToInt32(resultado) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao verificar CPF: {ex.Message}");
            }
        }

        // ==================== MÉTODOS AUXILIARES ====================
        private static int ObterIdClientePorCPF(string cpf, MySqlConnection conexao, MySqlTransaction transacao)
        {
            string sql = "SELECT id_cliente FROM cliente WHERE cpf = @cpf";
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@cpf", cpf);
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : 0;
            }
        }

        private static int ObterIdServicoPorNome(string nomeServico, MySqlConnection conexao, MySqlTransaction transacao)
        {
            // Mapear nome do serviço do sistema para o banco
            string sqlCheck = "SELECT id_servico FROM servico WHERE nome_servico LIKE @nome LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(sqlCheck, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", "%" + nomeServico.Split('+')[0].Trim() + "%");
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    return Convert.ToInt32(resultado);
            }

            // Se não encontrar, criar serviço
            string sqlInsert = @"INSERT INTO servico (nome_servico, descricao, preco) 
                               VALUES (@nome, @desc, @preco)";
            using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", nomeServico);
                cmd.Parameters.AddWithValue("@desc", "Serviço cadastrado automaticamente");

                // Extrair preço do nome se possível
                decimal preco = 35.00m;
                if (nomeServico.Contains("70")) preco = 70.00m;
                else if (nomeServico.Contains("60")) preco = 60.00m;
                else if (nomeServico.Contains("45")) preco = 45.00m;

                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.ExecuteNonQuery();

                return Convert.ToInt32(cmd.LastInsertedId);
            }
        }

        private static int ObterIdFuncionarioPorNome(string nomeFuncionario, MySqlConnection conexao, MySqlTransaction transacao)
        {
            string sqlCheck = "SELECT id_funcionario FROM funcionario WHERE nome = @nome LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(sqlCheck, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    return Convert.ToInt32(resultado);
            }

            // Se não encontrar, criar funcionário
            string sqlInsert = @"INSERT INTO funcionario (nome, cargo) VALUES (@nome, 'Barbeiro')";
            using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", nomeFuncionario);
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.LastInsertedId);
            }
        }

        private static void InserirCompra(Compra compra, int idCliente, MySqlConnection conexao, MySqlTransaction transacao)
        {
            // 1. Buscar ou criar produto
            int idProduto = ObterOuCriarProduto(compra.getProduto(), compra.getCategoria(), conexao, transacao);

            // 2. Buscar funcionário padrão (ou o último cadastrado)
            string sqlFunc = "SELECT id_funcionario FROM funcionario ORDER BY id_funcionario DESC LIMIT 1";
            int idFuncionario = 1;
            using (MySqlCommand cmd = new MySqlCommand(sqlFunc, conexao, transacao))
            {
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    idFuncionario = Convert.ToInt32(resultado);
            }

            // 3. Criar compra
            string sqlCompra = @"INSERT INTO compra (id_cliente, id_funcionario, id_produto, data_venda, valor_total) 
                               VALUES (@id_cliente, @id_funcionario, @id_produto, NOW(), @valor)";

            using (MySqlCommand cmd = new MySqlCommand(sqlCompra, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                cmd.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                cmd.Parameters.AddWithValue("@id_produto", idProduto);
                cmd.Parameters.AddWithValue("@valor", 50.00); // Valor padrão
                cmd.ExecuteNonQuery();

                long idCompra = cmd.LastInsertedId;

                // 4. Inserir itens da compra
                string sqlItem = @"INSERT INTO itens_compra (id_compra, id_produto, preco_unitario, quantidade) 
                                 VALUES (@id_compra, @id_produto, @preco, @quantidade)";
                using (MySqlCommand cmdItem = new MySqlCommand(sqlItem, conexao, transacao))
                {
                    cmdItem.Parameters.AddWithValue("@id_compra", idCompra);
                    cmdItem.Parameters.AddWithValue("@id_produto", idProduto);
                    cmdItem.Parameters.AddWithValue("@preco", 50.00);
                    cmdItem.Parameters.AddWithValue("@quantidade", compra.getQuantd());
                    cmdItem.ExecuteNonQuery();
                }
            }
        }

        private static int ObterOuCriarProduto(string nomeProduto, string categoria, MySqlConnection conexao, MySqlTransaction transacao)
        {
            string sqlCheck = "SELECT id_produto FROM produto WHERE nome_produto = @nome LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(sqlCheck, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", nomeProduto);
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    return Convert.ToInt32(resultado);
            }

            // Criar produto
            string sqlInsert = @"INSERT INTO produto (nome_produto, descricao, preco, estoque) 
                               VALUES (@nome, @desc, @preco, 100)";
            using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao, transacao))
            {
                cmd.Parameters.AddWithValue("@nome", nomeProduto);
                cmd.Parameters.AddWithValue("@desc", $"Categoria: {categoria}");
                cmd.Parameters.AddWithValue("@preco", 50.00);
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.LastInsertedId);
            }
        }

        // ==================== CONVERTER DATAROW PARA CLIENTE ====================
        private static Cliente ConverterDataRowParaCliente(DataRow row)
        {
            Cliente cliente = new Cliente();

            cliente.setCpf(row["cpf"].ToString());
            cliente.setNome(row["nome"].ToString());

            if (row.Table.Columns.Contains("telefone") && row["telefone"] != DBNull.Value)
                cliente.setTelefone(row["telefone"].ToString());
            else
                cliente.setTelefone("00000000000");

            // Buscar último atendimento do cliente
            int idCliente = Convert.ToInt32(row["id_cliente"]);
            BuscarUltimoAtendimento(cliente, idCliente);

            // Buscar compras
            List<Compra> compras = BuscarComprasCliente(idCliente);
            foreach (Compra compra in compras)
            {
                cliente.adicionarCompra(compra);
            }

            return cliente;
        }

        private static void BuscarUltimoAtendimento(Cliente cliente, int idCliente)
        {
            try
            {
                string sql = @"SELECT a.*, s.nome_servico, f.nome as nome_funcionario
                             FROM atendimento a
                             JOIN servico s ON a.id_servico = s.id_servico
                             JOIN funcionario f ON a.id_funcionario = f.id_funcionario
                             WHERE a.id_cliente = @id
                             ORDER BY a.data_atendimento DESC
                             LIMIT 1";

                MySqlParameter[] parametros = { new MySqlParameter("@id", idCliente) };
                DataTable dt = ConexaoDB.ExecutarConsulta(sql, parametros);

                if (dt.Rows.Count > 0)
                {
                    cliente.setServicoEscolhido(dt.Rows[0]["nome_servico"].ToString());
                    cliente.setFuncioEscolhido(dt.Rows[0]["nome_funcionario"].ToString());
                    cliente.setHorarioMarcado(Convert.ToDateTime(dt.Rows[0]["data_atendimento"]));
                    cliente.setDataMarcada(Convert.ToDateTime(dt.Rows[0]["data_atendimento"]).Date);
                }
            }
            catch
            {
                // Se falhar, usa valores padrão
                cliente.setServicoEscolhido("Não informado");
                cliente.setFuncioEscolhido("Não informado");
            }
        }

        private static List<Compra> BuscarComprasCliente(int idCliente)
        {
            List<Compra> compras = new List<Compra>();
            try
            {
                string sql = @"SELECT p.nome_produto, p.descricao, ic.quantidade
                             FROM compra c
                             JOIN itens_compra ic ON c.id_compra = ic.id_compra
                             JOIN produto p ON ic.id_produto = p.id_produto
                             WHERE c.id_cliente = @id";

                MySqlParameter[] parametros = { new MySqlParameter("@id", idCliente) };
                DataTable dt = ConexaoDB.ExecutarConsulta(sql, parametros);

                foreach (DataRow row in dt.Rows)
                {
                    Compra compra = new Compra(
                        "Produto",
                        row["nome_produto"].ToString(),
                        "Padrão",
                        Convert.ToInt32(row["quantidade"])
                    );
                    compras.Add(compra);
                }
            }
            catch { }

            return compras;
        }
    }

    /// <summary>
    /// DAO para Funcionários
    /// </summary>
    public class FuncionarioDAO
    {
        public static bool Inserir(Funcionario funcionario)
        {
            try
            {
                return ConexaoDB.ExecutarTransacao((conexao, transacao) =>
                {
                    // Inserir funcionário
                    string sql = @"INSERT INTO funcionario (nome, cargo) VALUES (@nome, @cargo)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@nome", funcionario.getNome());
                        cmd.Parameters.AddWithValue("@cargo", funcionario.getCargo());
                        cmd.ExecuteNonQuery();

                        long idFunc = cmd.LastInsertedId;

                        // Inserir telefone
                        string sqlTel = @"INSERT INTO telefone_funcionario (telefone, id_funcionario) 
                                        VALUES (@telefone, @id)";
                        using (MySqlCommand cmdTel = new MySqlCommand(sqlTel, conexao, transacao))
                        {
                            cmdTel.Parameters.AddWithValue("@telefone", funcionario.getTelefone());
                            cmdTel.Parameters.AddWithValue("@id", idFunc);
                            cmdTel.ExecuteNonQuery();
                        }

                        // Inserir email
                        string sqlEmail = @"INSERT INTO email_funcionario (email, id_funcionario) 
                                          VALUES (@email, @id)";
                        using (MySqlCommand cmdEmail = new MySqlCommand(sqlEmail, conexao, transacao))
                        {
                            cmdEmail.Parameters.AddWithValue("@email", funcionario.getEmail());
                            cmdEmail.Parameters.AddWithValue("@id", idFunc);
                            cmdEmail.ExecuteNonQuery();
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir funcionário: {ex.Message}");
            }
        }

        public static List<Funcionario> ListarTodos()
        {
            try
            {
                string sql = @"SELECT f.*, t.telefone, e.email
                             FROM funcionario f
                             LEFT JOIN telefone_funcionario t ON f.id_funcionario = t.id_funcionario
                             LEFT JOIN email_funcionario e ON f.id_funcionario = e.id_funcionario
                             ORDER BY f.nome";

                DataTable dt = ConexaoDB.ExecutarConsulta(sql);
                List<Funcionario> funcionarios = new List<Funcionario>();

                foreach (DataRow row in dt.Rows)
                {
                    Funcionario func = new Funcionario();
                    func.setCpf("00000000000"); // CPF não está na tabela
                    func.setNome(row["nome"].ToString());
                    func.setCargo(row["cargo"].ToString());

                    if (row.Table.Columns.Contains("telefone") && row["telefone"] != DBNull.Value)
                        func.setTelefone(row["telefone"].ToString());
                    else
                        func.setTelefone("00000000000");

                    if (row.Table.Columns.Contains("email") && row["email"] != DBNull.Value)
                        func.setEmail(row["email"].ToString());
                    else
                        func.setEmail("sem@email.com");

                    funcionarios.Add(func);
                }

                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar funcionários: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// DAO para Produtos
    /// </summary>
    public class ProdutoDAO
    {
        public static bool Inserir(Estoque produto)
        {
            try
            {
                string sql = @"INSERT INTO produto (nome_produto, descricao, preco, estoque) 
                             VALUES (@nome, @desc, @preco, @estoque)";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@nome", produto.getNome()),
                    new MySqlParameter("@desc", produto.getDescricao()),
                    new MySqlParameter("@preco", produto.getPreco()),
                    new MySqlParameter("@estoque", produto.getQuantd())
                };

                return ConexaoDB.ExecutarComando(sql, parametros) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir produto: {ex.Message}");
            }
        }

        public static List<Estoque> ListarTodos()
        {
            try
            {
                string sql = "SELECT * FROM produto ORDER BY nome_produto";
                DataTable dt = ConexaoDB.ExecutarConsulta(sql);

                List<Estoque> produtos = new List<Estoque>();
                foreach (DataRow row in dt.Rows)
                {
                    Estoque produto = new Estoque();
                    produto.setNome(row["nome_produto"].ToString());
                    produto.setDescricao(row["descricao"].ToString());
                    produto.setPreco(Convert.ToDouble(row["preco"]));
                    produto.setQuantd(Convert.ToInt32(row["estoque"]));
                    produtos.Add(produto);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar produtos: {ex.Message}");
            }
        }
    }
}
