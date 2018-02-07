namespace TheFarmOfUs
{
    partial class AttSaca
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
            this.cancelar = new System.Windows.Forms.Button();
            this.att = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(41, 195);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 50;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // att
            // 
            this.att.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att.Location = new System.Drawing.Point(108, 156);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(125, 33);
            this.att.TabIndex = 49;
            this.att.Text = "Atualizar";
            this.att.UseVisualStyleBackColor = true;
            this.att.Click += new System.EventHandler(this.att_Click);
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(12, 96);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 48;
            this.qtd.Text = "Insira a quantidade";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.FormattingEnabled = true;
            this.nom.Items.AddRange(new object[] {
            "Arroz",
            "Melancia",
            "Cacau",
            "Feijão",
            "Batata",
            "Couve",
            "Café"});
            this.nom.Location = new System.Drawing.Point(12, 36);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(310, 30);
            this.nom.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "O que deseja atualizar?\r\n";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.ForeColor = System.Drawing.Color.Red;
            this.txt.Location = new System.Drawing.Point(12, 69);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(0, 13);
            this.txt.TabIndex = 51;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(12, 128);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(0, 13);
            this.txt1.TabIndex = 52;
            // 
            // AttSaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 265);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.att);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AttSaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar quantidade de sacas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button att;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.ComboBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txt1;
    }
}