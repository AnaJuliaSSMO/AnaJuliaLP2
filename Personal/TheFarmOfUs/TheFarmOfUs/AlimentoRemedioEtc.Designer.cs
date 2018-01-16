namespace TheFarmOfUs
{
    partial class AlimentoRemedioEtc
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
            this.nomes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.desejo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.quercomprar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomes
            // 
            this.nomes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomes.Location = new System.Drawing.Point(57, 113);
            this.nomes.Name = "nomes";
            this.nomes.Size = new System.Drawing.Size(310, 29);
            this.nomes.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "R$\r\n";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(57, 243);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 25;
            this.valor.Text = "00,00";
            // 
            // desejo
            // 
            this.desejo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desejo.FormattingEnabled = true;
            this.desejo.Items.AddRange(new object[] {
            "Vitamina",
            "Alimento",
            "Remedio"});
            this.desejo.Location = new System.Drawing.Point(57, 46);
            this.desejo.Name = "desejo";
            this.desejo.Size = new System.Drawing.Size(310, 30);
            this.desejo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Deseja comprar vitamina,alimento ou remédio?\r\n\r\n";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(116, 324);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(186, 33);
            this.cancelar.TabIndex = 22;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // quercomprar
            // 
            this.quercomprar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quercomprar.Location = new System.Drawing.Point(157, 285);
            this.quercomprar.Name = "quercomprar";
            this.quercomprar.Size = new System.Drawing.Size(99, 33);
            this.quercomprar.TabIndex = 20;
            this.quercomprar.Text = "Comprar";
            this.quercomprar.UseVisualStyleBackColor = true;
            this.quercomprar.Click += new System.EventHandler(this.quercomprar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Qual o nome?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Qual o valor?";
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(57, 183);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Insira a quantidade (kg ou embalagens)\r\n";
            // 
            // AlimentoRemedioEtc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.desejo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.quercomprar);
            this.Name = "AlimentoRemedioEtc";
            this.Text = "AlimentoRemedioEtc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox desejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button quercomprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label5;
    }
}