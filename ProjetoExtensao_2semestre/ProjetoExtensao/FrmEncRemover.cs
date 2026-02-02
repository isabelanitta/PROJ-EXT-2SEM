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
    public partial class FrmEncRemover : Form
    {
        
        private Cadastro cadastroPrincipal;
        private Cliente clienteAtual;
       
        public FrmEncRemover(Cliente cliente, Cadastro cadastro)
        {
            InitializeComponent();

            this.clienteAtual = cliente;
            this.cadastroPrincipal = cadastro;

            if (cliente != null)
            {
                txbCpfEnc.Text = cliente.getCpf();
                txbNomeEnc.Text = cliente.getNome();
                txbTelEnc.Text = cliente.getTelefone();

                dttmEdi.Value = cliente.getHorarioMarcado();
                dtData.Value = cliente.getDataMarcada();

                lblServico.Text = cliente.getServicoEscolhido();
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

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnRemover_Click(object sender, EventArgs e)
        {
            bool sucesso = cadastroPrincipal.RemoverClientePorCPF(clienteAtual.getCpf());

            if (sucesso)
            {
                MessageBox.Show("Cliente removido com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao tentar remover o cliente.");
            }
        }

        private void txbCpfEnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEncRemover_Load(object sender, EventArgs e)
        {

        }
    }
}
