namespace TheFarmOfUs
{
    partial class Desejair
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
            this.irplanta = new System.Windows.Forms.Button();
            this.irmaquina = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja fazer?";
            // 
            // irplanta
            // 
            this.irplanta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irplanta.Location = new System.Drawing.Point(12, 72);
            this.irplanta.Name = "irplanta";
            this.irplanta.Size = new System.Drawing.Size(293, 52);
            this.irplanta.TabIndex = 1;
            this.irplanta.Text = "Consultar estoque setor Agricultura";
            this.irplanta.UseVisualStyleBackColor = true;
            this.irplanta.Click += new System.EventHandler(this.irplanta_Click);
            // 
            // irmaquina
            // 
            this.irmaquina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irmaquina.Location = new System.Drawing.Point(12, 136);
            this.irmaquina.Name = "irmaquina";
            this.irmaquina.Size = new System.Drawing.Size(293, 52);
            this.irmaquina.TabIndex = 2;
            this.irmaquina.Text = "Consultar estoque de máquinas";
            this.irmaquina.UseVisualStyleBackColor = true;
            this.irmaquina.Click += new System.EventHandler(this.irmaquina_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(104, 203);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(105, 52);
            this.voltar.TabIndex = 3;
            this.voltar.Text = "Retornar\r\n";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Desejair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 267);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.irmaquina);
            this.Controls.Add(this.irplanta);
            this.Controls.Add(this.label1);
            this.Name = "Desejair";
            this.Text = "Desejair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button irplanta;
        private System.Windows.Forms.Button irmaquina;
        private System.Windows.Forms.Button voltar;
    }
}