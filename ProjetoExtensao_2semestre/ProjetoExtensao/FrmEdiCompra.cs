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
    public partial class FrmEdiCompra : Form
    {
        private Cadastro cadastro;
        public FrmEdiCompra(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;
            numericUpDown1.Maximum = 999;
            dudCategoria.SelectedItemChanged += (s, ev) => CarregarProdutosPorCategoria();
            dudCategoria.SelectedItemChanged += (s, ev) =>
            {
                
                dudCategoria.Text = dudCategoria.SelectedItem.ToString();
                AtualizarUI();
            };
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnConfEdi_Click(object sender, EventArgs e)
        {
          
            string tamanho;
            if (radioButton1.Checked) tamanho = "P";
            else if (radioButton3.Checked) tamanho = "M";
            else if (radioButton4.Checked) tamanho = "G";
            else if (radioButton5.Checked) tamanho = "GG";

            MessageBox.Show("COMPRA editada com SUCESSO!");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto adicionado!");
        }
        private void CarregarProdutosPorCategoria()
        {
            clbProduto.Items.Clear();

            string categoria = dudCategoria.Text;

            List<string> produtos = new List<string>();

            if (categoria == "Roupa")
            {
                produtos.Add("Camiseta");
                produtos.Add("Calça");
                produtos.Add("Jaqueta");
            }
            else if (categoria == "Produto de cabelo")
            {
                produtos.Add("Pomada");
                produtos.Add("Gel");
                produtos.Add("Shampoo");
            }
            else if (categoria == "Produto de tatuagem")
            {
                produtos.Add("Sabonete apropriado");
                produtos.Add("Pomada cicatrizante");
            }

            foreach (string p in produtos)
                clbProduto.Items.Add(p);
        }
        private void AtualizarUI()
        {
            clbProduto.Items.Clear();

            string categoria = dudCategoria.Text;

            List<string> produtos = new List<string>();

            // Categorias e produtos
            if (categoria == "Roupa")
            {
                produtos.Add("Camiseta");
                produtos.Add("Calça");
                produtos.Add("Jaqueta");

                // Mostrar tamanhos
                radioButton1.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                label6.Visible = true;
            }
            else if (categoria == "Produto de cabelo")
            {
                produtos.Add("Pomada 120ml");
                produtos.Add("Shampoo 300ml");
                produtos.Add("Gel 250ml");

                // Esconder tamanhos
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                label6.Visible = false;
            }
            else if (categoria == "Produto de tatuagem")
            {
                produtos.Add("Sabonete 250ml");
                produtos.Add("Pomada cicatrizante 30g");

                // Esconder tamanhos
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                label6.Visible = false;
            }

            // Preenche a lista
            foreach (string p in produtos)
                clbProduto.Items.Add(p);
        }


        private void FrmEdiCompra_Load(object sender, EventArgs e)
        {
            CarregarProdutosPorCategoria();
            AtualizarUI();
        }

    }
}
