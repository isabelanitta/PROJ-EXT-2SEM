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
    public partial class FrmEdiCorte : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;
       
        public FrmEdiCorte(Cadastro cadastro, Cliente cliente)
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
                string novoServico = ObterServicoSelecionado();

                if (string.IsNullOrWhiteSpace(novoServico))
                {
                    throw new ArgumentException("Selecione um serviço.");
                }

                if (clienteAtual != null)
                {
                    clienteAtual.setServicoEscolhido(novoServico);
                }

                MessageBox.Show("SERVIÇO editado com SUCESSO!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private string ObterServicoSelecionado()
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                return item.ToString();
            }
            return "";
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                        checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void FrmEdiCorte_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            checkedListBox1.Items.Add("Corte = 35");
            checkedListBox1.Items.Add("Corte + Sobrancelha = 45");
            checkedListBox1.Items.Add("Corte + Barba = 60");
            checkedListBox1.Items.Add("Corte + Barba + Sobrancelha = 70");
            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
