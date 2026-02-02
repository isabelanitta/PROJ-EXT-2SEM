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
    public partial class FrmEditar : Form
    {
        private Cadastro cadastro;
        public FrmEditar(Cadastro cadastro)
        {
            InitializeComponent();

            this.cadastro = cadastro;
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarEdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txbEdiCpf.Text.Trim();

                if (string.IsNullOrWhiteSpace(cpf))
                {
                    throw new ArgumentException("Por favor, digite um CPF.");
                }

                Cliente clienteEncontrado = cadastro.PesquisarClientePorCPF(cpf);

                if (clienteEncontrado != null)
                {
                    this.Hide();
                    FrmEditarEncontrado frmEditarEncontrado = new FrmEditarEncontrado(clienteEncontrado, cadastro);
                    frmEditarEncontrado.ShowDialog();
                    this.Show();
                    txbEdiCpf.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
