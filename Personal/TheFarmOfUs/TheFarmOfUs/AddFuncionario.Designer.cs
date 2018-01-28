namespace TheFarmOfUs
{
    partial class AddFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nasc = new System.Windows.Forms.MaskedTextBox();
            this.setores = new System.Windows.Forms.ComboBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.cance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor:";
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(74, 96);
            this.cpf.Mask = "000,000,000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(148, 29);
            this.cpf.TabIndex = 4;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(131, 361);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(325, 39);
            this.add.TabIndex = 5;
            this.add.Text = "Adicionar funcionário";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data de nascimento:";
            // 
            // nasc
            // 
            this.nasc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nasc.Location = new System.Drawing.Point(194, 143);
            this.nasc.Mask = "00/00/0000";
            this.nasc.Name = "nasc";
            this.nasc.Size = new System.Drawing.Size(111, 29);
            this.nasc.TabIndex = 8;
            this.nasc.ValidatingType = typeof(System.DateTime);
            // 
            // setores
            // 
            this.setores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setores.FormattingEnabled = true;
            this.setores.Items.AddRange(new object[] {
            "Agricultura",
            "Contabilidade",
            "Pecuaria"});
            this.setores.Location = new System.Drawing.Point(76, 192);
            this.setores.Name = "setores";
            this.setores.Size = new System.Drawing.Size(229, 30);
            this.setores.TabIndex = 9;
            // 
            // nometxt
            // 
            this.nometxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.Location = new System.Drawing.Point(157, 44);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(387, 29);
            this.nometxt.TabIndex = 10;
            // 
            // cance
            // 
            this.cance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cance.Location = new System.Drawing.Point(131, 411);
            this.cance.Name = "cance";
            this.cance.Size = new System.Drawing.Size(325, 39);
            this.cance.TabIndex = 12;
            this.cance.Text = "Cancelar operação";
            this.cance.UseVisualStyleBackColor = true;
            this.cance.Click += new System.EventHandler(this.cance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "O salário é prédefinido de acordo com seu setor.";
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(133, 236);
            this.data.Mask = "00/00/0000";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(111, 29);
            this.data.TabIndex = 14;
            this.data.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data de hoje:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cance);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.setores);
            this.Controls.Add(this.nasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFuncionario";
            this.Text = "AddFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox nasc;
        private System.Windows.Forms.ComboBox setores;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Button cance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}