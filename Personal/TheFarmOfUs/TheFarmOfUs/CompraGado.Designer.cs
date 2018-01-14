namespace TheFarmOfUs
{
    partial class CompraGado
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
            this.animais = new System.Windows.Forms.ComboBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compra = new System.Windows.Forms.Button();
            this.cancela = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual animal deseja comprar, qual a quantidade\r\ne qual o seu valor?\r\n";
            // 
            // animais
            // 
            this.animais.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animais.FormattingEnabled = true;
            this.animais.Items.AddRange(new object[] {
            "Vaca",
            "Boi",
            "Galinha",
            "Porco",
            "Cavalo",
            "Cabra ",
            "Carneiro ",
            "Coelho",
            "Pato"});
            this.animais.Location = new System.Drawing.Point(75, 57);
            this.animais.Name = "animais";
            this.animais.Size = new System.Drawing.Size(310, 30);
            this.animais.TabIndex = 2;
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(77, 151);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 3;
            this.valor.Text = "00,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "R$\r\n";
            // 
            // compra
            // 
            this.compra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.Location = new System.Drawing.Point(95, 200);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(105, 34);
            this.compra.TabIndex = 5;
            this.compra.Text = "Comprar";
            this.compra.UseVisualStyleBackColor = true;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // cancela
            // 
            this.cancela.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancela.Location = new System.Drawing.Point(238, 200);
            this.cancela.Name = "cancela";
            this.cancela.Size = new System.Drawing.Size(102, 34);
            this.cancela.TabIndex = 6;
            this.cancela.Text = "Cancelar";
            this.cancela.UseVisualStyleBackColor = true;
            this.cancela.Click += new System.EventHandler(this.cancela_Click);
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(77, 105);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 7;
            this.qtd.Text = "Insira a quantidade";
            // 
            // CompraVendadeGadocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.cancela);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.animais);
            this.Controls.Add(this.label1);
            this.Name = "CompraVendadeGadocs";
            this.Text = "CompraVendadeGadocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox animais;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Button cancela;
        private System.Windows.Forms.TextBox qtd;
    }
}