namespace TheFarmOfUs
{
    partial class Contabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contabilidade));
            this.Qst = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Qst
            // 
            this.Qst.AutoSize = true;
            this.Qst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst.Location = new System.Drawing.Point(166, 44);
            this.Qst.Name = "Qst";
            this.Qst.Size = new System.Drawing.Size(182, 22);
            this.Qst.TabIndex = 2;
            this.Qst.Text = "O que deseja fazer?\r\n";
            // 
            // cont
            // 
            this.cont.BackColor = System.Drawing.SystemColors.Control;
            this.cont.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.FormattingEnabled = true;
            this.cont.Items.AddRange(new object[] {
            "Ver saldo disponível para o setor de Gado e Agricultura;",
            "Administração do salário de funcionários;",
            "Admissão ou demissão de funcionário;",
            "Voltar à sessão anterior;"});
            this.cont.Location = new System.Drawing.Point(11, 90);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(501, 100);
            this.cont.TabIndex = 3;
            this.cont.SelectedIndexChanged += new System.EventHandler(this.cont_SelectedIndexChanged);
            // 
            // Contabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(529, 254);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.Qst);
            this.Name = "Contabilidade";
            this.Text = "Contabilidade";
            this.Load += new System.EventHandler(this.Contabilidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qst;
        private System.Windows.Forms.CheckedListBox cont;
    }
}