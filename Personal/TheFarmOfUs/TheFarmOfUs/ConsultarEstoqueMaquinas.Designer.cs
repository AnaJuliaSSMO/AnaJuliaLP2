namespace TheFarmOfUs
{
    partial class ConsultarEstoqueMaquinas
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
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadeTanqueLitrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquinasABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINUSERDataSet = new TheFarmOfUs.LOGINUSERDataSet();
            this.maquinasATableAdapter = new TheFarmOfUs.LOGINUSERDataSetTableAdapters.MaquinasATableAdapter();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todas as máquinas estão listadas abaixo: \r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.potenciaDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.capacidadeTanqueLitrosDataGridViewTextBoxColumn,
            this.disponivelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maquinasABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 198);
            this.dataGridView1.TabIndex = 53;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // potenciaDataGridViewTextBoxColumn
            // 
            this.potenciaDataGridViewTextBoxColumn.DataPropertyName = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.HeaderText = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.Name = "potenciaDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // capacidadeTanqueLitrosDataGridViewTextBoxColumn
            // 
            this.capacidadeTanqueLitrosDataGridViewTextBoxColumn.DataPropertyName = "CapacidadeTanqueLitros";
            this.capacidadeTanqueLitrosDataGridViewTextBoxColumn.HeaderText = "CapacidadeTanqueLitros";
            this.capacidadeTanqueLitrosDataGridViewTextBoxColumn.Name = "capacidadeTanqueLitrosDataGridViewTextBoxColumn";
            // 
            // disponivelDataGridViewTextBoxColumn
            // 
            this.disponivelDataGridViewTextBoxColumn.DataPropertyName = "Disponivel";
            this.disponivelDataGridViewTextBoxColumn.HeaderText = "Disponivel";
            this.disponivelDataGridViewTextBoxColumn.Name = "disponivelDataGridViewTextBoxColumn";
            // 
            // maquinasABindingSource
            // 
            this.maquinasABindingSource.DataMember = "MaquinasA";
            this.maquinasABindingSource.DataSource = this.lOGINUSERDataSet;
            // 
            // lOGINUSERDataSet
            // 
            this.lOGINUSERDataSet.DataSetName = "LOGINUSERDataSet";
            this.lOGINUSERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maquinasATableAdapter
            // 
            this.maquinasATableAdapter.ClearBeforeFill = true;
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(372, 287);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(119, 49);
            this.voltar.TabIndex = 54;
            this.voltar.Text = "Retornar\r\n";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // ConsultarEstoqueMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 348);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarEstoqueMaquinas";
            this.Text = "Consultar estoque de Máquinas agrícolas";
            this.Load += new System.EventHandler(this.ConsultaEstoqueMaquinaPlanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINUSERDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGINUSERDataSet lOGINUSERDataSet;
        private System.Windows.Forms.BindingSource maquinasABindingSource;
        private LOGINUSERDataSetTableAdapters.MaquinasATableAdapter maquinasATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadeTanqueLitrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button voltar;
    }
}