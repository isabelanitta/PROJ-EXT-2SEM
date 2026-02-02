namespace ProjetoExtensao
{
    partial class FrmCadFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTelFunc = new System.Windows.Forms.TextBox();
            this.txbNomeFunc = new System.Windows.Forms.TextBox();
            this.txbCpfFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCargo = new System.Windows.Forms.GroupBox();
            this.rdbAdminist = new System.Windows.Forms.RadioButton();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.rdbTatuador = new System.Windows.Forms.RadioButton();
            this.rdbBarbeiro = new System.Windows.Forms.RadioButton();
            this.txbEmailFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.gbCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTelFunc
            // 
            this.txbTelFunc.Location = new System.Drawing.Point(98, 119);
            this.txbTelFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTelFunc.Name = "txbTelFunc";
            this.txbTelFunc.Size = new System.Drawing.Size(137, 20);
            this.txbTelFunc.TabIndex = 17;
            // 
            // txbNomeFunc
            // 
            this.txbNomeFunc.Location = new System.Drawing.Point(98, 89);
            this.txbNomeFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNomeFunc.Name = "txbNomeFunc";
            this.txbNomeFunc.Size = new System.Drawing.Size(137, 20);
            this.txbNomeFunc.TabIndex = 16;
            // 
            // txbCpfFunc
            // 
            this.txbCpfFunc.Location = new System.Drawing.Point(98, 58);
            this.txbCpfFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCpfFunc.Name = "txbCpfFunc";
            this.txbCpfFunc.Size = new System.Drawing.Size(137, 20);
            this.txbCpfFunc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(20, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cadastro do funcionário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.gbCargo);
            this.panel1.Controls.Add(this.txbEmailFunc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTelFunc);
            this.panel1.Controls.Add(this.txbNomeFunc);
            this.panel1.Controls.Add(this.txbCpfFunc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(39, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 208);
            this.panel1.TabIndex = 19;
            // 
            // gbCargo
            // 
            this.gbCargo.Controls.Add(this.rdbAdminist);
            this.gbCargo.Controls.Add(this.rdbVendedor);
            this.gbCargo.Controls.Add(this.rdbTatuador);
            this.gbCargo.Controls.Add(this.rdbBarbeiro);
            this.gbCargo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbCargo.Location = new System.Drawing.Point(264, 28);
            this.gbCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCargo.Size = new System.Drawing.Size(160, 156);
            this.gbCargo.TabIndex = 26;
            this.gbCargo.TabStop = false;
            this.gbCargo.Text = "Cargo:";
            // 
            // rdbAdminist
            // 
            this.rdbAdminist.AutoSize = true;
            this.rdbAdminist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdminist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbAdminist.Location = new System.Drawing.Point(21, 117);
            this.rdbAdminist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAdminist.Name = "rdbAdminist";
            this.rdbAdminist.Size = new System.Drawing.Size(125, 24);
            this.rdbAdminist.TabIndex = 25;
            this.rdbAdminist.TabStop = true;
            this.rdbAdminist.Text = "Administrador";
            this.rdbAdminist.UseVisualStyleBackColor = true;
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbVendedor.Location = new System.Drawing.Point(21, 89);
            this.rdbVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(97, 24);
            this.rdbVendedor.TabIndex = 24;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbTatuador
            // 
            this.rdbTatuador.AutoSize = true;
            this.rdbTatuador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatuador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbTatuador.Location = new System.Drawing.Point(21, 60);
            this.rdbTatuador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbTatuador.Name = "rdbTatuador";
            this.rdbTatuador.Size = new System.Drawing.Size(91, 24);
            this.rdbTatuador.TabIndex = 23;
            this.rdbTatuador.TabStop = true;
            this.rdbTatuador.Text = "Tatuador";
            this.rdbTatuador.UseVisualStyleBackColor = true;
            // 
            // rdbBarbeiro
            // 
            this.rdbBarbeiro.AutoSize = true;
            this.rdbBarbeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBarbeiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbBarbeiro.Location = new System.Drawing.Point(21, 32);
            this.rdbBarbeiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbBarbeiro.Name = "rdbBarbeiro";
            this.rdbBarbeiro.Size = new System.Drawing.Size(87, 24);
            this.rdbBarbeiro.TabIndex = 22;
            this.rdbBarbeiro.TabStop = true;
            this.rdbBarbeiro.Text = "Barbeiro";
            this.rdbBarbeiro.UseVisualStyleBackColor = true;
            // 
            // txbEmailFunc
            // 
            this.txbEmailFunc.Location = new System.Drawing.Point(98, 150);
            this.txbEmailFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEmailFunc.Name = "txbEmailFunc";
            this.txbEmailFunc.Size = new System.Drawing.Size(137, 20);
            this.txbEmailFunc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Barbearia Primordial";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnVoltar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(56, 254);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 29);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnCancelarCad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCad.Location = new System.Drawing.Point(212, 254);
            this.btnCancelarCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(95, 29);
            this.btnCancelarCad.TabIndex = 21;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnProximo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(362, 254);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(95, 29);
            this.btnProximo.TabIndex = 20;
            this.btnProximo.Text = "Finalizar";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(524, 292);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCadFuncionario";
            this.Text = "CadFuncionario";
            this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCargo.ResumeLayout(false);
            this.gbCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTelFunc;
        private System.Windows.Forms.TextBox txbNomeFunc;
        private System.Windows.Forms.TextBox txbCpfFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txbEmailFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbBarbeiro;
        private System.Windows.Forms.RadioButton rdbTatuador;
        private System.Windows.Forms.RadioButton rdbAdminist;
        private System.Windows.Forms.RadioButton rdbVendedor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox gbCargo;
    }
}