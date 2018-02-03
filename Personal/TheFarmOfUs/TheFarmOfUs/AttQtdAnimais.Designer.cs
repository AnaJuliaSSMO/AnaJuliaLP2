namespace TheFarmOfUs
{
    partial class AttQtdAnimais
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
            this.animais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.acrescentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(91, 116);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 21;
            this.qtd.Text = "Insira a quantidade";
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
            this.animais.Location = new System.Drawing.Point(89, 68);
            this.animais.Name = "animais";
            this.animais.Size = new System.Drawing.Size(310, 30);
            this.animais.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "Qual animal deseja? Qual a quantidade a ser modificada?\r\nDeseja acrescentar ou re" +
    "tirar animais do estoque?\r\n\r\n";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(114, 219);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 24;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(272, 166);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(125, 33);
            this.retirar.TabIndex = 23;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // acrescentar
            // 
            this.acrescentar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acrescentar.Location = new System.Drawing.Point(89, 166);
            this.acrescentar.Name = "acrescentar";
            this.acrescentar.Size = new System.Drawing.Size(125, 33);
            this.acrescentar.TabIndex = 22;
            this.acrescentar.Text = "Acrescentar";
            this.acrescentar.UseVisualStyleBackColor = true;
            this.acrescentar.Click += new System.EventHandler(this.acrescentar_Click);
            // 
            // AttQtdAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 264);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.acrescentar);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.animais);
            this.Controls.Add(this.label1);
            this.Name = "AttQtdAnimais";
            this.Text = "Atualizar quantidade do gado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.ComboBox animais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Button acrescentar;
    }
}