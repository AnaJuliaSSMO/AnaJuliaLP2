namespace Trying
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Integrantes = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Setores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agriculturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoDeCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Setores.SuspendLayout();
            this.SuspendLayout();
            // 
            // Integrantes
            // 
            this.Integrantes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Integrantes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Integrantes.FormattingEnabled = true;
            this.Integrantes.Items.AddRange(new object[] {
            "Ana Júlia - AJ (IN209)",
            "João Pedro A. - JotaPa (IN209)",
            "Luan Moraes B. - Luan (IN209)"});
            this.Integrantes.Location = new System.Drawing.Point(12, 12);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(421, 30);
            this.Integrantes.TabIndex = 0;
            this.Integrantes.Text = "Integrantes do Grupo";
            this.Integrantes.SelectedIndexChanged += new System.EventHandler(this.Integrantes_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Supimpa",
            "Autêntico",
            "Moral",
            "10/10",
            "Turazzi eh top",
            "Jeri4",
            "Chico da 10 pa gente ",
            "PLMDDS"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 92);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 109);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sobre o trab:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLICK ME :)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 278);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(338, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 128);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLICA NO SALGADOH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Setores
            // 
            this.Setores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gadoToolStripMenuItem,
            this.agriculturaToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.Setores.Name = "Setores";
            this.Setores.Size = new System.Drawing.Size(143, 70);
            this.Setores.Text = "Para qual setor?";
            this.Setores.Opening += new System.ComponentModel.CancelEventHandler(this.Setores_Opening);
            // 
            // gadoToolStripMenuItem
            // 
            this.gadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.atualizarEstoqueToolStripMenuItem});
            this.gadoToolStripMenuItem.Name = "gadoToolStripMenuItem";
            this.gadoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gadoToolStripMenuItem.Text = "Gado";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // atualizarEstoqueToolStripMenuItem
            // 
            this.atualizarEstoqueToolStripMenuItem.Name = "atualizarEstoqueToolStripMenuItem";
            this.atualizarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.atualizarEstoqueToolStripMenuItem.Text = "Atualizar estoque ";
            this.atualizarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.atualizarEstoqueToolStripMenuItem_Click);
            // 
            // agriculturaToolStripMenuItem
            // 
            this.agriculturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem1,
            this.vendaToolStripMenuItem1,
            this.atualizaçãoDeEstoqueToolStripMenuItem});
            this.agriculturaToolStripMenuItem.Name = "agriculturaToolStripMenuItem";
            this.agriculturaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.agriculturaToolStripMenuItem.Text = "Agricultura";
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.compraToolStripMenuItem1.Text = "Compra";
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.vendaToolStripMenuItem1.Text = "Venda";
            // 
            // atualizaçãoDeEstoqueToolStripMenuItem
            // 
            this.atualizaçãoDeEstoqueToolStripMenuItem.Name = "atualizaçãoDeEstoqueToolStripMenuItem";
            this.atualizaçãoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.atualizaçãoDeEstoqueToolStripMenuItem.Text = "Atualização de estoque";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiçãoToolStripMenuItem,
            this.demissãoToolStripMenuItem,
            this.atualizaçãoDeCadastroToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // adiçãoToolStripMenuItem
            // 
            this.adiçãoToolStripMenuItem.Name = "adiçãoToolStripMenuItem";
            this.adiçãoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.adiçãoToolStripMenuItem.Text = "Adição";
            // 
            // demissãoToolStripMenuItem
            // 
            this.demissãoToolStripMenuItem.Name = "demissãoToolStripMenuItem";
            this.demissãoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.demissãoToolStripMenuItem.Text = "Demissão";
            // 
            // atualizaçãoDeCadastroToolStripMenuItem
            // 
            this.atualizaçãoDeCadastroToolStripMenuItem.Name = "atualizaçãoDeCadastroToolStripMenuItem";
            this.atualizaçãoDeCadastroToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.atualizaçãoDeCadastroToolStripMenuItem.Text = "Atualização de cadastro";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ContextMenuStrip = this.Setores;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(414, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Para qual setor deseja ir?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(580, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Integrantes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Setores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Integrantes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip Setores;
        private System.Windows.Forms.ToolStripMenuItem gadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agriculturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoDeCadastroToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

