namespace TheFarmOfUs
{
    partial class ConsultaDemissoesFunc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDemissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDemissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINUSERDataSet5 = new TheFarmOfUs.LOGINUSERDataSet5();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.demissaoTableAdapter = new TheFarmOfUs.LOGINUSERDataSet5TableAdapters.DemissaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.motivoDemissaoDataGridViewTextBoxColumn,
            this.dataDemissaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demissaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // motivoDemissaoDataGridViewTextBoxColumn
            // 
            this.motivoDemissaoDataGridViewTextBoxColumn.DataPropertyName = "MotivoDemissao";
            this.motivoDemissaoDataGridViewTextBoxColumn.HeaderText = "MotivoDemissao";
            this.motivoDemissaoDataGridViewTextBoxColumn.Name = "motivoDemissaoDataGridViewTextBoxColumn";
            // 
            // dataDemissaoDataGridViewTextBoxColumn
            // 
            this.dataDemissaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Demissao";
            this.dataDemissaoDataGridViewTextBoxColumn.HeaderText = "Data_Demissao";
            this.dataDemissaoDataGridViewTextBoxColumn.Name = "dataDemissaoDataGridViewTextBoxColumn";
            // 
            // demissaoBindingSource
            // 
            this.demissaoBindingSource.DataMember = "Demissao";
            this.demissaoBindingSource.DataSource = this.lOGINUSERDataSet5;
            // 
            // lOGINUSERDataSet5
            // 
            this.lOGINUSERDataSet5.DataSetName = "LOGINUSERDataSet5";
            this.lOGINUSERDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(209, 234);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(177, 30);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "Retornar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seguem abaixo todos os registros de demissões da empresa.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // demissaoTableAdapter
            // 
            this.demissaoTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaDemissoesFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaDemissoesFunc";
            this.Text = "Consultar demissões da fazenda";
            this.Load += new System.EventHandler(this.ConsultaDemissoesFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label1;
        private LOGINUSERDataSet5 lOGINUSERDataSet5;
        private System.Windows.Forms.BindingSource demissaoBindingSource;
        private LOGINUSERDataSet5TableAdapters.DemissaoTableAdapter demissaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDemissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDemissaoDataGridViewTextBoxColumn;
    }
}