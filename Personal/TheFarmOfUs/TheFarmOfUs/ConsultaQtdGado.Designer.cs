namespace TheFarmOfUs
{
    partial class ConsultaQtdGado
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
            this.lOGINUSERDataSet2 = new TheFarmOfUs.LOGINUSERDataSet2();
            this.gadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gadoTableAdapter = new TheFarmOfUs.LOGINUSERDataSet2TableAdapters.GadoTableAdapter();
            this.especieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abaixo seguem a listagem de animais e suas respectivas quantidades:\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.especieDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn,
            this.alimentacaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lOGINUSERDataSet2
            // 
            this.lOGINUSERDataSet2.DataSetName = "LOGINUSERDataSet2";
            this.lOGINUSERDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gadoBindingSource
            // 
            this.gadoBindingSource.DataMember = "Gado";
            this.gadoBindingSource.DataSource = this.lOGINUSERDataSet2;
            // 
            // gadoTableAdapter
            // 
            this.gadoTableAdapter.ClearBeforeFill = true;
            // 
            // especieDataGridViewTextBoxColumn
            // 
            this.especieDataGridViewTextBoxColumn.DataPropertyName = "Especie";
            this.especieDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            // 
            // alimentacaoDataGridViewTextBoxColumn
            // 
            this.alimentacaoDataGridViewTextBoxColumn.DataPropertyName = "Alimentacao";
            this.alimentacaoDataGridViewTextBoxColumn.HeaderText = "Alimentacao";
            this.alimentacaoDataGridViewTextBoxColumn.Name = "alimentacaoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // retor
            // 
            this.retor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retor.Location = new System.Drawing.Point(231, 224);
            this.retor.Name = "retor";
            this.retor.Size = new System.Drawing.Size(136, 44);
            this.retor.TabIndex = 2;
            this.retor.Text = "Retornar";
            this.retor.UseVisualStyleBackColor = true;
            this.retor.Click += new System.EventHandler(this.retor_Click);
            // 
            // ConsultaQtdGado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 284);
            this.Controls.Add(this.retor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaQtdGado";
            this.Text = "QuantidadeGado";
            this.Load += new System.EventHandler(this.QuantidadeGado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGINUSERDataSet2 lOGINUSERDataSet2;
        private System.Windows.Forms.BindingSource gadoBindingSource;
        private LOGINUSERDataSet2TableAdapters.GadoTableAdapter gadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button retor;
    }
}