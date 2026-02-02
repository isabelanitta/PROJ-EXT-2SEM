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
    public partial class FrmCadProduto : Form
    {
        private Cadastro cadastro;
        public FrmCadProduto(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                if (string.IsNullOrWhiteSpace(txbNomeProd.Text))
                {
                    throw new ArgumentException("Informe o nome do produto.");
                }
                if (string.IsNullOrWhiteSpace(txbDescricaoProd.Text))
                {
                    throw new ArgumentException("Informe a descrição do produto.");
                }
                if (string.IsNullOrWhiteSpace(txbPrecoProd.Text))
                {
                    throw new ArgumentException("Informe o preço do produto.");
                }
                if (boxEstoque.Value <= 0)
                {
                    throw new ArgumentException("Informe o estoque do produto (mínimo 1).");
                }

                string nome = txbNomeProd.Text;
                string descricao = txbDescricaoProd.Text;

                double preco;
                if (!double.TryParse(txbPrecoProd.Text.Replace("R$", "").Replace(",", ".").Trim(), out preco))
                {
                    throw new ArgumentException("Preço inválido. Use apenas números.");
                }

                int quantdEstoque = (int)boxEstoque.Value;

                Estoque produto = new Estoque();
                produto.setNome(nome);
                produto.setDescricao(descricao);
                produto.setPreco(preco);
                produto.setQuantd(quantdEstoque);

                cadastro.AdicionarProduto(produto);

                MessageBox.Show("Produto cadastrado com sucesso!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + erro.Message);
            }
            
        }
        private void FrmCadProduto_Load(object sender, EventArgs e)
        {

        }

    }
}
