namespace TheFarmOfUs
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
            this.preencherformulario = new System.Windows.Forms.LinkLabel();
            this.formal = new System.Windows.Forms.TextBox();
            this.cadastrarlogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preencherformulario
            // 
            this.preencherformulario.AutoSize = true;
            this.preencherformulario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preencherformulario.LinkColor = System.Drawing.Color.Black;
            this.preencherformulario.Location = new System.Drawing.Point(12, 76);
            this.preencherformulario.Name = "preencherformulario";
            this.preencherformulario.Size = new System.Drawing.Size(691, 44);
            this.preencherformulario.TabIndex = 0;
            this.preencherformulario.TabStop = true;
            this.preencherformulario.Text = "Olá, é a sua primeira vez acessando nosso sistema? Clique aqui para preencher \r\ns" +
    "eu formulário.";
            this.preencherformulario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.preencherformulario_LinkClicked);
            // 
            // formal
            // 
            this.formal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formal.Location = new System.Drawing.Point(224, 12);
            this.formal.Name = "formal";
            this.formal.Size = new System.Drawing.Size(321, 29);
            this.formal.TabIndex = 1;
            this.formal.Text = "Por qual nome deseja ser chamado?";
            this.formal.TextChanged += new System.EventHandler(this.formal_TextChanged);
            // 
            // cadastrarlogin
            // 
            this.cadastrarlogin.AutoSize = true;
            this.cadastrarlogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarlogin.LinkColor = System.Drawing.Color.Black;
            this.cadastrarlogin.Location = new System.Drawing.Point(12, 140);
            this.cadastrarlogin.Name = "cadastrarlogin";
            this.cadastrarlogin.Size = new System.Drawing.Size(452, 22);
            this.cadastrarlogin.TabIndex = 3;
            this.cadastrarlogin.TabStop = true;
            this.cadastrarlogin.Text = "Clique aqui para cadastrar nome de usuário e senha:";
            this.cadastrarlogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cadastrarlogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Já é cadastrado? Efetue seu login abaixo:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:\r\n";
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(295, 316);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(183, 28);
            this.senha.TabIndex = 7;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(295, 256);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(183, 27);
            this.usuario.TabIndex = 8;
            // 
            // entrar
            // 
            this.entrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(295, 364);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(82, 42);
            this.entrar.TabIndex = 9;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(399, 364);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(79, 42);
            this.sair.TabIndex = 10;
            this.sair.Text = "Sair\r\n";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 419);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarlogin);
            this.Controls.Add(this.formal);
            this.Controls.Add(this.preencherformulario);
            this.Name = "Form1";
            this.Text = "The Farm Of Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel preencherformulario;
        private System.Windows.Forms.TextBox formal;
        private System.Windows.Forms.LinkLabel cadastrarlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button sair;
    }
}

