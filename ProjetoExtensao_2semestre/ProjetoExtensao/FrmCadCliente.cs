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
    public partial class FrmCadCliente : Form
    {
        private Cadastro cadastro;

        public FrmCadCliente(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }
        private void FrmCadHorario_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbNomecliente.Text))
                    throw new ArgumentException("Informe o nome do cliente.");

                if (string.IsNullOrWhiteSpace(txbCPFcliente.Text))
                    throw new ArgumentException("Informe o CPF.");

                if (string.IsNullOrWhiteSpace(txbTelefonecliente.Text))
                    throw new ArgumentException("Informe o telefone.");

                bool temServico = gbServicos.Controls.OfType<RadioButton>().Any(r => r.Checked);
                if (!temServico)
                    throw new ArgumentException("Informe um tipo de serviço.");

                bool temFuncionario = gbFuncionario.Controls.OfType<RadioButton>().Any(r => r.Checked);
                if (!temFuncionario)
                    throw new ArgumentException("Informe um funcionário.");

                if (cadastro.PesquisarClientePorCPF(txbCPFcliente.Text) != null)
                    throw new ArgumentException("CPF já cadastrado no sistema.");

                Cliente cliente = new Cliente();

                cliente.setNome(txbNomecliente.Text);
                cliente.setCpf(txbCPFcliente.Text);
                cliente.setTelefone(txbTelefonecliente.Text);
                cliente.setServicoEscolhido(ObterTextoSelecionado(gbServicos));
                cliente.setFuncioEscolhido(ObterTextoSelecionado(gbFuncionario));
                cliente.setHorarioMarcado(dtHorario.Value);
                cliente.setDataMarcada(dtData.Value);

                cadastro.CadastrarCliente(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");

                this.Hide();
                FrmCadEscolhaCompra proxima = new FrmCadEscolhaCompra(cadastro);
                proxima.ShowDialog();
                this.Close();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private string ObterTextoSelecionado(GroupBox grupo)
        {
            return grupo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
