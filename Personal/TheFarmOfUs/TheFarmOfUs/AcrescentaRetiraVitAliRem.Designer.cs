namespace TheFarmOfUs
{
    partial class AcrescentaRetiraVitAliRem
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
            this.retirar = new System.Windows.Forms.Button();
            this.acrescentar = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(44, 276);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 30;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(202, 223);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(125, 33);
            this.retirar.TabIndex = 29;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            // 
            // acrescentar
            // 
            this.acrescentar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acrescentar.Location = new System.Drawing.Point(19, 223);
            this.acrescentar.Name = "acrescentar";
            this.acrescentar.Size = new System.Drawing.Size(125, 33);
            this.acrescentar.TabIndex = 28;
            this.acrescentar.Text = "Acrescentar";
            this.acrescentar.UseVisualStyleBackColor = true;
            this.acrescentar.Click += new System.EventHandler(this.acrescentar_Click);
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(21, 173);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 27;
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
            this.tipo.Location = new System.Drawing.Point(21, 43);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(310, 30);
            this.tipo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "O que deseja modificar é um(a)?\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Selecione o desejado:";
            // 
            // nomes
            // 
            this.nomes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomes.FormattingEnabled = true;
            this.nomes.Location = new System.Drawing.Point(21, 115);
            this.nomes.Name = "nomes";
            this.nomes.Size = new System.Drawing.Size(310, 30);
            this.nomes.TabIndex = 32;
            // 
            // AcrescentaRetiraVitAliRem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.nomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.acrescentar);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label1);
            this.Name = "AcrescentaRetiraVitAliRem";
            this.Text = "AcrescentaRetiraVitAliRem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Button acrescentar;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nomes;
    }
}