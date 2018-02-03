namespace TheFarmOfUs
{
    partial class VerSaldo
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
            this.cancelar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.escolhegado = new System.Windows.Forms.CheckBox();
            this.escolheplanta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Deseja consultar o setor de pecuária ou agricultura?\r\n";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(104, 130);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 31);
            this.cancelar.TabIndex = 22;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(177, 91);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(99, 31);
            this.consultar.TabIndex = 20;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // escolhegado
            // 
            this.escolhegado.AutoSize = true;
            this.escolhegado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhegado.Location = new System.Drawing.Point(86, 59);
            this.escolhegado.Name = "escolhegado";
            this.escolhegado.Size = new System.Drawing.Size(103, 26);
            this.escolhegado.TabIndex = 28;
            this.escolhegado.Text = "Pecuária";
            this.escolhegado.UseVisualStyleBackColor = true;
            // 
            // escolheplanta
            // 
            this.escolheplanta.AutoSize = true;
            this.escolheplanta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolheplanta.Location = new System.Drawing.Point(260, 59);
            this.escolheplanta.Name = "escolheplanta";
            this.escolheplanta.Size = new System.Drawing.Size(118, 26);
            this.escolheplanta.TabIndex = 29;
            this.escolheplanta.Text = "Agricultura";
            this.escolheplanta.UseVisualStyleBackColor = true;
            // 
            // VerSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 188);
            this.Controls.Add(this.escolheplanta);
            this.Controls.Add(this.escolhegado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VerSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerSaldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.CheckBox escolhegado;
        private System.Windows.Forms.CheckBox escolheplanta;
    }
}