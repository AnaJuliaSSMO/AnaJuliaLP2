namespace TheFarmOfUs
{
    partial class AcessoContabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcessoContabilidade));
            this.sair = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.nrf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(268, 153);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 29);
            this.sair.TabIndex = 15;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click_1);
            // 
            // enviar
            // 
            this.enviar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.Location = new System.Drawing.Point(141, 153);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 29);
            this.enviar.TabIndex = 14;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // nrf
            // 
            this.nrf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrf.Location = new System.Drawing.Point(6, 97);
            this.nrf.Name = "nrf";
            this.nrf.PasswordChar = '*';
            this.nrf.Size = new System.Drawing.Size(480, 29);
            this.nrf.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 66);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nesta sessão é permitida apenas a entrada de funcionários \r\nda empresa autorizado" +
    "s, por favor, identifique-se com o\r\nseu NCF: \r\n";
            // 
            // AcessoContabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 198);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.nrf);
            this.Controls.Add(this.label1);
            this.Name = "AcessoContabilidade";
            this.Text = "AcessoContabilidadeEFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox nrf;
        private System.Windows.Forms.Label label1;
    }
}