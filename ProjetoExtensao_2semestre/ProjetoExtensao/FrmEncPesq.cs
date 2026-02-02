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
    public partial class FrmEncPesq : Form
    {
        private Cadastro cadastro;
        private Cliente cliente;

        // Construtor quando só recebe Cadastro
        public FrmEncPesq(Cadastro cadastroRecebido)
        {
            InitializeComponent();
            this.cadastro = cadastroRecebido;
        }

        // Construtor quando recebe Cliente e Cadastro
        public FrmEncPesq(Cliente cliente, Cadastro cadastro)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.cadastro = cadastro;

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

        private void btnSairEdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEncPesq_Load(object sender, EventArgs e)
        {

        }

        private void txbCpfEnc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
