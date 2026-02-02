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
    public partial class FrmEdiNome : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;
        public FrmEdiNome(Cadastro cadastro, Cliente cliente)
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
                string novoNome = txbNomeNovo.Text.Trim();

                if (string.IsNullOrWhiteSpace(novoNome))
                {
                    throw new ArgumentException("Digite o novo nome do cliente.");
                }

                clienteAtual.setNome(novoNome);

                MessageBox.Show("NOME editado com SUCESSO!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FrmEdiNome_Load(object sender, EventArgs e)
        {
            if (clienteAtual != null)
            {
                txbNomeNovo.Text = clienteAtual.getNome();
            }
        }
    }
}
