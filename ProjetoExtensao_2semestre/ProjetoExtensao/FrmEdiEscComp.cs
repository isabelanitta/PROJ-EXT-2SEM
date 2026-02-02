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
    public partial class FrmEdiEscComp : Form
    {
        private Cadastro cadastro;

        public FrmEdiEscComp(Cadastro cadastro, Cliente clienteAtual)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnConfEdi_Click(object sender, EventArgs e)
        {
            if (!rbtSim.Checked && !rbtNao.Checked)
            {
                MessageBox.Show("Selecione uma opção.");
                return;
            }

            if (rbtNao.Checked)
            {
                
                this.Close();
            }
            else if (rbtSim.Checked)
            {
                FrmEdiCompra frm = new FrmEdiCompra(cadastro);
                this.Hide();
                frm.ShowDialog(); // Usa ShowDialog para bloquear
                this.Close(); // Fecha o form ao invés de esconder
            }

        }

        private void FrmEdiEscComp_Load(object sender, EventArgs e)
        {

        }
    }
}
