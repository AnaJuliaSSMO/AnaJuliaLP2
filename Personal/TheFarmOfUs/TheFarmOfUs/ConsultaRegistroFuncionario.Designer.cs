namespace TheFarmOfUs
{
    partial class ConsultaRegistroFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.retor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINUSERDataSet3 = new TheFarmOfUs.LOGINUSERDataSet3();
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINUSERDataSet4 = new TheFarmOfUs.LOGINUSERDataSet4();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new TheFarmOfUs.LOGINUSERDataSet4TableAdapters.FuncionarioTableAdapter();
            this.funcionarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter1 = new TheFarmOfUs.LOGINUSERDataSet3TableAdapters.FuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abaixo estão listados os funcionários da empresa:";
            // 
            // retor
            // 
            this.retor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retor.Location = new System.Drawing.Point(286, 199);
            this.retor.Name = "retor";
            this.retor.Size = new System.Drawing.Size(136, 44);
            this.retor.TabIndex = 3;
            this.retor.Text = "Retornar";
            this.retor.UseVisualStyleBackColor = true;
            this.retor.Click += new System.EventHandler(this.retor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Data_Admissao,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.funcionarioBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(25, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Data_Admissao
            // 
            this.Data_Admissao.DataPropertyName = "Data_Admissao";
            this.Data_Admissao.HeaderText = "Data_Admissao";
            this.Data_Admissao.Name = "Data_Admissao";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_nascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_nascimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Setor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Setor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // funcionarioBindingSource3
            // 
            this.funcionarioBindingSource3.DataMember = "Funcionario";
            this.funcionarioBindingSource3.DataSource = this.lOGINUSERDataSet3;
            // 
            // lOGINUSERDataSet3
            // 
            this.lOGINUSERDataSet3.DataSetName = "LOGINUSERDataSet3";
            this.lOGINUSERDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "Funcionario";
            this.funcionarioBindingSource1.DataSource = this.lOGINUSERDataSet4;
            // 
            // lOGINUSERDataSet4
            // 
            this.lOGINUSERDataSet4.DataSetName = "LOGINUSERDataSet4";
            this.lOGINUSERDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.lOGINUSERDataSet4;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioBindingSource2
            // 
            this.funcionarioBindingSource2.DataMember = "Funcionario";
            this.funcionarioBindingSource2.DataSource = this.lOGINUSERDataSet4;
            // 
            // funcionarioTableAdapter1
            // 
            this.funcionarioTableAdapter1.ClearBeforeFill = true;
            // 
            // ConsultaRegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 255);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retor);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaRegistroFuncionario";
            this.Text = "Consultar registros de funcionarios";
            this.Load += new System.EventHandler(this.ConsultaRegistroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGINUSERDataSet4 lOGINUSERDataSet4;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private LOGINUSERDataSet4TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource2;
        private LOGINUSERDataSet3 lOGINUSERDataSet3;
        private System.Windows.Forms.BindingSource funcionarioBindingSource3;
        private LOGINUSERDataSet3TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Admissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}