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
    public partial class FrmCadFuncionario : Form
    {
        private Cadastro cadastro;
        public FrmCadFuncionario(Cadastro cadastro)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.cadastro = cadastro;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbCpfFunc.Text))
                {
                    throw new ArgumentException("Informe o CPF do funcionário.");
                }
                if (string.IsNullOrWhiteSpace(txbNomeFunc.Text))
                {
                    throw new ArgumentException("Informe o nome do funcionário.");
                }
                if (string.IsNullOrWhiteSpace(txbTelFunc.Text))
                {
                    throw new ArgumentException("Informe o telefone do funcionário.");
                }
                if (string.IsNullOrWhiteSpace(txbEmailFunc.Text))
                {
                    throw new ArgumentException("Informe o email do funcionário.");
                }

                bool temCargo = rdbBarbeiro.Checked || rdbTatuador.Checked || rdbVendedor.Checked || rdbAdminist.Checked;
                if (temCargo == false)
                {
                    throw new ArgumentException("Informe o cargo do funcionário.");
                }

                string nome = txbNomeFunc.Text;
                string cpf = txbCpfFunc.Text;
                string telefone = txbTelFunc.Text;
                string email = txbEmailFunc.Text;
                string cargo = ObterTextoSelecionado(gbCargo);

                Funcionario funcionario = new Funcionario();
                funcionario.setNome(nome);
                funcionario.setCpf(cpf);
                funcionario.setTelefone(telefone);
                funcionario.setEmail(email);
                funcionario.setCargo(cargo);

                cadastro.CadastrarFuncionario(funcionario);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ObterTextoSelecionado(GroupBox grupo)
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

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
