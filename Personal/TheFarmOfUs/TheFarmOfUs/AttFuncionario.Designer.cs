namespace TheFarmOfUs
{
    partial class AttFuncionario
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
            this.setores = new System.Windows.Forms.ComboBox();
            this.nasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.att = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cance
            // 
            this.cance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cance.Location = new System.Drawing.Point(128, 301);
            this.cance.Name = "cance";
            this.cance.Size = new System.Drawing.Size(325, 39);
            this.cance.TabIndex = 25;
            this.cance.Text = "Cancelar operação";
            this.cance.UseVisualStyleBackColor = true;
            this.cance.Click += new System.EventHandler(this.cance_Click);
            // 
            // nometxt
            // 
            this.nometxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.Location = new System.Drawing.Point(163, 87);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(387, 29);
            this.nometxt.TabIndex = 23;
            // 
            // setores
            // 
            this.setores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setores.FormattingEnabled = true;
            this.setores.Items.AddRange(new object[] {
            "Agricultura",
            "Contabilidade",
            "Pecuaria"});
            this.setores.Location = new System.Drawing.Point(82, 196);
            this.setores.Name = "setores";
            this.setores.Size = new System.Drawing.Size(229, 30);
            this.setores.TabIndex = 22;
            // 
            // nasc
            // 
            this.nasc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nasc.Location = new System.Drawing.Point(200, 140);
            this.nasc.Mask = "00/00/0000";
            this.nasc.Name = "nasc";
            this.nasc.Size = new System.Drawing.Size(111, 29);
            this.nasc.TabIndex = 21;
            this.nasc.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data de nascimento:";
            // 
            // att
            // 
            this.att.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att.Location = new System.Drawing.Point(128, 251);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(325, 39);
            this.att.TabIndex = 18;
            this.att.Text = "Atualizar registro";
            this.att.UseVisualStyleBackColor = true;
            this.att.Click += new System.EventHandler(this.att_Click);
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(72, 29);
            this.cpf.Mask = "000,000,000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(148, 29);
            this.cpf.TabIndex = 17;
            this.cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insira o(a):\r\n";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.ForeColor = System.Drawing.Color.Red;
            this.txt.Location = new System.Drawing.Point(21, 69);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(0, 13);
            this.txt.TabIndex = 26;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(21, 121);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(0, 13);
            this.txt1.TabIndex = 27;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.ForeColor = System.Drawing.Color.Red;
            this.txt2.Location = new System.Drawing.Point(21, 169);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(0, 13);
            this.txt2.TabIndex = 28;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.ForeColor = System.Drawing.Color.Red;
            this.txt3.Location = new System.Drawing.Point(25, 232);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(0, 13);
            this.txt3.TabIndex = 29;
            // 
            // AttFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 365);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cance);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.setores);
            this.Controls.Add(this.nasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.att);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AttFuncionario";
            this.Text = "Atualizar registro de funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cance;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.ComboBox setores;
        private System.Windows.Forms.MaskedTextBox nasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button att;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt3;
    }
}