namespace ProjetoExtensao
{
    partial class FrmCadCompras
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTamCreme = new System.Windows.Forms.GroupBox();
            this.rdb200ml = new System.Windows.Forms.RadioButton();
            this.rdb100ml = new System.Windows.Forms.RadioButton();
            this.rdb50ml = new System.Windows.Forms.RadioButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbTamRoupa = new System.Windows.Forms.GroupBox();
            this.rdbGG = new System.Windows.Forms.RadioButton();
            this.rdbG = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbP = new System.Windows.Forms.RadioButton();
            this.boxQuantd = new System.Windows.Forms.NumericUpDown();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbTamCreme.SuspendLayout();
            this.gbTamRoupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnVoltar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(94, 303);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 29);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnCancelarCad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCad.Location = new System.Drawing.Point(212, 303);
            this.btnCancelarCad.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(95, 29);
            this.btnCancelarCad.TabIndex = 12;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Barbearia Primordial";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.gbTamCreme);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.gbTamRoupa);
            this.panel1.Controls.Add(this.boxQuantd);
            this.panel1.Controls.Add(this.cbProduto);
            this.panel1.Controls.Add(this.btnAddProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 265);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbTamCreme
            // 
            this.gbTamCreme.Controls.Add(this.rdb200ml);
            this.gbTamCreme.Controls.Add(this.rdb100ml);
            this.gbTamCreme.Controls.Add(this.rdb50ml);
            this.gbTamCreme.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTamCreme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbTamCreme.Location = new System.Drawing.Point(203, 109);
            this.gbTamCreme.Margin = new System.Windows.Forms.Padding(2);
            this.gbTamCreme.Name = "gbTamCreme";
            this.gbTamCreme.Padding = new System.Windows.Forms.Padding(2);
            this.gbTamCreme.Size = new System.Drawing.Size(242, 71);
            this.gbTamCreme.TabIndex = 18;
            this.gbTamCreme.TabStop = false;
            this.gbTamCreme.Text = "Tamanho:";
            // 
            // rdb200ml
            // 
            this.rdb200ml.AutoSize = true;
            this.rdb200ml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb200ml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdb200ml.Location = new System.Drawing.Point(165, 29);
            this.rdb200ml.Margin = new System.Windows.Forms.Padding(2);
            this.rdb200ml.Name = "rdb200ml";
            this.rdb200ml.Size = new System.Drawing.Size(70, 24);
            this.rdb200ml.TabIndex = 12;
            this.rdb200ml.TabStop = true;
            this.rdb200ml.Text = "200ml";
            this.rdb200ml.UseVisualStyleBackColor = true;
            this.rdb200ml.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdb100ml
            // 
            this.rdb100ml.AutoSize = true;
            this.rdb100ml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb100ml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdb100ml.Location = new System.Drawing.Point(91, 29);
            this.rdb100ml.Margin = new System.Windows.Forms.Padding(2);
            this.rdb100ml.Name = "rdb100ml";
            this.rdb100ml.Size = new System.Drawing.Size(70, 24);
            this.rdb100ml.TabIndex = 11;
            this.rdb100ml.TabStop = true;
            this.rdb100ml.Text = "100ml";
            this.rdb100ml.UseVisualStyleBackColor = true;
            // 
            // rdb50ml
            // 
            this.rdb50ml.AutoSize = true;
            this.rdb50ml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb50ml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdb50ml.Location = new System.Drawing.Point(14, 29);
            this.rdb50ml.Margin = new System.Windows.Forms.Padding(2);
            this.rdb50ml.Name = "rdb50ml";
            this.rdb50ml.Size = new System.Drawing.Size(61, 24);
            this.rdb50ml.TabIndex = 9;
            this.rdb50ml.TabStop = true;
            this.rdb50ml.Text = "50ml";
            this.rdb50ml.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Roupa",
            "Produto de cabelo",
            "Produto de tatuagem"});
            this.cbCategoria.Location = new System.Drawing.Point(17, 57);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 23);
            this.cbCategoria.TabIndex = 18;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // gbTamRoupa
            // 
            this.gbTamRoupa.Controls.Add(this.rdbGG);
            this.gbTamRoupa.Controls.Add(this.rdbG);
            this.gbTamRoupa.Controls.Add(this.rdbM);
            this.gbTamRoupa.Controls.Add(this.rdbP);
            this.gbTamRoupa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTamRoupa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbTamRoupa.Location = new System.Drawing.Point(203, 21);
            this.gbTamRoupa.Margin = new System.Windows.Forms.Padding(2);
            this.gbTamRoupa.Name = "gbTamRoupa";
            this.gbTamRoupa.Padding = new System.Windows.Forms.Padding(2);
            this.gbTamRoupa.Size = new System.Drawing.Size(242, 71);
            this.gbTamRoupa.TabIndex = 17;
            this.gbTamRoupa.TabStop = false;
            this.gbTamRoupa.Text = "Tamanho:";
            // 
            // rdbGG
            // 
            this.rdbGG.AutoSize = true;
            this.rdbGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbGG.Location = new System.Drawing.Point(182, 29);
            this.rdbGG.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGG.Name = "rdbGG";
            this.rdbGG.Size = new System.Drawing.Size(53, 24);
            this.rdbGG.TabIndex = 13;
            this.rdbGG.TabStop = true;
            this.rdbGG.Text = "GG";
            this.rdbGG.UseVisualStyleBackColor = true;
            // 
            // rdbG
            // 
            this.rdbG.AutoSize = true;
            this.rdbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbG.Location = new System.Drawing.Point(127, 29);
            this.rdbG.Margin = new System.Windows.Forms.Padding(2);
            this.rdbG.Name = "rdbG";
            this.rdbG.Size = new System.Drawing.Size(40, 24);
            this.rdbG.TabIndex = 12;
            this.rdbG.TabStop = true;
            this.rdbG.Text = "G";
            this.rdbG.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbM.Location = new System.Drawing.Point(70, 29);
            this.rdbM.Margin = new System.Windows.Forms.Padding(2);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(40, 24);
            this.rdbM.TabIndex = 11;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbP
            // 
            this.rdbP.AutoSize = true;
            this.rdbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbP.Location = new System.Drawing.Point(14, 29);
            this.rdbP.Margin = new System.Windows.Forms.Padding(2);
            this.rdbP.Name = "rdbP";
            this.rdbP.Size = new System.Drawing.Size(37, 24);
            this.rdbP.TabIndex = 9;
            this.rdbP.TabStop = true;
            this.rdbP.Text = "P";
            this.rdbP.UseVisualStyleBackColor = true;
            // 
            // boxQuantd
            // 
            this.boxQuantd.Location = new System.Drawing.Point(203, 225);
            this.boxQuantd.Margin = new System.Windows.Forms.Padding(2);
            this.boxQuantd.Name = "boxQuantd";
            this.boxQuantd.Size = new System.Drawing.Size(57, 20);
            this.boxQuantd.TabIndex = 14;
            this.boxQuantd.Minimum = 1;
            this.boxQuantd.Value = 1;
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(17, 120);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(165, 23);
            this.cbProduto.TabIndex = 8;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddProd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddProd.Location = new System.Drawing.Point(325, 200);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(108, 43);
            this.btnAddProd.TabIndex = 6;
            this.btnAddProd.Text = "Adicionar";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(200, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastro";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(334, 303);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(95, 29);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmCadCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(533, 341);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro (Produtos) Barbearia Primordial";
            this.Load += new System.EventHandler(this.FrmCadCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTamCreme.ResumeLayout(false);
            this.gbTamCreme.PerformLayout();
            this.gbTamRoupa.ResumeLayout(false);
            this.gbTamRoupa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.NumericUpDown boxQuantd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.GroupBox gbTamRoupa;
        private System.Windows.Forms.RadioButton rdbGG;
        private System.Windows.Forms.RadioButton rdbG;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbP;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gbTamCreme;
        private System.Windows.Forms.RadioButton rdb200ml;
        private System.Windows.Forms.RadioButton rdb100ml;
        private System.Windows.Forms.RadioButton rdb50ml;
    }
}