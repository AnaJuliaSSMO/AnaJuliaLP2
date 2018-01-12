namespace TheFarmOfUs
{
    partial class Gado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gado));
            this.opitions = new System.Windows.Forms.CheckedListBox();
            this.Qst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opitions
            // 
            this.opitions.BackColor = System.Drawing.SystemColors.Control;
            this.opitions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opitions.FormattingEnabled = true;
            this.opitions.Items.AddRange(new object[] {
            "Registrar compra ou venda de novo gado;",
            "Registrar compra de alimentos, vitaminas e/ou remédios;",
            "Atualizar, acrescentar ou retirar gados do estoque;",
            "Consulta do estoque;"});
            this.opitions.Location = new System.Drawing.Point(27, 50);
            this.opitions.Name = "opitions";
            this.opitions.Size = new System.Drawing.Size(540, 100);
            this.opitions.TabIndex = 0;
            this.opitions.SelectedIndexChanged += new System.EventHandler(this.opitions_SelectedIndexChanged);
            // 
            // Qst
            // 
            this.Qst.AutoSize = true;
            this.Qst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst.Location = new System.Drawing.Point(219, 9);
            this.Qst.Name = "Qst";
            this.Qst.Size = new System.Drawing.Size(182, 22);
            this.Qst.TabIndex = 1;
            this.Qst.Text = "O que deseja fazer?\r\n";
            // 
            // Gado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 289);
            this.Controls.Add(this.Qst);
            this.Controls.Add(this.opitions);
            this.Name = "Gado";
            this.Text = "Gado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox opitions;
        private System.Windows.Forms.Label Qst;
    }
}