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
    public partial class FrmEdiCPF : Form
    {
        private Cadastro cadastro;

        public FrmEdiCPF(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }
        private Cliente clienteAtual;

        
        public FrmEdiCPF(Cadastro cadastro, Cliente cliente)
        {
            InitializeComponent();
            this.cadastro = cadastro;
            this.clienteAtual = cliente;

            
            if (clienteAtual != null)
            {
                txbCPFnovo.Text = clienteAtual.getCpf();
            }
        }
        private void FrmEdiCPF_Load(object sender, EventArgs e)
        {
          
        }
        private void bttnConfEdi_Click(object sender, EventArgs e)
        {
            try
            {
                string cpfAntigo = txbCPFantigo.Text.Trim();
                string cpfNovo = txbCPFnovo.Text.Trim();

                if (string.IsNullOrWhiteSpace(cpfAntigo) || string.IsNullOrWhiteSpace(cpfNovo))
                    throw new ArgumentException("Preencha os dois campos de CPF.");

                Cliente cliente = cadastro.PesquisarClientePorCPF(cpfAntigo);

                if (cliente == null)
                    throw new Exception("Cliente não encontrado.");

                if (cpfAntigo != cpfNovo)
                {
                    Cliente clienteExistente = cadastro.PesquisarClientePorCPF(cpfNovo);
                    if (clienteExistente != null)
                        throw new ArgumentException("CPF já cadastrado em outro cliente.");
                }
                cliente.setCpf(cpfNovo);

               
              
                MessageBox.Show("CPF atualizado com sucesso!");
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void bttnCancelEdicpf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
