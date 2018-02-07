namespace TheFarmOfUs
{
    partial class CompraAgrotoxicos
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
            this.destino = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomedesejado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.quercomprar = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // destino
            // 
            this.destino.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino.FormattingEnabled = true;
            this.destino.Items.AddRange(new object[] {
            "Arroz",
            "Melancia",
            "Cacau",
            "Feijão",
            "Batata",
            "Couve",
            "Café"});
            this.destino.Location = new System.Drawing.Point(44, 178);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(310, 30);
            this.destino.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Para qual planta é destinado?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Insira a quantidade (kg ou embalagens)\r\n";
            // 
            // qtd
            // 
            this.qtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(44, 102);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(310, 29);
            this.qtd.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Qual o valor?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Qual o nome?";
            // 
            // nomedesejado
            // 
            this.nomedesejado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomedesejado.Location = new System.Drawing.Point(44, 31);
            this.nomedesejado.Name = "nomedesejado";
            this.nomedesejado.Size = new System.Drawing.Size(310, 29);
            this.nomedesejado.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "R$\r\n";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(44, 256);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(310, 29);
            this.valor.TabIndex = 39;
            this.valor.Text = "00,00";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(110, 343);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(186, 33);
            this.cancelar.TabIndex = 36;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // quercomprar
            // 
            this.quercomprar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quercomprar.Location = new System.Drawing.Point(151, 304);
            this.quercomprar.Name = "quercomprar";
            this.quercomprar.Size = new System.Drawing.Size(99, 33);
            this.quercomprar.TabIndex = 35;
            this.quercomprar.Text = "Comprar";
            this.quercomprar.UseVisualStyleBackColor = true;
            this.quercomprar.Click += new System.EventHandler(this.quercomprar_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.ForeColor = System.Drawing.Color.Red;
            this.txt.Location = new System.Drawing.Point(46, 63);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(0, 13);
            this.txt.TabIndex = 48;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(46, 134);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(0, 13);
            this.txt1.TabIndex = 49;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.ForeColor = System.Drawing.Color.Red;
            this.txt2.Location = new System.Drawing.Point(46, 211);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(0, 13);
            this.txt2.TabIndex = 50;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.ForeColor = System.Drawing.Color.Red;
            this.txt3.Location = new System.Drawing.Point(46, 291);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(0, 13);
            this.txt3.TabIndex = 51;
            // 
            // CompraAgrotoxicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 388);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomedesejado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.quercomprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompraAgrotoxicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar agrotóxicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomedesejado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button quercomprar;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt3;
    }
}