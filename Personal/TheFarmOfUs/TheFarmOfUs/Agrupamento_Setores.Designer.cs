namespace TheFarmOfUs
{
    partial class Agrupamento_Setores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agrupamento_Setores));
            this.qualset = new System.Windows.Forms.Label();
            this.choosesetor = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // qualset
            // 
            this.qualset.AutoSize = true;
            this.qualset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualset.Location = new System.Drawing.Point(108, 71);
            this.qualset.Name = "qualset";
            this.qualset.Size = new System.Drawing.Size(225, 22);
            this.qualset.TabIndex = 0;
            this.qualset.Text = "Para qual setor deseja ir?";
            // 
            // choosesetor
            // 
            this.choosesetor.BackColor = System.Drawing.SystemColors.Control;
            this.choosesetor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosesetor.FormattingEnabled = true;
            this.choosesetor.Items.AddRange(new object[] {
            "Administração de gado;",
            "Administração da agricultura;",
            "Administração de funcionários;",
            "Contabilidade;",
            "Retornar ao menu inicial;"});
            this.choosesetor.Location = new System.Drawing.Point(69, 96);
            this.choosesetor.Name = "choosesetor";
            this.choosesetor.Size = new System.Drawing.Size(309, 124);
            this.choosesetor.TabIndex = 2;
            this.choosesetor.SelectedIndexChanged += new System.EventHandler(this.choosesetor_SelectedIndexChanged);
            // 
            // Agrupamento_Setores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(453, 333);
            this.Controls.Add(this.choosesetor);
            this.Controls.Add(this.qualset);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Agrupamento_Setores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrupamento_Setores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qualset;
        private System.Windows.Forms.CheckedListBox choosesetor;
    }
}