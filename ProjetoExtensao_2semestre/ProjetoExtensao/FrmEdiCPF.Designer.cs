namespace ProjetoExtensao
{
    partial class FrmEdiCPF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCPFantigo = new System.Windows.Forms.Label();
            this.lblCPFnovo = new System.Windows.Forms.Label();
            this.txbCPFantigo = new System.Windows.Forms.TextBox();
            this.txbCPFnovo = new System.Windows.Forms.TextBox();
            this.bttnConfEdi = new System.Windows.Forms.Button();
            this.bttnCancelEdicpf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCPFantigo
            // 
            this.lblCPFantigo.AutoSize = true;
            this.lblCPFantigo.Location = new System.Drawing.Point(30, 30);
            this.lblCPFantigo.Name = "lblCPFantigo";
            this.lblCPFantigo.Size = new System.Drawing.Size(63, 13);
            this.lblCPFantigo.TabIndex = 0;
            this.lblCPFantigo.Text = "CPF Antigo:";
            // 
            // lblCPFnovo
            // 
            this.lblCPFnovo.AutoSize = true;
            this.lblCPFnovo.Location = new System.Drawing.Point(30, 90);
            this.lblCPFnovo.Name = "lblCPFnovo";
            this.lblCPFnovo.Size = new System.Drawing.Size(59, 13);
            this.lblCPFnovo.TabIndex = 1;
            this.lblCPFnovo.Text = "CPF Novo:";
            // 
            // txbCPFantigo
            // 
            this.txbCPFantigo.Location = new System.Drawing.Point(30, 50);
            this.txbCPFantigo.Name = "txbCPFantigo";
            this.txbCPFantigo.Size = new System.Drawing.Size(200, 20);
            this.txbCPFantigo.TabIndex = 2;
            // 
            // txbCPFnovo
            // 
            this.txbCPFnovo.Location = new System.Drawing.Point(30, 110);
            this.txbCPFnovo.Name = "txbCPFnovo";
            this.txbCPFnovo.Size = new System.Drawing.Size(200, 20);
            this.txbCPFnovo.TabIndex = 3;
            // 
            // bttnConfEdi
            // 
            this.bttnConfEdi.Location = new System.Drawing.Point(30, 160);
            this.bttnConfEdi.Name = "bttnConfEdi";
            this.bttnConfEdi.Size = new System.Drawing.Size(90, 30);
            this.bttnConfEdi.TabIndex = 4;
            this.bttnConfEdi.Text = "Confirmar";
            this.bttnConfEdi.UseVisualStyleBackColor = true;
            this.bttnConfEdi.Click += new System.EventHandler(this.bttnConfEdi_Click);
            // 
            // bttnCancelEdicpf
            // 
            this.bttnCancelEdicpf.Location = new System.Drawing.Point(140, 160);
            this.bttnCancelEdicpf.Name = "bttnCancelEdicpf";
            this.bttnCancelEdicpf.Size = new System.Drawing.Size(90, 30);
            this.bttnCancelEdicpf.TabIndex = 5;
            this.bttnCancelEdicpf.Text = "Cancelar";
            this.bttnCancelEdicpf.UseVisualStyleBackColor = true;
            this.bttnCancelEdicpf.Click += new System.EventHandler(this.bttnCancelEdicpf_Click);
            // 
            // FrmEdiCPF
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(73)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(270, 220);
            this.Controls.Add(this.bttnCancelEdicpf);
            this.Controls.Add(this.bttnConfEdi);
            this.Controls.Add(this.txbCPFnovo);
            this.Controls.Add(this.txbCPFantigo);
            this.Controls.Add(this.lblCPFnovo);
            this.Controls.Add(this.lblCPFantigo);
            this.Name = "FrmEdiCPF";
            this.Text = "Editar CPF";
            this.Load += new System.EventHandler(this.FrmEdiCPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCPFantigo;
        private System.Windows.Forms.Label lblCPFnovo;
        private System.Windows.Forms.TextBox txbCPFantigo;
        private System.Windows.Forms.TextBox txbCPFnovo;
        private System.Windows.Forms.Button bttnConfEdi;
        private System.Windows.Forms.Button bttnCancelEdicpf;
    }
}