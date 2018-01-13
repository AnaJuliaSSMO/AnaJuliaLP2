namespace TheFarmOfUs
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.Qst = new System.Windows.Forms.Label();
            this.funcoesfuncionario = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Qst
            // 
            this.Qst.AutoSize = true;
            this.Qst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst.Location = new System.Drawing.Point(219, 9);
            this.Qst.Name = "Qst";
            this.Qst.Size = new System.Drawing.Size(182, 22);
            this.Qst.TabIndex = 2;
            this.Qst.Text = "O que deseja fazer?\r\n";
            // 
            // funcoesfuncionario
            // 
            this.funcoesfuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.funcoesfuncionario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcoesfuncionario.FormattingEnabled = true;
            this.funcoesfuncionario.Items.AddRange(new object[] {
            "Adicionar um novo funcionário;",
            "Retirar o registro de um funcionário;",
            "Atualizar informações de um funcionário;",
            "Cálculo de multa rescisória de acordo com o salário do funcionário e registro da " +
                "mesma;",
            "Consulta de registros;",
            "Retornar à sessão anterior;"});
            this.funcoesfuncionario.Location = new System.Drawing.Point(107, 34);
            this.funcoesfuncionario.Name = "funcoesfuncionario";
            this.funcoesfuncionario.Size = new System.Drawing.Size(462, 148);
            this.funcoesfuncionario.TabIndex = 3;
            this.funcoesfuncionario.SelectedIndexChanged += new System.EventHandler(this.funcoesfuncionario_SelectedIndexChanged);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 313);
            this.Controls.Add(this.funcoesfuncionario);
            this.Controls.Add(this.Qst);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qst;
        private System.Windows.Forms.CheckedListBox funcoesfuncionario;
    }
}