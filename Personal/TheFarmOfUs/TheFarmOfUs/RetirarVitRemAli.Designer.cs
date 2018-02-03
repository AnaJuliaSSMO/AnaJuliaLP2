namespace TheFarmOfUs
{
    partial class RetirarVitRemAli
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
            this.procura = new System.Windows.Forms.Button();
            this.nomes = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // procura
            // 
            this.procura.BackColor = System.Drawing.Color.Transparent;
            this.procura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procura.Location = new System.Drawing.Point(35, 77);
            this.procura.Name = "procura";
            this.procura.Size = new System.Drawing.Size(279, 33);
            this.procura.TabIndex = 45;
            this.procura.Text = "Procurar nomes disponíveis";
            this.procura.UseVisualStyleBackColor = false;
            this.procura.Click += new System.EventHandler(this.procura_Click);
            // 
            // nomes
            // 
            this.nomes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomes.FormattingEnabled = true;
            this.nomes.Location = new System.Drawing.Point(15, 116);
            this.nomes.Name = "nomes";
            this.nomes.Size = new System.Drawing.Size(310, 30);
            this.nomes.TabIndex = 42;
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(47, 231);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 41;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click_1);
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(114, 192);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(125, 33);
            this.retirar.TabIndex = 40;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(18, 157);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 38;
            this.qtd.Text = "Insira a quantidade";
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Vitamina",
            "Remedio",
            "Alimento"});
            this.tipo.Location = new System.Drawing.Point(15, 37);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(310, 30);
            this.tipo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Deseja retirar um(a)\r\n";
            // 
            // RetirarVitRemAli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 280);
            this.Controls.Add(this.procura);
            this.Controls.Add(this.nomes);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label1);
            this.Name = "RetirarVitRemAli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar alimentos, vitaminas e/ou remédios do estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button procura;
        private System.Windows.Forms.ComboBox nomes;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label1;
    }
}