﻿namespace Clinica
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnObraSocial = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMedicamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTratamiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMedico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTurnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(158, 61);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1126, 550);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnObraSocial
            // 
            this.btnObraSocial.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnObraSocial.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnObraSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObraSocial.BorderRadius = 0;
            this.btnObraSocial.ButtonText = "Obra Social";
            this.btnObraSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObraSocial.DisabledColor = System.Drawing.Color.Gray;
            this.btnObraSocial.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObraSocial.Iconimage = null;
            this.btnObraSocial.Iconimage_right = null;
            this.btnObraSocial.Iconimage_right_Selected = null;
            this.btnObraSocial.Iconimage_Selected = null;
            this.btnObraSocial.IconMarginLeft = 0;
            this.btnObraSocial.IconMarginRight = 0;
            this.btnObraSocial.IconRightVisible = true;
            this.btnObraSocial.IconRightZoom = 0D;
            this.btnObraSocial.IconVisible = true;
            this.btnObraSocial.IconZoom = 90D;
            this.btnObraSocial.IsTab = false;
            this.btnObraSocial.Location = new System.Drawing.Point(3, 3);
            this.btnObraSocial.Name = "btnObraSocial";
            this.btnObraSocial.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnObraSocial.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnObraSocial.OnHoverTextColor = System.Drawing.Color.White;
            this.btnObraSocial.selected = false;
            this.btnObraSocial.Size = new System.Drawing.Size(152, 30);
            this.btnObraSocial.TabIndex = 1;
            this.btnObraSocial.Text = "Obra Social";
            this.btnObraSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObraSocial.Textcolor = System.Drawing.Color.White;
            this.btnObraSocial.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObraSocial.Click += new System.EventHandler(this.BtnObraSocial_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnMedicamento, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEmpleado, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnTratamiento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMedico, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnTurnos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPacientes, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 611);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnMedicamento
            // 
            this.btnMedicamento.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMedicamento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicamento.BorderRadius = 0;
            this.btnMedicamento.ButtonText = "Medicamentos";
            this.btnMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicamento.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedicamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedicamento.Iconimage = null;
            this.btnMedicamento.Iconimage_right = null;
            this.btnMedicamento.Iconimage_right_Selected = null;
            this.btnMedicamento.Iconimage_Selected = null;
            this.btnMedicamento.IconMarginLeft = 0;
            this.btnMedicamento.IconMarginRight = 0;
            this.btnMedicamento.IconRightVisible = true;
            this.btnMedicamento.IconRightZoom = 0D;
            this.btnMedicamento.IconVisible = true;
            this.btnMedicamento.IconZoom = 90D;
            this.btnMedicamento.IsTab = false;
            this.btnMedicamento.Location = new System.Drawing.Point(3, 307);
            this.btnMedicamento.Name = "btnMedicamento";
            this.btnMedicamento.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnMedicamento.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnMedicamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedicamento.selected = false;
            this.btnMedicamento.Size = new System.Drawing.Size(158, 70);
            this.btnMedicamento.TabIndex = 6;
            this.btnMedicamento.Text = "Medicamentos";
            this.btnMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicamento.Textcolor = System.Drawing.Color.White;
            this.btnMedicamento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamento.Click += new System.EventHandler(this.BtnMedicamento_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnEmpleado.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleado.BorderRadius = 0;
            this.btnEmpleado.ButtonText = "Empleados";
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleado.Iconimage = null;
            this.btnEmpleado.Iconimage_right = null;
            this.btnEmpleado.Iconimage_right_Selected = null;
            this.btnEmpleado.Iconimage_Selected = null;
            this.btnEmpleado.IconMarginLeft = 0;
            this.btnEmpleado.IconMarginRight = 0;
            this.btnEmpleado.IconRightVisible = true;
            this.btnEmpleado.IconRightZoom = 0D;
            this.btnEmpleado.IconVisible = true;
            this.btnEmpleado.IconZoom = 90D;
            this.btnEmpleado.IsTab = false;
            this.btnEmpleado.Location = new System.Drawing.Point(3, 459);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnEmpleado.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleado.selected = false;
            this.btnEmpleado.Size = new System.Drawing.Size(158, 70);
            this.btnEmpleado.TabIndex = 5;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // btnTratamiento
            // 
            this.btnTratamiento.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnTratamiento.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTratamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTratamiento.BorderRadius = 0;
            this.btnTratamiento.ButtonText = "Historia clinica";
            this.btnTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTratamiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnTratamiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTratamiento.Iconimage = null;
            this.btnTratamiento.Iconimage_right = null;
            this.btnTratamiento.Iconimage_right_Selected = null;
            this.btnTratamiento.Iconimage_Selected = null;
            this.btnTratamiento.IconMarginLeft = 0;
            this.btnTratamiento.IconMarginRight = 0;
            this.btnTratamiento.IconRightVisible = true;
            this.btnTratamiento.IconRightZoom = 0D;
            this.btnTratamiento.IconVisible = true;
            this.btnTratamiento.IconZoom = 90D;
            this.btnTratamiento.IsTab = false;
            this.btnTratamiento.Location = new System.Drawing.Point(3, 79);
            this.btnTratamiento.Name = "btnTratamiento";
            this.btnTratamiento.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnTratamiento.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnTratamiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTratamiento.selected = false;
            this.btnTratamiento.Size = new System.Drawing.Size(158, 70);
            this.btnTratamiento.TabIndex = 5;
            this.btnTratamiento.Text = "Historia clinica";
            this.btnTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTratamiento.Textcolor = System.Drawing.Color.White;
            this.btnTratamiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamiento.Click += new System.EventHandler(this.BtnTratamiento_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bunifuFlatButton1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnObraSocial, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 535);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 73);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Especialidad";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 39);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(152, 31);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Especialidad";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Clinica.Properties.Resources.mb_centromedico;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 70);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMedico
            // 
            this.btnMedico.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnMedico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedico.BorderRadius = 0;
            this.btnMedico.ButtonText = "Medicos";
            this.btnMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedico.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedico.Iconimage = null;
            this.btnMedico.Iconimage_right = null;
            this.btnMedico.Iconimage_right_Selected = null;
            this.btnMedico.Iconimage_Selected = null;
            this.btnMedico.IconMarginLeft = 0;
            this.btnMedico.IconMarginRight = 0;
            this.btnMedico.IconRightVisible = true;
            this.btnMedico.IconRightZoom = 0D;
            this.btnMedico.IconVisible = true;
            this.btnMedico.IconZoom = 90D;
            this.btnMedico.IsTab = false;
            this.btnMedico.Location = new System.Drawing.Point(3, 383);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnMedico.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnMedico.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedico.selected = false;
            this.btnMedico.Size = new System.Drawing.Size(158, 70);
            this.btnMedico.TabIndex = 4;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedico.Textcolor = System.Drawing.Color.White;
            this.btnMedico.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnTurnos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnos.BorderRadius = 0;
            this.btnTurnos.ButtonText = "Turnos";
            this.btnTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurnos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTurnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTurnos.Iconimage = null;
            this.btnTurnos.Iconimage_right = null;
            this.btnTurnos.Iconimage_right_Selected = null;
            this.btnTurnos.Iconimage_Selected = null;
            this.btnTurnos.IconMarginLeft = 0;
            this.btnTurnos.IconMarginRight = 0;
            this.btnTurnos.IconRightVisible = true;
            this.btnTurnos.IconRightZoom = 0D;
            this.btnTurnos.IconVisible = true;
            this.btnTurnos.IconZoom = 90D;
            this.btnTurnos.IsTab = false;
            this.btnTurnos.Location = new System.Drawing.Point(3, 155);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnTurnos.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnTurnos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTurnos.selected = false;
            this.btnTurnos.Size = new System.Drawing.Size(158, 70);
            this.btnTurnos.TabIndex = 4;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTurnos.Textcolor = System.Drawing.Color.White;
            this.btnTurnos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.Click += new System.EventHandler(this.BtnTurnos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnPacientes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.BorderRadius = 0;
            this.btnPacientes.ButtonText = "Pacientes";
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPacientes.Iconimage = null;
            this.btnPacientes.Iconimage_right = null;
            this.btnPacientes.Iconimage_right_Selected = null;
            this.btnPacientes.Iconimage_Selected = null;
            this.btnPacientes.IconMarginLeft = 0;
            this.btnPacientes.IconMarginRight = 0;
            this.btnPacientes.IconRightVisible = true;
            this.btnPacientes.IconRightZoom = 0D;
            this.btnPacientes.IconVisible = true;
            this.btnPacientes.IconZoom = 90D;
            this.btnPacientes.IsTab = false;
            this.btnPacientes.Location = new System.Drawing.Point(3, 231);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnPacientes.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnPacientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPacientes.selected = false;
            this.btnPacientes.Size = new System.Drawing.Size(158, 70);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPacientes.Textcolor = System.Drawing.Color.White;
            this.btnPacientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 63);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(349, 31);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Nombre Consultorio Medico";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1073, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 37);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 43;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Principal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnObraSocial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPacientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedico;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnTurnos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedicamento;
        private Bunifu.Framework.UI.BunifuFlatButton btnTratamiento;
    }
}