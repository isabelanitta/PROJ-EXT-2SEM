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
    public partial class FrmCadEscolhaCompra : Form
    {
        private Cadastro cadastro;

        public FrmCadEscolhaCompra(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (!rbtSim.Checked && !rbtNao.Checked)
            {
                MessageBox.Show("Por favor, selecione uma opção.");
                return;
            }

            // Se escolheu NÃO comprar
            if (rbtNao.Checked)
            {
                MessageBox.Show("Cadastro finalizado (sem produtos)!");
                this.Close();
                return;
            }

            // Se escolheu SIM comprar
            if (rbtSim.Checked)
            {
                // Buscar o último cliente cadastrado (que acabou de ser registrado)
                List<Cliente> clientes = cadastro.ListarTodosClientes();

                if (clientes.Count > 0)
                {
                    Cliente ultimoCliente = clientes[clientes.Count - 1];

                    this.Hide();
                    FrmCadCompras frmProduto = new FrmCadCompras(cadastro, ultimoCliente);
                    frmProduto.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro: Nenhum cliente encontrado.");
                    this.Close();
                }
            }
        }

        private void FrmCadEscolhaCompra_Load(object sender, EventArgs e)
        {

        }

    }
}
