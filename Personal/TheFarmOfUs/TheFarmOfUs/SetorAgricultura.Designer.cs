namespace TheFarmOfUs
{
    partial class SetorAgricultura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetorAgricultura));
            this.Qst = new System.Windows.Forms.Label();
            this.agri = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Qst
            // 
            this.Qst.AutoSize = true;
            this.Qst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst.Location = new System.Drawing.Point(229, 19);
            this.Qst.Name = "Qst";
            this.Qst.Size = new System.Drawing.Size(182, 22);
            this.Qst.TabIndex = 2;
            this.Qst.Text = "O que deseja fazer?\r\n";
            // 
            // agri
            // 
            this.agri.BackColor = System.Drawing.SystemColors.Control;
            this.agri.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agri.FormattingEnabled = true;
            this.agri.Items.AddRange(new object[] {
            "Registrar compra ou venda de sacas; ",
            "Registrar compra de agrotóxicos;",
            "Atualizar informações sobre quantidade de sacas produzidas;",
            "Comprar máquinas agrícolas;",
            "Retirar máquinas do estoque;",
            "Consulta do estoque;",
            "Retornar à sessão anterior;"});
            this.agri.Location = new System.Drawing.Point(23, 61);
            this.agri.Name = "agri";
            this.agri.Size = new System.Drawing.Size(593, 172);
            this.agri.TabIndex = 3;
            this.agri.SelectedIndexChanged += new System.EventHandler(this.agri_SelectedIndexChanged);
            // 
            // SetorAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 310);
            this.Controls.Add(this.agri);
            this.Controls.Add(this.Qst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetorAgricultura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agricultura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qst;
        private System.Windows.Forms.CheckedListBox agri;
    }
}