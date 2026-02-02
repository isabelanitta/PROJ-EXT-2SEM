using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExtensao
{
    public partial class FrmRemover : Form
    {
        private Cadastro cadastro;
        public FrmRemover(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txbPesqCpf.Text;

                if (string.IsNullOrWhiteSpace(cpf))
                {
                    throw new ArgumentException("Por favor, digite um CPF.");
                }
                Cliente clienteEncontrado = cadastro.PesquisarClientePorCPF(cpf);

                if (clienteEncontrado != null)
                {
                    FrmEncRemover frmEncRemover = new FrmEncRemover(clienteEncontrado, cadastro);
                    frmEncRemover.ShowDialog();
                    txbPesqCpf.Text = "";
                }
                else
                {
                    throw new ArgumentException("Cliente não encontrado com este CPF.");
                }
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelarEdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRemover_Load(object sender, EventArgs e)
        {

        }
    }
}
