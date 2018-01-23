namespace TheFarmOfUs
{
    partial class BuySellplantinhas
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
            this.qtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.vendiveis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.quervender = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quercomprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(63, 109);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 27;
            this.qtd.Text = "Insira a quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "R$\r\n";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(63, 155);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 25;
            this.valor.Text = "00,00";
            // 
            // vendiveis
            // 
            this.vendiveis.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendiveis.FormattingEnabled = true;
            this.vendiveis.Items.AddRange(new object[] {
            "Arroz",
            "Melancia",
            "Cacau",
            "Feijão",
            "Batata",
            "Couve",
            "Café"});
            this.vendiveis.Location = new System.Drawing.Point(63, 65);
            this.vendiveis.Name = "vendiveis";
            this.vendiveis.Size = new System.Drawing.Size(310, 30);
            this.vendiveis.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "O que deseja vender, qual a quantidade\r\ne qual o seu valor?\r\n";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(91, 246);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 22;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // quervender
            // 
            this.quervender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quervender.Location = new System.Drawing.Point(239, 207);
            this.quervender.Name = "quervender";
            this.quervender.Size = new System.Drawing.Size(99, 33);
            this.quervender.TabIndex = 21;
            this.quervender.Text = "Vender";
            this.quervender.UseVisualStyleBackColor = true;
            this.quervender.Click += new System.EventHandler(this.quervender_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 28;
            // 
            // quercomprar
            // 
            this.quercomprar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quercomprar.Location = new System.Drawing.Point(91, 207);
            this.quercomprar.Name = "quercomprar";
            this.quercomprar.Size = new System.Drawing.Size(99, 33);
            this.quercomprar.TabIndex = 29;
            this.quercomprar.Text = "Comprar";
            this.quercomprar.UseVisualStyleBackColor = true;
            this.quercomprar.Click += new System.EventHandler(this.quercomprar_Click);
            // 
            // BuySellplantinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 291);
            this.Controls.Add(this.quercomprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.vendiveis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.quervender);
            this.Name = "BuySellplantinhas";
            this.Text = "BuyorSellPlantaedition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox vendiveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button quervender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button quercomprar;
    }
}