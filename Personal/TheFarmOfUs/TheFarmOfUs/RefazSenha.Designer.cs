namespace TheFarmOfUs
{
    partial class RefazSenha
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.novasenha = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.att = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nova senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirme a nova senha:";
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(120, 129);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(152, 29);
            this.senha.TabIndex = 4;
            // 
            // novasenha
            // 
            this.novasenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novasenha.Location = new System.Drawing.Point(225, 169);
            this.novasenha.Name = "novasenha";
            this.novasenha.PasswordChar = '*';
            this.novasenha.Size = new System.Drawing.Size(152, 29);
            this.novasenha.TabIndex = 5;
            // 
            // CPF
            // 
            this.CPF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(61, 50);
            this.CPF.Mask = "000,000,000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(149, 29);
            this.CPF.TabIndex = 6;
            this.CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPF_MaskInputRejected);
            // 
            // att
            // 
            this.att.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att.Location = new System.Drawing.Point(130, 221);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(142, 31);
            this.att.TabIndex = 7;
            this.att.Text = "Atualizar";
            this.att.UseVisualStyleBackColor = true;
            this.att.Click += new System.EventHandler(this.att_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(130, 259);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(142, 31);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // nometxt
            // 
            this.nometxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nometxt.Location = new System.Drawing.Point(151, 85);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(248, 29);
            this.nometxt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nome completo:";
            // 
            // RefazSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 307);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.att);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.novasenha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RefazSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar a senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox novasenha;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Button att;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label5;
    }
}