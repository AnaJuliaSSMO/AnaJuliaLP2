﻿namespace TheFarmOfUs
{
    partial class SetorFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetorFuncionario));
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
            "Admitir um novo funcionário;",
            "Demitir um funcionário;",
            "Atualizar informações de um funcionário;",
            "Consulta de registros;",
            "Consulta de demissões;",
            "Consultar logins;",
            "Retornar à sessão anterior;"});
            this.funcoesfuncionario.Location = new System.Drawing.Point(72, 48);
            this.funcoesfuncionario.Name = "funcoesfuncionario";
            this.funcoesfuncionario.Size = new System.Drawing.Size(462, 172);
            this.funcoesfuncionario.TabIndex = 3;
            this.funcoesfuncionario.SelectedIndexChanged += new System.EventHandler(this.funcoesfuncionario_SelectedIndexChanged);
            // 
            // SetorFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(632, 313);
            this.Controls.Add(this.funcoesfuncionario);
            this.Controls.Add(this.Qst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetorFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qst;
        private System.Windows.Forms.CheckedListBox funcoesfuncionario;
    }
}