namespace TheFarmOfUs
{
    partial class AdministraSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministraSalario));
            this.label1 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.TextBox();
            this.setores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quercont = new System.Windows.Forms.CheckBox();
            this.queragri = new System.Windows.Forms.CheckBox();
            this.querpec = new System.Windows.Forms.CheckBox();
            this.check = new System.Windows.Forms.Button();
            this.alt = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caso queira alterar o salário insira o:";
            // 
            // salario
            // 
            this.salario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario.Location = new System.Drawing.Point(144, 89);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(192, 29);
            this.salario.TabIndex = 15;
            this.salario.Text = "00,00";
            // 
            // setores
            // 
            this.setores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setores.FormattingEnabled = true;
            this.setores.Items.AddRange(new object[] {
            "Agricultura",
            "Contabilidade",
            "Pecuaria"});
            this.setores.Location = new System.Drawing.Point(107, 51);
            this.setores.Name = "setores";
            this.setores.Size = new System.Drawing.Size(229, 30);
            this.setores.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salário: R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "Caso queira ver o salário correspondente \r\na um setor marque-o abaixo:\r\n";
            // 
            // quercont
            // 
            this.quercont.AutoSize = true;
            this.quercont.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quercont.Location = new System.Drawing.Point(132, 289);
            this.quercont.Name = "quercont";
            this.quercont.Size = new System.Drawing.Size(145, 26);
            this.quercont.TabIndex = 17;
            this.quercont.Text = "Contabilidade";
            this.quercont.UseVisualStyleBackColor = true;
            // 
            // queragri
            // 
            this.queragri.AutoSize = true;
            this.queragri.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queragri.Location = new System.Drawing.Point(21, 262);
            this.queragri.Name = "queragri";
            this.queragri.Size = new System.Drawing.Size(118, 26);
            this.queragri.TabIndex = 18;
            this.queragri.Text = "Agricultura";
            this.queragri.UseVisualStyleBackColor = true;
            // 
            // querpec
            // 
            this.querpec.AutoSize = true;
            this.querpec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querpec.Location = new System.Drawing.Point(277, 262);
            this.querpec.Name = "querpec";
            this.querpec.Size = new System.Drawing.Size(103, 26);
            this.querpec.TabIndex = 19;
            this.querpec.Text = "Pecuária";
            this.querpec.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(149, 321);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(102, 44);
            this.check.TabIndex = 20;
            this.check.Text = "Checar";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // alt
            // 
            this.alt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt.Location = new System.Drawing.Point(144, 124);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(102, 44);
            this.alt.TabIndex = 21;
            this.alt.Text = "Alterar";
            this.alt.UseVisualStyleBackColor = true;
            this.alt.Click += new System.EventHandler(this.alt_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(149, 386);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(102, 44);
            this.sair.TabIndex = 22;
            this.sair.Text = "Voltar";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // AdministraSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 442);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.check);
            this.Controls.Add(this.querpec);
            this.Controls.Add(this.queragri);
            this.Controls.Add(this.quercont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.setores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AdministraSalario";
            this.Text = "AdministraSalario";
            this.Load += new System.EventHandler(this.AdministraSalario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.ComboBox setores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox quercont;
        private System.Windows.Forms.CheckBox queragri;
        private System.Windows.Forms.CheckBox querpec;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button alt;
        private System.Windows.Forms.Button sair;
    }
}