﻿namespace TheFarmOfUs
{
    partial class VendeGado
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
            this.cancela = new System.Windows.Forms.Button();
            this.vende = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.animais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(67, 109);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 14;
            this.qtd.Text = "Insira a quantidade";
            // 
            // cancela
            // 
            this.cancela.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancela.Location = new System.Drawing.Point(228, 204);
            this.cancela.Name = "cancela";
            this.cancela.Size = new System.Drawing.Size(102, 34);
            this.cancela.TabIndex = 13;
            this.cancela.Text = "Cancelar";
            this.cancela.UseVisualStyleBackColor = true;
            this.cancela.Click += new System.EventHandler(this.cancela_Click);
            // 
            // vende
            // 
            this.vende.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vende.Location = new System.Drawing.Point(85, 204);
            this.vende.Name = "vende";
            this.vende.Size = new System.Drawing.Size(105, 34);
            this.vende.TabIndex = 12;
            this.vende.Text = "Vender";
            this.vende.UseVisualStyleBackColor = true;
            this.vende.Click += new System.EventHandler(this.vende_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "R$\r\n";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(67, 155);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 10;
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
            this.animais.Location = new System.Drawing.Point(65, 61);
            this.animais.Name = "animais";
            this.animais.Size = new System.Drawing.Size(310, 30);
            this.animais.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qual animal deseja vender, qual a quantidade\r\ne qual o seu valor?\r\n";
            // 
            // VendeGado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 257);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.cancela);
            this.Controls.Add(this.vende);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.animais);
            this.Controls.Add(this.label1);
            this.Name = "VendeGado";
            this.Text = "VendeGado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Button cancela;
        private System.Windows.Forms.Button vende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox animais;
        private System.Windows.Forms.Label label1;
    }
}