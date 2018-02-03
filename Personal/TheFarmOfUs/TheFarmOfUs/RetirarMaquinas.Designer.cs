namespace TheFarmOfUs
{
    partial class RetirarMaquinas
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
            this.procura = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.retirar = new System.Windows.Forms.Button();
            this.motivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outromotivo = new System.Windows.Forms.TextBox();
            this.buscaplacas = new System.Windows.Forms.Button();
            this.nomes = new System.Windows.Forms.ComboBox();
            this.placas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // procura
            // 
            this.procura.BackColor = System.Drawing.Color.Transparent;
            this.procura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procura.Location = new System.Drawing.Point(25, 12);
            this.procura.Name = "procura";
            this.procura.Size = new System.Drawing.Size(279, 33);
            this.procura.TabIndex = 52;
            this.procura.Text = "Procurar máquinas disponíveis";
            this.procura.UseVisualStyleBackColor = false;
            this.procura.Click += new System.EventHandler(this.procura_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(34, 319);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(247, 33);
            this.cancelar.TabIndex = 50;
            this.cancelar.Text = "Cancelar operação";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(101, 280);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(125, 33);
            this.retirar.TabIndex = 49;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // motivo
            // 
            this.motivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo.FormattingEnabled = true;
            this.motivo.Items.AddRange(new object[] {
            "Validade expirada;",
            "Defeito de fábrica;",
            "Quebra durante manuseamento;",
            "Batida;",
            "Capotamento;",
            "Outro? Especificar:"});
            this.motivo.Location = new System.Drawing.Point(10, 204);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(310, 30);
            this.motivo.TabIndex = 53;
            this.motivo.SelectedIndexChanged += new System.EventHandler(this.motivo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Motivo da retirada";
            // 
            // outromotivo
            // 
            this.outromotivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outromotivo.Location = new System.Drawing.Point(8, 247);
            this.outromotivo.Name = "outromotivo";
            this.outromotivo.Size = new System.Drawing.Size(311, 29);
            this.outromotivo.TabIndex = 55;
            // 
            // buscaplacas
            // 
            this.buscaplacas.BackColor = System.Drawing.Color.Transparent;
            this.buscaplacas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaplacas.Location = new System.Drawing.Point(25, 100);
            this.buscaplacas.Name = "buscaplacas";
            this.buscaplacas.Size = new System.Drawing.Size(279, 33);
            this.buscaplacas.TabIndex = 56;
            this.buscaplacas.Text = "Procurar placas disponíveis";
            this.buscaplacas.UseVisualStyleBackColor = false;
            this.buscaplacas.Click += new System.EventHandler(this.buscaplacas_Click);
            // 
            // nomes
            // 
            this.nomes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomes.FormattingEnabled = true;
            this.nomes.Location = new System.Drawing.Point(14, 51);
            this.nomes.Name = "nomes";
            this.nomes.Size = new System.Drawing.Size(310, 30);
            this.nomes.TabIndex = 51;
            // 
            // placas
            // 
            this.placas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placas.FormattingEnabled = true;
            this.placas.Location = new System.Drawing.Point(12, 139);
            this.placas.Name = "placas";
            this.placas.Size = new System.Drawing.Size(310, 30);
            this.placas.TabIndex = 57;
            // 
            // RetirarMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 361);
            this.Controls.Add(this.placas);
            this.Controls.Add(this.buscaplacas);
            this.Controls.Add(this.outromotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.procura);
            this.Controls.Add(this.nomes);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.retirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RetirarMaquinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar máquinas agrícolas do estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button procura;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.ComboBox motivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outromotivo;
        private System.Windows.Forms.Button buscaplacas;
        private System.Windows.Forms.ComboBox nomes;
        private System.Windows.Forms.ComboBox placas;
    }
}