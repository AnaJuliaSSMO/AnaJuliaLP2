namespace TheFarmOfUs
{
    partial class DemitirFunc
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
            this.cance = new System.Windows.Forms.Button();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.att = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outromotivo = new System.Windows.Forms.TextBox();
            this.motivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cance
            // 
            this.cance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cance.Location = new System.Drawing.Point(116, 459);
            this.cance.Name = "cance";
            this.cance.Size = new System.Drawing.Size(325, 39);
            this.cance.TabIndex = 34;
            this.cance.Text = "Cancelar operação";
            this.cance.UseVisualStyleBackColor = true;
            this.cance.Click += new System.EventHandler(this.cance_Click);
            // 
            // nometxt
            // 
            this.nometxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.Location = new System.Drawing.Point(153, 104);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(387, 29);
            this.nometxt.TabIndex = 33;
            // 
            // att
            // 
            this.att.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att.Location = new System.Drawing.Point(116, 409);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(325, 39);
            this.att.TabIndex = 29;
            this.att.Text = "Demitir funcionário";
            this.att.UseVisualStyleBackColor = true;
            this.att.Click += new System.EventHandler(this.att_Click);
            // 
            // CPF
            // 
            this.CPF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(218, 45);
            this.CPF.Mask = "000,000,000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(148, 29);
            this.CPF.TabIndex = 28;
            this.CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Insira o(a):\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Motivo da demissão:";
            // 
            // outromotivo
            // 
            this.outromotivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outromotivo.Location = new System.Drawing.Point(51, 276);
            this.outromotivo.Name = "outromotivo";
            this.outromotivo.Size = new System.Drawing.Size(449, 29);
            this.outromotivo.TabIndex = 57;
            // 
            // motivo
            // 
            this.motivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo.FormattingEnabled = true;
            this.motivo.Items.AddRange(new object[] {
            "Fim do contrato",
            "Roubo",
            "Agressão física",
            "Atrasos constantes",
            "Faltas constantes totalizadas em mais de 30 dias",
            "Falência da empresa",
            "Redução de funcionários",
            "Não atende mais aos requisitos da empresa",
            "Outro"});
            this.motivo.Location = new System.Drawing.Point(53, 233);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(448, 30);
            this.motivo.TabIndex = 56;
            this.motivo.SelectedIndexChanged += new System.EventHandler(this.motivo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 66);
            this.label5.TabIndex = 58;
            this.label5.Text = "Todos os registros (tanto funcionário como login)\r\nsão removidos automaticamente " +
    "após a demissão\r\ndo indivíduo.\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "Data de hoje:";
            // 
            // today
            // 
            this.today.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.Location = new System.Drawing.Point(275, 149);
            this.today.Mask = "00/00/0000";
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(111, 29);
            this.today.TabIndex = 60;
            this.today.ValidatingType = typeof(System.DateTime);
            // 
            // DemitirFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 507);
            this.Controls.Add(this.today);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outromotivo);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cance);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.att);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DemitirFunc";
            this.Text = "DemitirFunc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cance;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Button att;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outromotivo;
        private System.Windows.Forms.ComboBox motivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox today;
    }
}