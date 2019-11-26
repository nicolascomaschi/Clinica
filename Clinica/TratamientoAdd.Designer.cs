namespace Clinica
{
    partial class TratamientoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TratamientoAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDiagnosticoFinal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTratamiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Elimar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTratamientoDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticoParcialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoDetalleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoDetalleViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(39, 110);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel6.TabIndex = 80;
            this.bunifuCustomLabel6.Text = "Fecha:";
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.Gray;
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(42, 136);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(292, 36);
            this.dpFecha.TabIndex = 79;
            this.dpFecha.Value = new System.DateTime(2019, 11, 16, 16, 15, 27, 0);
            // 
            // cbMedico
            // 
            this.cbMedico.BackColor = System.Drawing.Color.White;
            this.cbMedico.DropDownHeight = 250;
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.IntegralHeight = false;
            this.cbMedico.Location = new System.Drawing.Point(42, 392);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(292, 21);
            this.cbMedico.TabIndex = 78;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(39, 352);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel9.TabIndex = 77;
            this.bunifuCustomLabel9.Text = "Medico:";
            // 
            // txtDiagnosticoFinal
            // 
            this.txtDiagnosticoFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosticoFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiagnosticoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnosticoFinal.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosticoFinal.HintText = "";
            this.txtDiagnosticoFinal.isPassword = false;
            this.txtDiagnosticoFinal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiagnosticoFinal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiagnosticoFinal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiagnosticoFinal.LineThickness = 3;
            this.txtDiagnosticoFinal.Location = new System.Drawing.Point(42, 290);
            this.txtDiagnosticoFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosticoFinal.Name = "txtDiagnosticoFinal";
            this.txtDiagnosticoFinal.Size = new System.Drawing.Size(292, 44);
            this.txtDiagnosticoFinal.TabIndex = 72;
            this.txtDiagnosticoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 273);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 13);
            this.bunifuCustomLabel2.TabIndex = 71;
            this.bunifuCustomLabel2.Text = "Diagnostico Final:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTratamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTratamiento.HintForeColor = System.Drawing.Color.Empty;
            this.txtTratamiento.HintText = "";
            this.txtTratamiento.isPassword = false;
            this.txtTratamiento.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTratamiento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTratamiento.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTratamiento.LineThickness = 3;
            this.txtTratamiento.Location = new System.Drawing.Point(42, 207);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(292, 44);
            this.txtTratamiento.TabIndex = 70;
            this.txtTratamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 190);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel1.TabIndex = 69;
            this.bunifuCustomLabel1.Text = "Tratamiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 62);
            this.panel1.TabIndex = 82;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(807, 16);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 55;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Agregar";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListado.AutoGenerateColumns = false;
            this.dataListado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elimar,
            this.idTratamientoDetalleDataGridViewTextBoxColumn,
            this.idTratamientoDataGridViewTextBoxColumn,
            this.sintomasDataGridViewTextBoxColumn,
            this.diagnosticoParcialDataGridViewTextBoxColumn,
            this.idMedicamentoDataGridViewTextBoxColumn,
            this.medicamentoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataListado.DataSource = this.tratamientoDetalleViewBindingSource;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dataListado.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataListado.Location = new System.Drawing.Point(406, 190);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListado.Size = new System.Drawing.Size(442, 223);
            this.dataListado.TabIndex = 98;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // Elimar
            // 
            this.Elimar.HeaderText = "Eliminar";
            this.Elimar.Name = "Elimar";
            this.Elimar.ReadOnly = true;
            this.Elimar.Text = "Eliminar";
            this.Elimar.UseColumnTextForButtonValue = true;
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
            // diagnosticoParcialDataGridViewTextBoxColumn
            // 
            this.diagnosticoParcialDataGridViewTextBoxColumn.DataPropertyName = "diagnosticoParcial";
            this.diagnosticoParcialDataGridViewTextBoxColumn.HeaderText = "diagnostico";
            this.diagnosticoParcialDataGridViewTextBoxColumn.Name = "diagnosticoParcialDataGridViewTextBoxColumn";
            this.diagnosticoParcialDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tratamientoDetalleViewBindingSource
            // 
            this.tratamientoDetalleViewBindingSource.DataSource = typeof(Logica.TratamientoDetalleView);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 7;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = null;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(758, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(90, 48);
            this.btnAgregar.TabIndex = 99;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = null;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(244, 467);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(90, 48);
            this.btnGuardar.TabIndex = 100;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TratamientoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 550);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.txtDiagnosticoFinal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TratamientoAdd";
            this.Text = "TratamientoAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientoDetalleViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dpFecha;
        private System.Windows.Forms.ComboBox cbMedico;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiagnosticoFinal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTratamiento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.DataGridViewButtonColumn Elimar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientoDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoParcialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tratamientoDetalleViewBindingSource;
    }
}