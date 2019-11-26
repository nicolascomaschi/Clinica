namespace Clinica
{
    partial class TratamientoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TratamientoDetalle));
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtDiagnosticoParcial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSistomas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(32, 88);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel6.TabIndex = 105;
            this.bunifuCustomLabel6.Text = "Fecha:";
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.Gray;
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(35, 115);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(292, 36);
            this.dpFecha.TabIndex = 104;
            this.dpFecha.Value = new System.DateTime(2019, 11, 16, 16, 15, 27, 0);
            // 
            // txtDiagnosticoParcial
            // 
            this.txtDiagnosticoParcial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosticoParcial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDiagnosticoParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnosticoParcial.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosticoParcial.HintText = "";
            this.txtDiagnosticoParcial.isPassword = false;
            this.txtDiagnosticoParcial.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiagnosticoParcial.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiagnosticoParcial.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiagnosticoParcial.LineThickness = 3;
            this.txtDiagnosticoParcial.Location = new System.Drawing.Point(35, 268);
            this.txtDiagnosticoParcial.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosticoParcial.Name = "txtDiagnosticoParcial";
            this.txtDiagnosticoParcial.Size = new System.Drawing.Size(292, 44);
            this.txtDiagnosticoParcial.TabIndex = 103;
            this.txtDiagnosticoParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 251);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 13);
            this.bunifuCustomLabel2.TabIndex = 102;
            this.bunifuCustomLabel2.Text = "Diagnostico Parcial:";
            // 
            // txtSistomas
            // 
            this.txtSistomas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSistomas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSistomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSistomas.HintForeColor = System.Drawing.Color.Empty;
            this.txtSistomas.HintText = "";
            this.txtSistomas.isPassword = false;
            this.txtSistomas.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSistomas.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSistomas.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSistomas.LineThickness = 3;
            this.txtSistomas.Location = new System.Drawing.Point(35, 185);
            this.txtSistomas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSistomas.Name = "txtSistomas";
            this.txtSistomas.Size = new System.Drawing.Size(292, 44);
            this.txtSistomas.TabIndex = 101;
            this.txtSistomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 168);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel1.TabIndex = 100;
            this.bunifuCustomLabel1.Text = "Sintomas:";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(321, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 108;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(237, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(90, 48);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.BackColor = System.Drawing.Color.White;
            this.cbMedicamento.DropDownHeight = 250;
            this.cbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.IntegralHeight = false;
            this.cbMedicamento.Location = new System.Drawing.Point(35, 375);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(292, 21);
            this.cbMedicamento.TabIndex = 111;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(32, 335);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(74, 13);
            this.bunifuCustomLabel9.TabIndex = 110;
            this.bunifuCustomLabel9.Text = "Medicamento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 62);
            this.panel1.TabIndex = 112;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(807, 16);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 55;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            // TratamientoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbMedicamento);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.txtDiagnosticoParcial);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtSistomas);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TratamientoDetalle";
            this.Text = "TratamientoDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dpFecha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiagnosticoParcial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSistomas;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.ComboBox cbMedicamento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
    }
}