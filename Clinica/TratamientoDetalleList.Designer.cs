namespace Clinica
{
    partial class TratamientoDetalleList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tratamientoDetalleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTratamientoDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoParcialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoDetalleViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListado.AutoGenerateColumns = false;
            this.dataListado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTratamientoDetalleDataGridViewTextBoxColumn,
            this.idTratamientoDataGridViewTextBoxColumn,
            this.sintomasDataGridViewTextBoxColumn,
            this.idMedicamentoDataGridViewTextBoxColumn,
            this.medicamentoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.diagnosticoParcialDataGridViewTextBoxColumn});
            this.dataListado.DataSource = this.tratamientoDetalleViewBindingSource;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dataListado.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataListado.Location = new System.Drawing.Point(12, 12);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListado.Size = new System.Drawing.Size(675, 291);
            this.dataListado.TabIndex = 71;
            // 
            // tratamientoDetalleViewBindingSource
            // 
            this.tratamientoDetalleViewBindingSource.DataSource = typeof(Logica.TratamientoDetalleView);
            // 
            // idTratamientoDetalleDataGridViewTextBoxColumn
            // 
            this.idTratamientoDetalleDataGridViewTextBoxColumn.DataPropertyName = "idTratamientoDetalle";
            this.idTratamientoDetalleDataGridViewTextBoxColumn.HeaderText = "idTratamientoDetalle";
            this.idTratamientoDetalleDataGridViewTextBoxColumn.Name = "idTratamientoDetalleDataGridViewTextBoxColumn";
            this.idTratamientoDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTratamientoDetalleDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTratamientoDataGridViewTextBoxColumn
            // 
            this.idTratamientoDataGridViewTextBoxColumn.DataPropertyName = "idTratamiento";
            this.idTratamientoDataGridViewTextBoxColumn.HeaderText = "idTratamiento";
            this.idTratamientoDataGridViewTextBoxColumn.Name = "idTratamientoDataGridViewTextBoxColumn";
            this.idTratamientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTratamientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sintomasDataGridViewTextBoxColumn
            // 
            this.sintomasDataGridViewTextBoxColumn.DataPropertyName = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.HeaderText = "sintomas";
            this.sintomasDataGridViewTextBoxColumn.Name = "sintomasDataGridViewTextBoxColumn";
            this.sintomasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMedicamentoDataGridViewTextBoxColumn
            // 
            this.idMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "idMedicamento";
            this.idMedicamentoDataGridViewTextBoxColumn.HeaderText = "idMedicamento";
            this.idMedicamentoDataGridViewTextBoxColumn.Name = "idMedicamentoDataGridViewTextBoxColumn";
            this.idMedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMedicamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicamentoDataGridViewTextBoxColumn
            // 
            this.medicamentoDataGridViewTextBoxColumn.DataPropertyName = "medicamento";
            this.medicamentoDataGridViewTextBoxColumn.HeaderText = "medicamento";
            this.medicamentoDataGridViewTextBoxColumn.Name = "medicamentoDataGridViewTextBoxColumn";
            this.medicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticoParcialDataGridViewTextBoxColumn
            // 
            this.diagnosticoParcialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diagnosticoParcialDataGridViewTextBoxColumn.DataPropertyName = "diagnosticoParcial";
            this.diagnosticoParcialDataGridViewTextBoxColumn.HeaderText = "diagnostico Parcial";
            this.diagnosticoParcialDataGridViewTextBoxColumn.Name = "diagnosticoParcialDataGridViewTextBoxColumn";
            this.diagnosticoParcialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TratamientoDetalleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 316);
            this.Controls.Add(this.dataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TratamientoDetalleList";
            this.Text = "Detalle Listado";
            this.Load += new System.EventHandler(this.TratamientoDetalleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoDetalleViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientoDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoParcialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tratamientoDetalleViewBindingSource;
    }
}