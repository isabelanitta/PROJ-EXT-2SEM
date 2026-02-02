using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExtensao
{
  
    /// Classe responsável pela conexão com o banco de dados MySQL
    
    public class ConexaoDB
    {
        // String de conexão 
        private static string connectionString = @"server=127.0.0.1;uid=root;pwd=ifsp@MySql21;database=barbearia_db;ConnectionTimeout=1";
    

        /// <summary>
        /// Abre e retorna uma conexão com o banco de dados
        /// </summary>
        public static MySqlConnection AbrirConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }

        /// <summary>
        /// Fecha uma conexão aberta
        /// </summary>
        public static void FecharConexao(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        /// <summary>
        /// Testa se a conexão está funcionando
        /// </summary>
        public static bool TestarConexao()
        {
            try
            {
                using (MySqlConnection conexao = AbrirConexao())
                {
                    return conexao.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Executa um comando SQL sem retorno (INSERT, UPDATE, DELETE)
        /// </summary>
        public static int ExecutarComando(string sql, MySqlParameter[] parametros = null)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao executar comando: {ex.Message}");
            }
            finally
            {
                FecharConexao(conexao);
            }
        }

        /// <summary>
        /// Executa uma consulta SQL e retorna um DataTable
        /// </summary>
        public static DataTable ExecutarConsulta(string sql, MySqlParameter[] parametros = null)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao executar consulta: {ex.Message}");
            }
            finally
            {
                FecharConexao(conexao);
            }
        }

        /// <summary>
        /// Executa uma consulta e retorna um único valor
        /// </summary>
        public static object ExecutarScalar(string sql, MySqlParameter[] parametros = null)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }
                    return cmd.ExecuteScalar();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao executar scalar: {ex.Message}");
            }
            finally
            {
                FecharConexao(conexao);
            }
        }

        /// <summary>
        /// Executa múltiplos comandos em uma transação
        /// </summary>
        public static bool ExecutarTransacao(Action<MySqlConnection, MySqlTransaction> comandos)
        {
            MySqlConnection conexao = null;
            MySqlTransaction transacao = null;
            try
            {
                conexao = AbrirConexao();
                transacao = conexao.BeginTransaction();

                comandos(conexao, transacao);

                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (transacao != null)
                {
                    transacao.Rollback();
                }
                throw new Exception($"Erro na transação: {ex.Message}");
            }
            finally
            {
                FecharConexao(conexao);
            }
        }
    }
}
