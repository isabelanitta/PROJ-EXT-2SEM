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
    public partial class FrmTipoCadastro : Form
    {
        private Cadastro cadastro;
        public FrmTipoCadastro(Cadastro cadastro)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.cadastro = cadastro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadCliente frm = new FrmCadCliente(cadastro);
            frm.ShowDialog();
            this.Show();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadFuncionario frm = new FrmCadFuncionario(cadastro);
            frm.ShowDialog();
            this.Show();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadProduto frm = new FrmCadProduto(cadastro);
            frm.ShowDialog();
            this.Show();
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
