namespace Clinica
{
    partial class Turno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dpFiltro = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton22 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataListado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.turnoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Elimar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTurnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dpFiltro
            // 
            this.dpFiltro.BackColor = System.Drawing.Color.Gray;
            this.dpFiltro.BorderRadius = 0;
            this.dpFiltro.ForeColor = System.Drawing.Color.White;
            this.dpFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFiltro.FormatCustom = null;
            this.dpFiltro.Location = new System.Drawing.Point(903, 94);
            this.dpFiltro.Name = "dpFiltro";
            this.dpFiltro.Size = new System.Drawing.Size(211, 36);
            this.dpFiltro.TabIndex = 0;
            this.dpFiltro.Value = new System.DateTime(2019, 11, 19, 17, 7, 19, 348);
            this.dpFiltro.onValueChanged += new System.EventHandler(this.DpFiltro_onValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(900, 78);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Fecha:";
            // 
            // bunifuImageButton22
            // 
            this.bunifuImageButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton22.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton22.Image")));
            this.bunifuImageButton22.ImageActive = null;
            this.bunifuImageButton22.Location = new System.Drawing.Point(1073, 12);
            this.bunifuImageButton22.Name = "bunifuImageButton22";
            this.bunifuImageButton22.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton22.TabIndex = 92;
            this.bunifuImageButton22.TabStop = false;
            this.bunifuImageButton22.Zoom = 10;
            this.bunifuImageButton22.Click += new System.EventHandler(this.BunifuImageButton22_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 37);
            this.bunifuCustomLabel2.TabIndex = 94;
            this.bunifuCustomLabel2.Text = "Turnos";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.BunifuCustomLabel2_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(90, 48);
            this.btnAgregar.TabIndex = 95;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.Editar,
            this.idTurnoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.pacienteDataGridViewTextBoxColumn,
            this.idMedicoDataGridViewTextBoxColumn,
            this.medicoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn});
            this.dataListado.DataSource = this.turnoViewBindingSource;
            this.dataListado.DoubleBuffered = true;
            this.dataListado.EnableHeadersVisualStyles = false;
            this.dataListado.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dataListado.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataListado.Location = new System.Drawing.Point(12, 147);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataListado.Size = new System.Drawing.Size(1102, 391);
            this.dataListado.TabIndex = 96;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // turnoViewBindingSource
            // 
            this.turnoViewBindingSource.DataSource = typeof(Logica.TurnoView);
            // 
            // Elimar
            // 
            this.Elimar.HeaderText = "Eliminar";
            this.Elimar.Name = "Elimar";
            this.Elimar.ReadOnly = true;
            this.Elimar.Text = "Eliminar";
            this.Elimar.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // idTurnoDataGridViewTextBoxColumn
            // 
            this.idTurnoDataGridViewTextBoxColumn.DataPropertyName = "idTurno";
            this.idTurnoDataGridViewTextBoxColumn.HeaderText = "idTurno";
            this.idTurnoDataGridViewTextBoxColumn.Name = "idTurnoDataGridViewTextBoxColumn";
            this.idTurnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTurnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            this.pacienteDataGridViewTextBoxColumn.DataPropertyName = "paciente";
            this.pacienteDataGridViewTextBoxColumn.HeaderText = "paciente";
            this.pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            this.pacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "idMedico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMedicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // medicoDataGridViewTextBoxColumn
            // 
            this.medicoDataGridViewTextBoxColumn.DataPropertyName = "medico";
            this.medicoDataGridViewTextBoxColumn.HeaderText = "medico";
            this.medicoDataGridViewTextBoxColumn.Name = "medicoDataGridViewTextBoxColumn";
            this.medicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 550);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuImageButton22);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dpFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turno";
            this.Text = "Turno";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker dpFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton22;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataListado;
        private System.Windows.Forms.BindingSource turnoViewBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Elimar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
    }
}