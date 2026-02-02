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
    public partial class FrmEditarEncontrado : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;

        public FrmEditarEncontrado(Cliente cliente, Cadastro cadastro)
        {
            InitializeComponent();

            this.clienteAtual = cliente ?? throw new ArgumentNullException(nameof(cliente));
            this.cadastro = cadastro;

            txbCpfEnc.Text = cliente.getCpf();
            txtNomeEnc.Text = cliente.getNome();
            txtTelEnc.Text = cliente.getTelefone();
            dttmEdi.Value = cliente.getHorarioMarcado();
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
        }


        private void btnSairEdi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            if (clienteAtual == null)
            {
                MessageBox.Show("Nenhum cliente selecionado!");
                return;
            }

            if (cbxEdiCPF.Checked)
            {
                var f = new FrmEdiCPF(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiNome.Checked)
            {
                var f = new FrmEdiNome(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiTel.Checked)
            {
                var f = new FrmEdiTel(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiHr.Checked)
            {
                var f = new FrmEdiHor(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiCorte.Checked)
            {
                var f = new FrmEdiCorte(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiFunc.Checked)
            {
                var f = new FrmEdiFunc(cadastro, clienteAtual);
                f.ShowDialog();
            }
            if (cbxEdiEscComp.Checked)
            {
                var f = new FrmEdiEscComp(cadastro, clienteAtual);
                f.ShowDialog();
            }

            // ATUALIZAR CAMPOS NA TELA
            AtualizarCampos();
        }

        private void AtualizarCampos()
        {
            if (clienteAtual != null)
            {
                txbCpfEnc.Text = clienteAtual.getCpf();
                txtNomeEnc.Text = clienteAtual.getNome();
                txtTelEnc.Text = clienteAtual.getTelefone();
                dttmEdi.Value = clienteAtual.getHorarioMarcado();
                lblCorte.Text = clienteAtual.getServicoEscolhido();
                lblFunc.Text = clienteAtual.getFuncioEscolhido();
            }
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEditarEncontrado_Load(object sender, EventArgs e)
        {

        }
    }
}
