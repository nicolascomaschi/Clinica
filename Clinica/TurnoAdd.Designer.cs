namespace Clinica
{
    partial class TurnoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnoAdd));
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDetalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHora = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 62);
            this.panel1.TabIndex = 4;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(677, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 55;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(602, 395);
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
            // txtDetalle
            // 
            this.txtDetalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalle.HintForeColor = System.Drawing.Color.Empty;
            this.txtDetalle.HintText = "";
            this.txtDetalle.isPassword = false;
            this.txtDetalle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDetalle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDetalle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDetalle.LineThickness = 3;
            this.txtDetalle.Location = new System.Drawing.Point(381, 211);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(292, 44);
            this.txtDetalle.TabIndex = 3;
            this.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(378, 194);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Cometarios:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtHora);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.cbPaciente);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.cbMedico);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.dpFecha);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtDetalle);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 477);
            this.panel2.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel1.TabIndex = 68;
            this.bunifuCustomLabel1.Text = "Fecha:";
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.Gray;
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(45, 130);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(292, 36);
            this.dpFecha.TabIndex = 67;
            this.dpFecha.Value = new System.DateTime(2019, 11, 16, 16, 15, 27, 0);
            // 
            // cbMedico
            // 
            this.cbMedico.BackColor = System.Drawing.Color.White;
            this.cbMedico.DropDownHeight = 250;
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.IntegralHeight = false;
            this.cbMedico.Location = new System.Drawing.Point(45, 230);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(292, 21);
            this.cbMedico.TabIndex = 70;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(42, 194);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(45, 13);
            this.bunifuCustomLabel9.TabIndex = 69;
            this.bunifuCustomLabel9.Text = "Medico:";
            // 
            // cbPaciente
            // 
            this.cbPaciente.BackColor = System.Drawing.Color.White;
            this.cbPaciente.DropDownHeight = 250;
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.IntegralHeight = false;
            this.cbPaciente.Location = new System.Drawing.Point(45, 321);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(292, 21);
            this.cbPaciente.TabIndex = 72;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(42, 285);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel3.TabIndex = 71;
            this.bunifuCustomLabel3.Text = "Paciente:";
            // 
            // txtHora
            // 
            this.txtHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHora.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHora.HintForeColor = System.Drawing.Color.Empty;
            this.txtHora.HintText = "";
            this.txtHora.isPassword = false;
            this.txtHora.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHora.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHora.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHora.LineThickness = 3;
            this.txtHora.Location = new System.Drawing.Point(381, 122);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(106, 44);
            this.txtHora.TabIndex = 76;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(378, 105);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(33, 13);
            this.bunifuCustomLabel5.TabIndex = 75;
            this.bunifuCustomLabel5.Text = "Hora:";
            // 
            // TurnoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TurnoAdd";
            this.Text = "TurnoAdd";
            this.Load += new System.EventHandler(this.TurnoAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dpFecha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHora;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox cbPaciente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cbMedico;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}