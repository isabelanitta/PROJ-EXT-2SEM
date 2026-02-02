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
    public partial class FrmRelatorio : Form
    {
        private Cadastro cadastro;
        private List<Cliente> clientes;
        private int indiceAtual = 0;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        public FrmRelatorio(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            clientes = cadastro.ListarTodosClientes();

            if (clientes.Count > 0)
            {
                MostrarCliente(0);
            }
            else
            {
                MessageBox.Show("Nenhum cliente cadastrado ainda.");
                LimparCampos();
            }
        }
        private void MostrarCliente(int indice)
        {
            if (indice >= 0 && indice < clientes.Count)
            {
                Cliente cliente = clientes[indice];

                txbCpfEnc.Text = cliente.getCpf();
                txtNomeEnc.Text = cliente.getNome();
                txtTelEnc.Text = cliente.getTelefone();

                dttmEdi.Value = cliente.getHorarioMarcado();

                lblCorte.Text = cliente.getServicoEscolhido();
                lblFunc.Text = cliente.getFuncioEscolhido();
                lblCorte.Text = cliente.getServicoEscolhido();
                lblFunc.Text = cliente.getFuncioEscolhido();

                
                List<Compra> compras = cliente.getCompras();
                if (compras != null && compras.Count > 0)
                {
                    lblCompra.Text = $"Sim ({compras.Count} itens)";
                }
                else
                {
                    lblCompra.Text = "Não";
                }

              
                this.Text = $"Relatório - Cliente {indice + 1} de {clientes.Count}";
            }
        }
        private void LimparCampos()
        {
            txbCpfEnc.Text = "";
            txtNomeEnc.Text = "";
            txtTelEnc.Text = "";
            lblCorte.Text = "...";
            lblFunc.Text = "...";
            lblCompra.Text = "...";
        }

        private void btnSairEdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (clientes.Count == 0) return;

            indiceAtual++;

            if (indiceAtual >= clientes.Count)
                indiceAtual = clientes.Count - 1; // trava no último

            MostrarCliente(indiceAtual);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (clientes.Count == 0) return;

            indiceAtual--;

            if (indiceAtual < 0)
                indiceAtual = 0; 

            MostrarCliente(indiceAtual);
        }
    }
}
