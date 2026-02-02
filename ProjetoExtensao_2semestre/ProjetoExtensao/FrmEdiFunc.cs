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
    public partial class FrmEdiFunc : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;
        public FrmEdiFunc(Cadastro cadastro, Cliente cliente)
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
                string novoFuncionario = ObterFuncionarioSelecionado();

                if (string.IsNullOrWhiteSpace(novoFuncionario))
                {
                    throw new ArgumentException("Selecione um funcionário.");
                }

                if (clienteAtual != null)
                {
                    clienteAtual.setFuncioEscolhido(novoFuncionario);
                }

                MessageBox.Show("FUNCIONÁRIO editado com SUCESSO!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private string ObterFuncionarioSelecionado()
        {
            if (rbtTavin.Checked) return "Tavin";
            if (rbtTheo.Checked) return "Theo";
            if (rbtMaillon.Checked) return "Maillon";
            if (rbtMaycon.Checked) return "Maycon";
            if (rbtVinicios.Checked) return "Vinicios";
            return "";
        }

        private void FrmEdiFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
