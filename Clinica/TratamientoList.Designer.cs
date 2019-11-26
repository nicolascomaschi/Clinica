namespace Clinica
{
    partial class TratamientoList
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
            this.Elimar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamiento1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoViewBindingSource)).BeginInit();
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
            this.Elimar,
            this.idTratamientoDataGridViewTextBoxColumn,
            this.tratamiento1DataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.diagnosticoFinalDataGridViewTextBoxColumn,
            this.idMedicoDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn});
            this.dataListado.DataSource = this.tratamientoViewBindingSource;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dataListado.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataListado.Location = new System.Drawing.Point(12, 12);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListado.Size = new System.Drawing.Size(675, 291);
            this.dataListado.TabIndex = 70;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // Elimar
            // 
            this.Elimar.HeaderText = "Detalle";
            this.Elimar.Name = "Elimar";
            this.Elimar.ReadOnly = true;
            this.Elimar.Text = "Detalle";
            this.Elimar.UseColumnTextForButtonValue = true;
            // 
            // idTratamientoDataGridViewTextBoxColumn
            // 
            this.idTratamientoDataGridViewTextBoxColumn.DataPropertyName = "idTratamiento";
            this.idTratamientoDataGridViewTextBoxColumn.HeaderText = "idTratamiento";
            this.idTratamientoDataGridViewTextBoxColumn.Name = "idTratamientoDataGridViewTextBoxColumn";
            this.idTratamientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTratamientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tratamiento1DataGridViewTextBoxColumn
            // 
            this.tratamiento1DataGridViewTextBoxColumn.DataPropertyName = "tratamiento1";
            this.tratamiento1DataGridViewTextBoxColumn.HeaderText = "tratamiento";
            this.tratamiento1DataGridViewTextBoxColumn.Name = "tratamiento1DataGridViewTextBoxColumn";
            this.tratamiento1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosticoFinalDataGridViewTextBoxColumn
            // 
            this.diagnosticoFinalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diagnosticoFinalDataGridViewTextBoxColumn.DataPropertyName = "diagnosticoFinal";
            this.diagnosticoFinalDataGridViewTextBoxColumn.HeaderText = "Diagnostico Final";
            this.diagnosticoFinalDataGridViewTextBoxColumn.Name = "diagnosticoFinalDataGridViewTextBoxColumn";
            this.diagnosticoFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "idMedico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMedicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // tratamientoViewBindingSource
            // 
            this.tratamientoViewBindingSource.DataSource = typeof(Logica.TratamientoView);
            // 
            // TratamientoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 315);
            this.Controls.Add(this.dataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TratamientoList";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.TratamientoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private System.Windows.Forms.BindingSource tratamientoViewBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Elimar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamiento1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
    }
}