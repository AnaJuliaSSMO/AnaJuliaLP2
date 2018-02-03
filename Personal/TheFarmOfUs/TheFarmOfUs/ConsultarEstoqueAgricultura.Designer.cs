namespace TheFarmOfUs
{
    partial class ConsultarEstoqueAgricultura
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINUSERDataSet1 = new TheFarmOfUs.LOGINUSERDataSet1();
            this.plantasTableAdapter = new TheFarmOfUs.LOGINUSERDataSet1TableAdapters.PlantasTableAdapter();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Todas os provenientes da agricultura estão listados abaixo: \r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.plantasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(145, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 178);
            this.dataGridView1.TabIndex = 2;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // plantasBindingSource
            // 
            this.plantasBindingSource.DataMember = "Plantas";
            this.plantasBindingSource.DataSource = this.lOGINUSERDataSet1;
            // 
            // lOGINUSERDataSet1
            // 
            this.lOGINUSERDataSet1.DataSetName = "LOGINUSERDataSet1";
            this.lOGINUSERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantasTableAdapter
            // 
            this.plantasTableAdapter.ClearBeforeFill = true;
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(209, 232);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(92, 39);
            this.voltar.TabIndex = 4;
            this.voltar.Text = "Retornar\r\n";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // ConsultarEstoqueAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 279);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarEstoqueAgricultura";
            this.Text = "Consultar estoque de sacas";
            this.Load += new System.EventHandler(this.ConsultarAgricultura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGINUSERDataSet1 lOGINUSERDataSet1;
        private System.Windows.Forms.BindingSource plantasBindingSource;
        private LOGINUSERDataSet1TableAdapters.PlantasTableAdapter plantasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button voltar;
    }
}