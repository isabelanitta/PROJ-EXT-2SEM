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
    public partial class FrmEdiTel : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;
        public FrmEdiTel(Cadastro cadastro, Cliente cliente)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            this.clienteAtual = cliente;
        }


        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnConfEdi_Click(object sender, EventArgs e)
        {
            try
            {
                string novoTelefone = txbTelNovo.Text.Trim();

                if (string.IsNullOrWhiteSpace(novoTelefone))
                    throw new ArgumentException("Digite o novo telefone do cliente.");

                if (novoTelefone.Length != 11)
                    throw new ArgumentException("Telefone deve ter 11 dígitos (DDD + número).");

                if (!novoTelefone.All(char.IsDigit))
                    throw new ArgumentException("Telefone deve conter apenas números.");

                clienteAtual.setTelefone(novoTelefone);
                MessageBox.Show("TELEFONE editado com SUCESSO!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FrmEdiTel_Load(object sender, EventArgs e)
        {

        }
    }
}
