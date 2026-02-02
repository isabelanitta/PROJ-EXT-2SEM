using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensao
{
    public class Cadastro
    {
        private List<Cliente> lista_clientes;
        private List<Funcionario> lista_funcionarios;
        private List<Estoque> lista_produtos;
        private List<Compra> lista_compras;

        public Cadastro()
        {
            lista_clientes = new List<Cliente>();
            lista_funcionarios = new List<Funcionario>();
            lista_produtos = new List<Estoque>();
            lista_compras = new List<Compra>();

            // Carregar dados do banco na inicialização
            CarregarDadosDoBanco();
        }

        /// <summary>
        /// Carrega todos os dados do banco de dados para as listas em memória
        /// </summary>
        private void CarregarDadosDoBanco()
        {
            try
            {
                // Testar conexão primeiro
                if (!ConexaoDB.TestarConexao())
                {
                    throw new Exception("Não foi possível conectar ao banco de dados.");
                }

                // Carregar dados
                lista_clientes = ClienteDAO.ListarTodos();
                lista_funcionarios = FuncionarioDAO.ListarTodos();
                lista_produtos = ProdutoDAO.ListarTodos();

                System.Windows.Forms.MessageBox.Show(
                    $"✅ Conectado ao banco de dados!\n\n" +
                    $"📊 Dados carregados:\n" +
                    $"• Clientes: {lista_clientes.Count}\n" +
                    $"• Funcionários: {lista_funcionarios.Count}\n" +
                    $"• Produtos: {lista_produtos.Count}",
                    "Conexão Estabelecida",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"⚠️ Erro ao conectar ao banco de dados:\n\n{ex.Message}\n\n" +
                    "O sistema continuará em modo offline (apenas memória).",
                    "Aviso de Conexão",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning
                );
            }
        }

        // =====================================================
        // MÉTODOS PARA CLIENTES
        // =====================================================

        public void CadastrarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            try
            {
                // Tentar inserir no banco
                if (ClienteDAO.Inserir(cliente))
                {
                    lista_clientes.Add(cliente);
                }
                else
                {
                    // Se falhar, adicionar apenas na memória
                    lista_clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, adicionar apenas na memória
                lista_clientes.Add(cliente);
                System.Windows.Forms.MessageBox.Show(
                    $"Cliente cadastrado apenas na memória.\nErro no banco: {ex.Message}",
                    "Aviso",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning
                );
            }
        }

        public bool EditarCliente(string cpf, Cliente novosDados)
        {
            Cliente cliente = PesquisarClientePorCPF(cpf);

            if (cliente != null)
            {
                // Verificar se está tentando mudar o CPF
                if (novosDados.getCpf() != cpf)
                {
                    try
                    {
                        if (ClienteDAO.CPFExiste(novosDados.getCpf()))
                        {
                            throw new ArgumentException("CPF já cadastrado em outro cliente.");
                        }
                    }
                    catch
                    {
                        // Se falhar verificação no banco, verifica na memória
                        Cliente clienteExistente = lista_clientes.FirstOrDefault(c => c.getCpf() == novosDados.getCpf());
                        if (clienteExistente != null)
                        {
                            throw new ArgumentException("CPF já cadastrado em outro cliente.");
                        }
                    }
                }

                // Atualizar dados
                cliente.setNome(novosDados.getNome());
                cliente.setTelefone(novosDados.getTelefone());
                cliente.setServicoEscolhido(novosDados.getServicoEscolhido());
                cliente.setFuncioEscolhido(novosDados.getFuncioEscolhido());
                cliente.setHorarioMarcado(novosDados.getHorarioMarcado());
                cliente.setDataMarcada(novosDados.getDataMarcada());

                // Tentar atualizar no banco
                try
                {
                    ClienteDAO.Atualizar(cliente);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"Cliente atualizado apenas na memória.\nErro no banco: {ex.Message}",
                        "Aviso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning
                    );
                }

                return true;
            }
            return false;
        }

        public Cliente PesquisarClientePorCPF(string cpf)
        {
            // Tentar buscar no banco primeiro
            try
            {
                Cliente clienteDoBanco = ClienteDAO.BuscarPorCPF(cpf);
                if (clienteDoBanco != null)
                {
                    return clienteDoBanco;
                }
            }
            catch
            {
                // Se falhar, busca na memória
            }

            // Buscar na lista em memória
            return lista_clientes.FirstOrDefault(c => c.getCpf() == cpf);
        }

        public bool RemoverClientePorCPF(string cpf)
        {
            Cliente cliente = PesquisarClientePorCPF(cpf);

            if (cliente != null)
            {
                // Tentar remover do banco
                try
                {
                    if (ClienteDAO.Remover(cpf))
                    {
                        lista_clientes.Remove(cliente);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Se falhar, remover apenas da memória
                    lista_clientes.Remove(cliente);
                    System.Windows.Forms.MessageBox.Show(
                        $"Cliente removido apenas da memória.\nErro no banco: {ex.Message}",
                        "Aviso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning
                    );
                    return true;
                }
            }
            return false;
        }

        public List<Cliente> ListarTodosClientes()
        {
            // Tentar atualizar lista do banco
            try
            {
                lista_clientes = ClienteDAO.ListarTodos();
            }
            catch
            {
                // Se falhar, retorna lista em memória
            }

            return lista_clientes;
        }

        // =====================================================
        // MÉTODOS PARA FUNCIONÁRIOS
        // =====================================================

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                try
                {
                    if (FuncionarioDAO.Inserir(funcionario))
                    {
                        lista_funcionarios.Add(funcionario);
                    }
                    else
                    {
                        lista_funcionarios.Add(funcionario);
                    }
                }
                catch (Exception ex)
                {
                    lista_funcionarios.Add(funcionario);
                    System.Windows.Forms.MessageBox.Show(
                        $"Funcionário cadastrado apenas na memória.\nErro no banco: {ex.Message}",
                        "Aviso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning
                    );
                }
            }
        }

        public bool EditarFuncionario(string cpf, Funcionario novosDados)
        {
            Funcionario funcionario = PesquisarFuncionarioPorCPF(cpf);

            if (funcionario != null)
            {
                funcionario.setNome(novosDados.getNome());
                funcionario.setCpf(novosDados.getCpf());
                funcionario.setTelefone(novosDados.getTelefone());
                funcionario.setEmail(novosDados.getEmail());
                funcionario.setCargo(novosDados.getCargo());

                return true;
            }
            return false;
        }

        public Funcionario PesquisarFuncionarioPorCPF(string cpf)
        {
            return lista_funcionarios.FirstOrDefault(f => f.getCpf() == cpf);
        }

        public bool RemoverFuncionarioPorCPF(string cpf)
        {
            Funcionario funcionario = PesquisarFuncionarioPorCPF(cpf);

            if (funcionario != null)
            {
                lista_funcionarios.Remove(funcionario);
                return true;
            }
            return false;
        }

        public List<Funcionario> ListarTodosFuncionarios()
        {
            try
            {
                lista_funcionarios = FuncionarioDAO.ListarTodos();
            }
            catch
            {
                // Retorna lista em memória se falhar
            }

            return lista_funcionarios;
        }

        // =====================================================
        // MÉTODOS PARA PRODUTOS (ESTOQUE)
        // =====================================================

        public void AdicionarProduto(Estoque produto)
        {
            if (produto != null)
            {
                try
                {
                    if (ProdutoDAO.Inserir(produto))
                    {
                        lista_produtos.Add(produto);
                    }
                    else
                    {
                        lista_produtos.Add(produto);
                    }
                }
                catch (Exception ex)
                {
                    lista_produtos.Add(produto);
                    System.Windows.Forms.MessageBox.Show(
                        $"Produto cadastrado apenas na memória.\nErro no banco: {ex.Message}",
                        "Aviso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning
                    );
                }
            }
        }

        public List<Estoque> ListarTodosProdutos()
        {
            try
            {
                lista_produtos = ProdutoDAO.ListarTodos();
            }
            catch
            {
                // Retorna lista em memória se falhar
            }

            return lista_produtos;
        }
    }

}