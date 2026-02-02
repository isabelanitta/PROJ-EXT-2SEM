namespace ProjetoExtensao
{
    partial class FrmCadCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbServicos = new System.Windows.Forms.GroupBox();
            this.rdbCompleto = new System.Windows.Forms.RadioButton();
            this.rdbCorteBarba = new System.Windows.Forms.RadioButton();
            this.rdbCorteSomb = new System.Windows.Forms.RadioButton();
            this.rdbCorte = new System.Windows.Forms.RadioButton();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.rdbVinicios = new System.Windows.Forms.RadioButton();
            this.rdbMaycon = new System.Windows.Forms.RadioButton();
            this.rdbMaillon = new System.Windows.Forms.RadioButton();
            this.rdbTheo = new System.Windows.Forms.RadioButton();
            this.rdbTavin = new System.Windows.Forms.RadioButton();
            this.txbTelefonecliente = new System.Windows.Forms.TextBox();
            this.txbNomecliente = new System.Windows.Forms.TextBox();
            this.txbCPFcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHorario = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbServicos.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtData);
            this.panel1.Controls.Add(this.gbServicos);
            this.panel1.Controls.Add(this.gbFuncionario);
            this.panel1.Controls.Add(this.txbTelefonecliente);
            this.panel1.Controls.Add(this.txbNomecliente);
            this.panel1.Controls.Add(this.txbCPFcliente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtHorario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(45, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 384);
            this.panel1.TabIndex = 3;
            // 
            // gbServicos
            // 
            this.gbServicos.Controls.Add(this.rdbCompleto);
            this.gbServicos.Controls.Add(this.rdbCorteBarba);
            this.gbServicos.Controls.Add(this.rdbCorteSomb);
            this.gbServicos.Controls.Add(this.rdbCorte);
            this.gbServicos.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbServicos.Location = new System.Drawing.Point(26, 178);
            this.gbServicos.Name = "gbServicos";
            this.gbServicos.Size = new System.Drawing.Size(467, 178);
            this.gbServicos.TabIndex = 22;
            this.gbServicos.TabStop = false;
            this.gbServicos.Text = "Serviço desejado";
            // 
            // rdbCompleto
            // 
            this.rdbCompleto.AutoSize = true;
            this.rdbCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbCompleto.Location = new System.Drawing.Point(19, 130);
            this.rdbCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCompleto.Name = "rdbCompleto";
            this.rdbCompleto.Size = new System.Drawing.Size(407, 29);
            this.rdbCompleto.TabIndex = 21;
            this.rdbCompleto.TabStop = true;
            this.rdbCompleto.Text = "Corte + Barba + Sobrancelha:........R$70,00";
            this.rdbCompleto.UseVisualStyleBackColor = true;
            // 
            // rdbCorteBarba
            // 
            this.rdbCorteBarba.AutoSize = true;
            this.rdbCorteBarba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorteBarba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbCorteBarba.Location = new System.Drawing.Point(19, 97);
            this.rdbCorteBarba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCorteBarba.Name = "rdbCorteBarba";
            this.rdbCorteBarba.Size = new System.Drawing.Size(409, 29);
            this.rdbCorteBarba.TabIndex = 20;
            this.rdbCorteBarba.TabStop = true;
            this.rdbCorteBarba.Text = "Corte + Barba:...................................R$60,00";
            this.rdbCorteBarba.UseVisualStyleBackColor = true;
            // 
            // rdbCorteSomb
            // 
            this.rdbCorteSomb.AutoSize = true;
            this.rdbCorteSomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorteSomb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbCorteSomb.Location = new System.Drawing.Point(19, 64);
            this.rdbCorteSomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCorteSomb.Name = "rdbCorteSomb";
            this.rdbCorteSomb.Size = new System.Drawing.Size(408, 29);
            this.rdbCorteSomb.TabIndex = 19;
            this.rdbCorteSomb.TabStop = true;
            this.rdbCorteSomb.Text = "Corte + Sobrancelha:.......................R$45,00";
            this.rdbCorteSomb.UseVisualStyleBackColor = true;
            // 
            // rdbCorte
            // 
            this.rdbCorte.AutoSize = true;
            this.rdbCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbCorte.Location = new System.Drawing.Point(19, 31);
            this.rdbCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCorte.Name = "rdbCorte";
            this.rdbCorte.Size = new System.Drawing.Size(410, 29);
            this.rdbCorte.TabIndex = 17;
            this.rdbCorte.TabStop = true;
            this.rdbCorte.Text = "Corte:..................................................R$35,00";
            this.rdbCorte.UseVisualStyleBackColor = true;
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.rdbVinicios);
            this.gbFuncionario.Controls.Add(this.rdbMaycon);
            this.gbFuncionario.Controls.Add(this.rdbMaillon);
            this.gbFuncionario.Controls.Add(this.rdbTheo);
            this.gbFuncionario.Controls.Add(this.rdbTavin);
            this.gbFuncionario.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbFuncionario.Location = new System.Drawing.Point(559, 158);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(252, 198);
            this.gbFuncionario.TabIndex = 18;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário disponível";
            // 
            // rdbVinicios
            // 
            this.rdbVinicios.AutoSize = true;
            this.rdbVinicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVinicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbVinicios.Location = new System.Drawing.Point(28, 152);
            this.rdbVinicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbVinicios.Name = "rdbVinicios";
            this.rdbVinicios.Size = new System.Drawing.Size(101, 29);
            this.rdbVinicios.TabIndex = 16;
            this.rdbVinicios.TabStop = true;
            this.rdbVinicios.Text = "Vinicios";
            this.rdbVinicios.UseVisualStyleBackColor = true;
            // 
            // rdbMaycon
            // 
            this.rdbMaycon.AutoSize = true;
            this.rdbMaycon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaycon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbMaycon.Location = new System.Drawing.Point(28, 119);
            this.rdbMaycon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMaycon.Name = "rdbMaycon";
            this.rdbMaycon.Size = new System.Drawing.Size(103, 29);
            this.rdbMaycon.TabIndex = 15;
            this.rdbMaycon.TabStop = true;
            this.rdbMaycon.Text = "Maycon";
            this.rdbMaycon.UseVisualStyleBackColor = true;
            // 
            // rdbMaillon
            // 
            this.rdbMaillon.AutoSize = true;
            this.rdbMaillon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaillon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbMaillon.Location = new System.Drawing.Point(28, 92);
            this.rdbMaillon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMaillon.Name = "rdbMaillon";
            this.rdbMaillon.Size = new System.Drawing.Size(95, 29);
            this.rdbMaillon.TabIndex = 14;
            this.rdbMaillon.TabStop = true;
            this.rdbMaillon.Text = "Maillon";
            this.rdbMaillon.UseVisualStyleBackColor = true;
            // 
            // rdbTheo
            // 
            this.rdbTheo.AutoSize = true;
            this.rdbTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTheo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbTheo.Location = new System.Drawing.Point(28, 67);
            this.rdbTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTheo.Name = "rdbTheo";
            this.rdbTheo.Size = new System.Drawing.Size(79, 29);
            this.rdbTheo.TabIndex = 13;
            this.rdbTheo.TabStop = true;
            this.rdbTheo.Text = "Theo";
            this.rdbTheo.UseVisualStyleBackColor = true;
            // 
            // rdbTavin
            // 
            this.rdbTavin.AutoSize = true;
            this.rdbTavin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTavin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rdbTavin.Location = new System.Drawing.Point(28, 43);
            this.rdbTavin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbTavin.Name = "rdbTavin";
            this.rdbTavin.Size = new System.Drawing.Size(82, 29);
            this.rdbTavin.TabIndex = 12;
            this.rdbTavin.TabStop = true;
            this.rdbTavin.Text = "Tavin";
            this.rdbTavin.UseVisualStyleBackColor = true;
            // 
            // txbTelefonecliente
            // 
            this.txbTelefonecliente.Location = new System.Drawing.Point(125, 126);
            this.txbTelefonecliente.Name = "txbTelefonecliente";
            this.txbTelefonecliente.Size = new System.Drawing.Size(181, 22);
            this.txbTelefonecliente.TabIndex = 11;
            // 
            // txbNomecliente
            // 
            this.txbNomecliente.Location = new System.Drawing.Point(125, 89);
            this.txbNomecliente.Name = "txbNomecliente";
            this.txbNomecliente.Size = new System.Drawing.Size(181, 22);
            this.txbNomecliente.TabIndex = 10;
            // 
            // txbCPFcliente
            // 
            this.txbCPFcliente.Location = new System.Drawing.Point(125, 52);
            this.txbCPFcliente.Name = "txbCPFcliente";
            this.txbCPFcliente.Size = new System.Drawing.Size(181, 22);
            this.txbCPFcliente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // dtHorario
            // 
            this.dtHorario.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.dtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHorario.Location = new System.Drawing.Point(636, 71);
            this.dtHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHorario.Name = "dtHorario";
            this.dtHorario.ShowUpDown = true;
            this.dtHorario.Size = new System.Drawing.Size(175, 41);
            this.dtHorario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(632, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horário marcado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastro do cliente";
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnProximo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(654, 438);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 36);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barbearia Primordial";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnVoltar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(148, 437);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 36);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.btnCancelarCad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCad.Location = new System.Drawing.Point(402, 438);
            this.btnCancelarCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(127, 36);
            this.btnCancelarCad.TabIndex = 9;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(357, 71);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(210, 41);
            this.dtData.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(355, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Data marcada:";
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(943, 485);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro (info. cliente) Barbearia Primordial";
            this.Load += new System.EventHandler(this.FrmCadHorario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbServicos.ResumeLayout(false);
            this.gbServicos.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHorario;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTelefonecliente;
        private System.Windows.Forms.TextBox txbNomecliente;
        private System.Windows.Forms.TextBox txbCPFcliente;
        private System.Windows.Forms.RadioButton rdbVinicios;
        private System.Windows.Forms.RadioButton rdbMaycon;
        private System.Windows.Forms.RadioButton rdbMaillon;
        private System.Windows.Forms.RadioButton rdbTheo;
        private System.Windows.Forms.RadioButton rdbTavin;
        private System.Windows.Forms.RadioButton rdbCorte;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.GroupBox gbServicos;
        private System.Windows.Forms.RadioButton rdbCompleto;
        private System.Windows.Forms.RadioButton rdbCorteBarba;
        private System.Windows.Forms.RadioButton rdbCorteSomb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtData;
    }
}