namespace Clinica
{
    partial class ABMObraSocial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMObraSocial));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAlergias = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAntecedentes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbObraSocial = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(382, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(35, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 44);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellido.HintText = "";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellido.LineThickness = 3;
            this.txtApellido.Location = new System.Drawing.Point(35, 145);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 44);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDni
            // 
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.HintForeColor = System.Drawing.Color.Empty;
            this.txtDni.HintText = "";
            this.txtDni.isPassword = false;
            this.txtDni.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDni.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDni.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDni.LineThickness = 3;
            this.txtDni.Location = new System.Drawing.Point(35, 216);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(249, 44);
            this.txtDni.TabIndex = 6;
            this.txtDni.Text = "DNI";
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpNacimiento.BorderRadius = 0;
            this.dtpNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.FormatCustom = null;
            this.dtpNacimiento.Location = new System.Drawing.Point(331, 308);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(249, 36);
            this.dtpNacimiento.TabIndex = 7;
            this.dtpNacimiento.Value = new System.DateTime(2019, 10, 29, 18, 23, 21, 207);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(35, 300);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 44);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(331, 77);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 44);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "EMail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAlergias
            // 
            this.txtAlergias.AutoSize = true;
            this.txtAlergias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlergias.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlergias.HintForeColor = System.Drawing.Color.Empty;
            this.txtAlergias.HintText = "";
            this.txtAlergias.isPassword = false;
            this.txtAlergias.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAlergias.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAlergias.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAlergias.LineThickness = 3;
            this.txtAlergias.Location = new System.Drawing.Point(331, 145);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(249, 44);
            this.txtAlergias.TabIndex = 10;
            this.txtAlergias.Text = "Alergias";
            this.txtAlergias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.AutoSize = true;
            this.txtAntecedentes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAntecedentes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAntecedentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAntecedentes.HintForeColor = System.Drawing.Color.Empty;
            this.txtAntecedentes.HintText = "";
            this.txtAntecedentes.isPassword = false;
            this.txtAntecedentes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAntecedentes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAntecedentes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAntecedentes.LineThickness = 3;
            this.txtAntecedentes.Location = new System.Drawing.Point(331, 216);
            this.txtAntecedentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(249, 44);
            this.txtAntecedentes.TabIndex = 11;
            this.txtAntecedentes.Text = "Antecedentes";
            this.txtAntecedentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbObraSocial
            // 
            this.cbObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.cbObraSocial.BorderRadius = 3;
            this.cbObraSocial.ForeColor = System.Drawing.Color.White;
            this.cbObraSocial.Items = new string[0];
            this.cbObraSocial.Location = new System.Drawing.Point(35, 390);
            this.cbObraSocial.Name = "cbObraSocial";
            this.cbObraSocial.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbObraSocial.onHoverColor = System.Drawing.Color.Silver;
            this.cbObraSocial.selectedIndex = -1;
            this.cbObraSocial.Size = new System.Drawing.Size(249, 35);
            this.cbObraSocial.TabIndex = 12;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 37);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Pacientes\r\n";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Guardar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(35, 498);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(158, 48);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Guardar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtEditar
            // 
            this.txtEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEditar.BorderRadius = 0;
            this.txtEditar.ButtonText = "Editar";
            this.txtEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEditar.DisabledColor = System.Drawing.Color.Gray;
            this.txtEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.txtEditar.Iconimage = null;
            this.txtEditar.Iconimage_right = null;
            this.txtEditar.Iconimage_right_Selected = null;
            this.txtEditar.Iconimage_Selected = null;
            this.txtEditar.IconMarginLeft = 0;
            this.txtEditar.IconMarginRight = 0;
            this.txtEditar.IconRightVisible = true;
            this.txtEditar.IconRightZoom = 0D;
            this.txtEditar.IconVisible = true;
            this.txtEditar.IconZoom = 90D;
            this.txtEditar.IsTab = false;
            this.txtEditar.Location = new System.Drawing.Point(231, 498);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.txtEditar.selected = false;
            this.txtEditar.Size = new System.Drawing.Size(158, 48);
            this.txtEditar.TabIndex = 15;
            this.txtEditar.Text = "Editar";
            this.txtEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtEditar.Textcolor = System.Drawing.Color.White;
            this.txtEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCancelar
            // 
            this.txtCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCancelar.BorderRadius = 0;
            this.txtCancelar.ButtonText = "Cancelar";
            this.txtCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.txtCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.txtCancelar.Iconimage = null;
            this.txtCancelar.Iconimage_right = null;
            this.txtCancelar.Iconimage_right_Selected = null;
            this.txtCancelar.Iconimage_Selected = null;
            this.txtCancelar.IconMarginLeft = 0;
            this.txtCancelar.IconMarginRight = 0;
            this.txtCancelar.IconRightVisible = true;
            this.txtCancelar.IconRightZoom = 0D;
            this.txtCancelar.IconVisible = true;
            this.txtCancelar.IconZoom = 90D;
            this.txtCancelar.IsTab = false;
            this.txtCancelar.Location = new System.Drawing.Point(422, 498);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.txtCancelar.selected = false;
            this.txtCancelar.Size = new System.Drawing.Size(158, 48);
            this.txtCancelar.TabIndex = 16;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCancelar.Textcolor = System.Drawing.Color.White;
            this.txtCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(629, 79);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(576, 348);
            this.bunifuCustomDataGrid1.TabIndex = 17;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.txtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEliminar.BorderRadius = 0;
            this.txtEliminar.ButtonText = "Eliminar";
            this.txtEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.txtEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.txtEliminar.Iconimage = null;
            this.txtEliminar.Iconimage_right = null;
            this.txtEliminar.Iconimage_right_Selected = null;
            this.txtEliminar.Iconimage_Selected = null;
            this.txtEliminar.IconMarginLeft = 0;
            this.txtEliminar.IconMarginRight = 0;
            this.txtEliminar.IconRightVisible = true;
            this.txtEliminar.IconRightZoom = 0D;
            this.txtEliminar.IconVisible = true;
            this.txtEliminar.IconZoom = 90D;
            this.txtEliminar.IsTab = false;
            this.txtEliminar.Location = new System.Drawing.Point(1047, 498);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.txtEliminar.selected = false;
            this.txtEliminar.Size = new System.Drawing.Size(158, 48);
            this.txtEliminar.TabIndex = 18;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtEliminar.Textcolor = System.Drawing.Color.White;
            this.txtEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1181, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1234, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbObraSocial);
            this.Controls.Add(this.txtAntecedentes);
            this.Controls.Add(this.txtAlergias);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ABMPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDni;
        private Bunifu.Framework.UI.BunifuDatepicker dtpNacimiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAlergias;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAntecedentes;
        private Bunifu.Framework.UI.BunifuDropdown cbObraSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton txtEditar;
        private Bunifu.Framework.UI.BunifuFlatButton txtCancelar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton txtEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
    }
}