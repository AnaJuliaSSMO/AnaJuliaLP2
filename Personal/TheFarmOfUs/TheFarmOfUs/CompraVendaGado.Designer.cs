namespace TheFarmOfUs
{
    partial class CompraVendaGado
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
            this.quercomprar = new System.Windows.Forms.Button();
            this.quervender = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.animais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quercomprar
            // 
            this.quercomprar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quercomprar.Location = new System.Drawing.Point(110, 204);
            this.quercomprar.Name = "quercomprar";
            this.quercomprar.Size = new System.Drawing.Size(99, 33);
            this.quercomprar.TabIndex = 1;
            this.quercomprar.Text = "Comprar";
            this.quercomprar.UseVisualStyleBackColor = true;
            this.quercomprar.Click += new System.EventHandler(this.quercomprar_Click);
            // 
            // quervender
            // 
            this.quervender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quervender.Location = new System.Drawing.Point(258, 204);
            this.quervender.Name = "quervender";
            this.quervender.Size = new System.Drawing.Size(99, 33);
            this.quervender.TabIndex = 2;
            this.quervender.Text = "Vender";
            this.quervender.UseVisualStyleBackColor = true;
            this.quervender.Click += new System.EventHandler(this.quervender_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(110, 255);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(82, 110);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 19;
            this.qtd.Text = "Insira a quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "R$\r\n";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(82, 156);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 17;
            this.valor.Text = "00,00";
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
            this.animais.Location = new System.Drawing.Point(80, 62);
            this.animais.Name = "animais";
            this.animais.Size = new System.Drawing.Size(310, 30);
            this.animais.TabIndex = 16;
            this.animais.SelectedIndexChanged += new System.EventHandler(this.animais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Qual animal deseja comprar/vender, qual a quantidade\r\ne qual o seu valor?\r\n";
            // 
            // CompraVendaGado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 315);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.animais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.quervender);
            this.Controls.Add(this.quercomprar);
            this.Name = "CompraVendaGado";
            this.Text = "Comprar / Vender animais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button quercomprar;
        private System.Windows.Forms.Button quervender;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox animais;
        private System.Windows.Forms.Label label1;
    }
}