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
    public partial class FrmCadCompras : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;

        public FrmCadCompras(Cadastro cadastro, Cliente cliente)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            this.clienteAtual = cliente;
            gbTamRoupa.Visible = false;
            gbTamCreme.Visible = false;
        }
        private bool TemOpcaoMarcada(GroupBox grupo)
        {
            return grupo.Controls.OfType<RadioButton>().Any(r => r.Checked);
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (clienteAtual != null)
            {
                int totalProdutos = clienteAtual.getCompras().Count;

                if (totalProdutos > 0)
                {
                    MessageBox.Show($"Cadastro finalizado! Total de produtos: {totalProdutos}");
                }
                else
                {
                    MessageBox.Show("Cadastro finalizado (sem produtos)!");
                }
            }

            this.Close();
        }
        

        private void dudProduto_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProduto.Items.Clear();
            cbProduto.Text = "";

            if (cbCategoria.Text == "Roupa")
            {
                gbTamRoupa.Visible = true;
                gbTamCreme.Visible = false;

                cbProduto.Items.Add("Calça cargo");
                cbProduto.Items.Add("Blusa estampada caveira");
                cbProduto.Items.Add("Jaqueta");
            }
            else if (cbCategoria.Text == "Produto de cabelo")
            {
                gbTamRoupa.Visible = false;
                gbTamCreme.Visible = true;

                cbProduto.Items.Add("Gel");
                cbProduto.Items.Add("Creme");
                cbProduto.Items.Add("Oléo");
            }
            else if (cbCategoria.Text == "Produto de tatuagem")
            {
                gbTamRoupa.Visible = false;
                gbTamCreme.Visible = true;

                cbProduto.Items.Add("Hidratante");
                cbProduto.Items.Add("Protetor Solar");
            }
            else
            {
                gbTamRoupa.Visible = false;
                gbTamCreme.Visible = false;
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (boxQuantd.Value <= 0)
                {
                    throw new ArgumentException("A quantidade deve ser de no mínimo 1 item.");
                }

                if (string.IsNullOrEmpty(cbCategoria.Text))
                {
                    throw new ArgumentException("Por favor, selecione uma categoria.");
                }

                if (string.IsNullOrEmpty(cbProduto.Text))
                {
                    throw new ArgumentException("Por favor, selecione um produto.");
                }

                string categoria = cbCategoria.Text;
                string tamanho = "";

                if (categoria == "Roupa")
                {
                    if (!TemOpcaoMarcada(gbTamRoupa))
                    {
                        throw new ArgumentException("Selecione o tamanho da roupa (P, M, G, GG).");
                    }
                    tamanho = ObterTamanhoSelecionado(gbTamRoupa);
                }
                else if (categoria == "Produto de cabelo" || categoria == "Produto de tatuagem")
                {
                    if (!TemOpcaoMarcada(gbTamCreme))
                    {
                        throw new ArgumentException("Selecione o volume do produto (ml).");
                    }
                    tamanho = ObterTamanhoSelecionado(gbTamCreme);
                }

                Compra novaCompra = new Compra(
                    categoria,
                    cbProduto.Text,
                    tamanho,
                    (int)boxQuantd.Value
                );
                clienteAtual.adicionarCompra(novaCompra);
                clienteAtual.adicionarCompra(novaCompra);

                MessageBox.Show($"Produto adicionado!\nTotal de produtos: {clienteAtual.getCompras().Count}");


                cbProduto.Text = "";
                boxQuantd.Value = 1;
                LimparRadioButtons(gbTamRoupa);
                LimparRadioButtons(gbTamCreme);
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        private string ObterTamanhoSelecionado(GroupBox grupo)
        {
            foreach (RadioButton radio in grupo.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    return radio.Text;
                }
            }
            return "";
        }

        private void LimparRadioButtons(GroupBox grupo)
        {
            foreach (RadioButton radio in grupo.Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCadCompras_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
