namespace ProjetoExtensao
{
    partial class FrmCadProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxidProd = new System.Windows.Forms.NumericUpDown();
            this.boxEstoque = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrecoProd = new System.Windows.Forms.MaskedTextBox();
            this.txbDescricaoProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxidProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Barbearia Primordial";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnVoltar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(86, 297);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 36);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnCancelarCad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCad.Location = new System.Drawing.Point(293, 297);
            this.btnCancelarCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(127, 36);
            this.btnCancelarCad.TabIndex = 24;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnProximo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(494, 297);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 36);
            this.btnProximo.TabIndex = 23;
            this.btnProximo.Text = "Finalizar";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.boxidProd);
            this.panel1.Controls.Add(this.boxEstoque);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbPrecoProd);
            this.panel1.Controls.Add(this.txbDescricaoProd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbNomeProd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 218);
            this.panel1.TabIndex = 26;
            // 
            // boxidProd
            // 
            this.boxidProd.Location = new System.Drawing.Point(159, 75);
            this.boxidProd.Name = "boxidProd";
            this.boxidProd.Size = new System.Drawing.Size(99, 22);
            this.boxidProd.TabIndex = 30;
            // 
            // boxEstoque
            // 
            this.boxEstoque.Location = new System.Drawing.Point(482, 116);
            this.boxEstoque.Name = "boxEstoque";
            this.boxEstoque.Size = new System.Drawing.Size(99, 22);
            this.boxEstoque.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(380, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(380, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Preço:";
            // 
            // txbPrecoProd
            // 
            this.txbPrecoProd.Location = new System.Drawing.Point(482, 74);
            this.txbPrecoProd.Name = "txbPrecoProd";
            this.txbPrecoProd.Size = new System.Drawing.Size(100, 22);
            this.txbPrecoProd.TabIndex = 26;
            // 
            // txbDescricaoProd
            // 
            this.txbDescricaoProd.Location = new System.Drawing.Point(159, 157);
            this.txbDescricaoProd.Name = "txbDescricaoProd";
            this.txbDescricaoProd.Size = new System.Drawing.Size(181, 22);
            this.txbDescricaoProd.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descrição:";
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.Location = new System.Drawing.Point(159, 115);
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(181, 22);
            this.txbNomeProd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(38, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cadastro de produto";
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(719, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadProduto";
            this.Text = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxidProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescricaoProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txbPrecoProd;
        private System.Windows.Forms.NumericUpDown boxidProd;
        private System.Windows.Forms.NumericUpDown boxEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}