namespace Clinica
{
    partial class EmpleadoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoAdd));
            this.dpFechaIngreso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dpFechaIngreso
            // 
            this.dpFechaIngreso.BackColor = System.Drawing.Color.Gray;
            this.dpFechaIngreso.BorderRadius = 0;
            this.dpFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.dpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaIngreso.FormatCustom = null;
            this.dpFechaIngreso.Location = new System.Drawing.Point(413, 153);
            this.dpFechaIngreso.Name = "dpFechaIngreso";
            this.dpFechaIngreso.Size = new System.Drawing.Size(292, 36);
            this.dpFechaIngreso.TabIndex = 67;
            this.dpFechaIngreso.Value = new System.DateTime(2019, 11, 16, 16, 15, 27, 0);
            // 
            // cbMedico
            // 
            this.cbMedico.BackColor = System.Drawing.Color.White;
            this.cbMedico.DropDownHeight = 250;
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.IntegralHeight = false;
            this.cbMedico.Location = new System.Drawing.Point(413, 259);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(292, 21);
            this.cbMedico.TabIndex = 66;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(410, 219);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel9.TabIndex = 65;
            this.bunifuCustomLabel9.Text = "Medico:";
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
            this.txtEmail.Location = new System.Drawing.Point(413, 54);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 44);
            this.txtEmail.TabIndex = 59;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(410, 37);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel8.TabIndex = 58;
            this.bunifuCustomLabel8.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.dpFechaIngreso);
            this.panel2.Controls.Add(this.cbMedico);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 544);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(410, 128);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel6.TabIndex = 68;
            this.bunifuCustomLabel6.Text = "Fecha Ingreso:";
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
            this.txtTelefono.Location = new System.Drawing.Point(35, 329);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(292, 44);
            this.txtTelefono.TabIndex = 55;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 312);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel3.TabIndex = 54;
            this.bunifuCustomLabel3.Text = "Telefono:";
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
            this.txtDni.Location = new System.Drawing.Point(35, 236);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(292, 44);
            this.txtDni.TabIndex = 53;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 219);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(29, 13);
            this.bunifuCustomLabel4.TabIndex = 52;
            this.bunifuCustomLabel4.Text = "DNI:";
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
            this.btnGuardar.Location = new System.Drawing.Point(615, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(90, 48);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.txtApellido.Size = new System.Drawing.Size(292, 44);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 128);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Apellido:";
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
            this.txtNombre.Location = new System.Drawing.Point(35, 54);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 44);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 62);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "title";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(699, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 55;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // EmpleadoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadoAdd";
            this.Text = "EmpleadoAdd";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dpFechaIngreso;
        private System.Windows.Forms.ComboBox cbMedico;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDni;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
    }
}