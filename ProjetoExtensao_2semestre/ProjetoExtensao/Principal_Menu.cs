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
    public partial class FrmPrincipal_Menu : Form
    {
        private Cadastro cadastro;

        public FrmPrincipal_Menu(Cadastro cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmTipoCadastro frmCadastro = new FrmTipoCadastro(cadastro);

            frmCadastro.ShowDialog();
        }
        private void Principal_Menu_Load(object sender, EventArgs e)
        {
             
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar = new FrmEditar(cadastro);
            frmEditar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPesquisar frmPesquisar = new FrmPesquisar(cadastro);
            frmPesquisar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRelatorio frmRelatorio = new FrmRelatorio(cadastro);
            frmRelatorio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRemover frmRemover = new FrmRemover(cadastro);
            frmRemover.Show();
        }
    }
}
