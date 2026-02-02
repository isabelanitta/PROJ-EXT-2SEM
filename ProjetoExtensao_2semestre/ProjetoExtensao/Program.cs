using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExtensao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Testar conexão
            try
            {
                if (ConexaoDB.TestarConexao())
                {
                    MessageBox.Show(
                        "✅ Conexão com banco de dados estabelecida!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "⚠️ Banco offline. Sistema rodará em modo memória.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ Erro: {ex.Message}\n\nVerifique se o MySql está rodando.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            Cadastro cadastro = new Cadastro();
            Application.Run(new FrmPrincipal_Menu(cadastro));
        }
    }
}
