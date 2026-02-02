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
    public partial class FrmEdiHor : Form
    {
        private Cadastro cadastro;
        private Cliente clienteAtual;
        public FrmEdiHor(Cadastro cadastro, Cliente cliente)
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
                DateTime horaSelecionada = DateTimeCadNovo.Value;

               
                DateTime dataOriginal = clienteAtual.getDataMarcada();

                DateTime dataHoraFinal = new DateTime(
                    dataOriginal.Year,
                    dataOriginal.Month,
                    dataOriginal.Day,
                    horaSelecionada.Hour,
                    horaSelecionada.Minute,
                    0
                );

               
               

                clienteAtual.setHorarioMarcado(dataHoraFinal);

                MessageBox.Show("HORÁRIO editado com SUCESSO!");
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao editar horário: " + erro.Message);
            }

        }

        private void FrmEdiHor_Load(object sender, EventArgs e)
        {
            if (clienteAtual != null)
            {
                DateTimeCadNovo.Value = clienteAtual.getHorarioMarcado();
            }

        }
    }
}
