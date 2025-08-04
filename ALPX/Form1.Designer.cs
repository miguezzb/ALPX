namespace ALPX
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LFecha = new System.Windows.Forms.Label();
            this.LNombreEmisor = new System.Windows.Forms.Label();
            this.LSuma = new System.Windows.Forms.Label();
            this.LDctoCtaPago = new System.Windows.Forms.Label();
            this.LRancho = new System.Windows.Forms.Label();
            this.LTipoGasto = new System.Windows.Forms.Label();
            this.LConcepto = new System.Windows.Forms.Label();
            this.LCombustible = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbEmisor = new System.Windows.Forms.ComboBox();
            this.BtnMasEmisor = new System.Windows.Forms.Button();
            this.BtnMenEmisor = new System.Windows.Forms.Button();
            this.TxtSuma = new System.Windows.Forms.TextBox();
            this.TxtDocto = new System.Windows.Forms.TextBox();
            this.CmbRancho = new System.Windows.Forms.ComboBox();
            this.CmbGasto = new System.Windows.Forms.ComboBox();
            this.CmbConce = new System.Windows.Forms.ComboBox();
            this.TxtCombustible = new System.Windows.Forms.TextBox();
            this.BtnMasRancho = new System.Windows.Forms.Button();
            this.BtnMenosRancho = new System.Windows.Forms.Button();
            this.BtnMasGasto = new System.Windows.Forms.Button();
            this.BtnMenGasto = new System.Windows.Forms.Button();
            this.BtnMasConce = new System.Windows.Forms.Button();
            this.BtnMenConce = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.PictureBox();
            this.BtnLimpia = new System.Windows.Forms.PictureBox();
            this.BtnVerDatos = new System.Windows.Forms.PictureBox();
            this.BtnCargaArchivo = new System.Windows.Forms.PictureBox();
            this.BtnGastos1 = new System.Windows.Forms.Button();
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargaArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(412, 90);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(86, 26);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
            // 
            // LNombreEmisor
            // 
            this.LNombreEmisor.AutoSize = true;
            this.LNombreEmisor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreEmisor.ForeColor = System.Drawing.Color.White;
            this.LNombreEmisor.Location = new System.Drawing.Point(412, 152);
            this.LNombreEmisor.Name = "LNombreEmisor";
            this.LNombreEmisor.Size = new System.Drawing.Size(194, 26);
            this.LNombreEmisor.TabIndex = 1;
            this.LNombreEmisor.Text = "Nombre emisor: ";
            // 
            // LSuma
            // 
            this.LSuma.AutoSize = true;
            this.LSuma.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSuma.ForeColor = System.Drawing.Color.White;
            this.LSuma.Location = new System.Drawing.Point(412, 214);
            this.LSuma.Name = "LSuma";
            this.LSuma.Size = new System.Drawing.Size(81, 26);
            this.LSuma.TabIndex = 2;
            this.LSuma.Text = "Suma:";
            // 
            // LDctoCtaPago
            // 
            this.LDctoCtaPago.AutoSize = true;
            this.LDctoCtaPago.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDctoCtaPago.ForeColor = System.Drawing.Color.White;
            this.LDctoCtaPago.Location = new System.Drawing.Point(412, 276);
            this.LDctoCtaPago.Name = "LDctoCtaPago";
            this.LDctoCtaPago.Size = new System.Drawing.Size(235, 26);
            this.LDctoCtaPago.TabIndex = 3;
            this.LDctoCtaPago.Text = "Dcto. y cta. de pago:";
            // 
            // LRancho
            // 
            this.LRancho.AutoSize = true;
            this.LRancho.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRancho.ForeColor = System.Drawing.Color.White;
            this.LRancho.Location = new System.Drawing.Point(412, 338);
            this.LRancho.Name = "LRancho";
            this.LRancho.Size = new System.Drawing.Size(117, 26);
            this.LRancho.TabIndex = 4;
            this.LRancho.Text = "#Rancho:";
            // 
            // LTipoGasto
            // 
            this.LTipoGasto.AutoSize = true;
            this.LTipoGasto.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoGasto.ForeColor = System.Drawing.Color.White;
            this.LTipoGasto.Location = new System.Drawing.Point(412, 400);
            this.LTipoGasto.Name = "LTipoGasto";
            this.LTipoGasto.Size = new System.Drawing.Size(168, 26);
            this.LTipoGasto.TabIndex = 5;
            this.LTipoGasto.Text = "Tipo de gasto:";
            // 
            // LConcepto
            // 
            this.LConcepto.AutoSize = true;
            this.LConcepto.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConcepto.ForeColor = System.Drawing.Color.White;
            this.LConcepto.Location = new System.Drawing.Point(412, 462);
            this.LConcepto.Name = "LConcepto";
            this.LConcepto.Size = new System.Drawing.Size(126, 26);
            this.LConcepto.TabIndex = 6;
            this.LConcepto.Text = "Concepto:";
            // 
            // LCombustible
            // 
            this.LCombustible.AutoSize = true;
            this.LCombustible.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCombustible.ForeColor = System.Drawing.Color.White;
            this.LCombustible.Location = new System.Drawing.Point(412, 524);
            this.LCombustible.Name = "LCombustible";
            this.LCombustible.Size = new System.Drawing.Size(158, 26);
            this.LCombustible.TabIndex = 7;
            this.LCombustible.Text = "Combustible:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(354, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 650);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(682, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // CmbEmisor
            // 
            this.CmbEmisor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmisor.FormattingEnabled = true;
            this.CmbEmisor.Location = new System.Drawing.Point(682, 151);
            this.CmbEmisor.Name = "CmbEmisor";
            this.CmbEmisor.Size = new System.Drawing.Size(375, 29);
            this.CmbEmisor.TabIndex = 11;
            // 
            // BtnMasEmisor
            // 
            this.BtnMasEmisor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMasEmisor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasEmisor.ForeColor = System.Drawing.Color.White;
            this.BtnMasEmisor.Location = new System.Drawing.Point(1072, 150);
            this.BtnMasEmisor.Name = "BtnMasEmisor";
            this.BtnMasEmisor.Size = new System.Drawing.Size(40, 30);
            this.BtnMasEmisor.TabIndex = 12;
            this.BtnMasEmisor.Text = "+";
            this.BtnMasEmisor.UseVisualStyleBackColor = true;
            this.BtnMasEmisor.Click += new System.EventHandler(this.BtnMasEmisor_Click);
            this.BtnMasEmisor.MouseEnter += new System.EventHandler(this.BtnMasEmisor_MouseEnter);
            this.BtnMasEmisor.MouseLeave += new System.EventHandler(this.BtnMasEmisor_MouseLeave);
            // 
            // BtnMenEmisor
            // 
            this.BtnMenEmisor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenEmisor.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenEmisor.ForeColor = System.Drawing.Color.White;
            this.BtnMenEmisor.Location = new System.Drawing.Point(1118, 150);
            this.BtnMenEmisor.Name = "BtnMenEmisor";
            this.BtnMenEmisor.Size = new System.Drawing.Size(40, 30);
            this.BtnMenEmisor.TabIndex = 13;
            this.BtnMenEmisor.Text = "-";
            this.BtnMenEmisor.UseVisualStyleBackColor = true;
            this.BtnMenEmisor.Click += new System.EventHandler(this.BtnMenEmisor_Click);
            this.BtnMenEmisor.MouseEnter += new System.EventHandler(this.BtnMenEmisor_MouseEnter);
            this.BtnMenEmisor.MouseLeave += new System.EventHandler(this.BtnMenEmisor_MouseLeave);
            // 
            // TxtSuma
            // 
            this.TxtSuma.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSuma.Location = new System.Drawing.Point(682, 213);
            this.TxtSuma.Name = "TxtSuma";
            this.TxtSuma.Size = new System.Drawing.Size(375, 28);
            this.TxtSuma.TabIndex = 14;
            this.TxtSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSuma_KeyPress);
            // 
            // TxtDocto
            // 
            this.TxtDocto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocto.Location = new System.Drawing.Point(682, 275);
            this.TxtDocto.Name = "TxtDocto";
            this.TxtDocto.Size = new System.Drawing.Size(375, 28);
            this.TxtDocto.TabIndex = 15;
            this.TxtDocto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocto_KeyPress);
            // 
            // CmbRancho
            // 
            this.CmbRancho.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.CmbRancho.FormattingEnabled = true;
            this.CmbRancho.Location = new System.Drawing.Point(682, 337);
            this.CmbRancho.Name = "CmbRancho";
            this.CmbRancho.Size = new System.Drawing.Size(375, 29);
            this.CmbRancho.TabIndex = 16;
            // 
            // CmbGasto
            // 
            this.CmbGasto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.CmbGasto.FormattingEnabled = true;
            this.CmbGasto.Location = new System.Drawing.Point(682, 399);
            this.CmbGasto.Name = "CmbGasto";
            this.CmbGasto.Size = new System.Drawing.Size(375, 29);
            this.CmbGasto.TabIndex = 17;
            // 
            // CmbConce
            // 
            this.CmbConce.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.CmbConce.FormattingEnabled = true;
            this.CmbConce.Location = new System.Drawing.Point(682, 461);
            this.CmbConce.Name = "CmbConce";
            this.CmbConce.Size = new System.Drawing.Size(375, 29);
            this.CmbConce.TabIndex = 18;
            // 
            // TxtCombustible
            // 
            this.TxtCombustible.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.TxtCombustible.Location = new System.Drawing.Point(682, 523);
            this.TxtCombustible.Name = "TxtCombustible";
            this.TxtCombustible.Size = new System.Drawing.Size(375, 28);
            this.TxtCombustible.TabIndex = 19;
            // 
            // BtnMasRancho
            // 
            this.BtnMasRancho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMasRancho.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMasRancho.ForeColor = System.Drawing.Color.White;
            this.BtnMasRancho.Location = new System.Drawing.Point(1072, 336);
            this.BtnMasRancho.Name = "BtnMasRancho";
            this.BtnMasRancho.Size = new System.Drawing.Size(40, 30);
            this.BtnMasRancho.TabIndex = 20;
            this.BtnMasRancho.Text = "+";
            this.BtnMasRancho.UseVisualStyleBackColor = true;
            this.BtnMasRancho.Click += new System.EventHandler(this.BtnMasRancho_Click);
            this.BtnMasRancho.MouseEnter += new System.EventHandler(this.BtnMasRancho_MouseEnter);
            this.BtnMasRancho.MouseLeave += new System.EventHandler(this.BtnMasRancho_MouseLeave);
            // 
            // BtnMenosRancho
            // 
            this.BtnMenosRancho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenosRancho.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMenosRancho.ForeColor = System.Drawing.Color.White;
            this.BtnMenosRancho.Location = new System.Drawing.Point(1118, 336);
            this.BtnMenosRancho.Name = "BtnMenosRancho";
            this.BtnMenosRancho.Size = new System.Drawing.Size(40, 30);
            this.BtnMenosRancho.TabIndex = 21;
            this.BtnMenosRancho.Text = "-";
            this.BtnMenosRancho.UseVisualStyleBackColor = true;
            this.BtnMenosRancho.Click += new System.EventHandler(this.BtnMenosRancho_Click);
            this.BtnMenosRancho.MouseEnter += new System.EventHandler(this.BtnMenosRancho_MouseEnter);
            this.BtnMenosRancho.MouseLeave += new System.EventHandler(this.BtnMenosRancho_MouseLeave);
            // 
            // BtnMasGasto
            // 
            this.BtnMasGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMasGasto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMasGasto.ForeColor = System.Drawing.Color.White;
            this.BtnMasGasto.Location = new System.Drawing.Point(1072, 398);
            this.BtnMasGasto.Name = "BtnMasGasto";
            this.BtnMasGasto.Size = new System.Drawing.Size(40, 30);
            this.BtnMasGasto.TabIndex = 22;
            this.BtnMasGasto.Text = "+";
            this.BtnMasGasto.UseVisualStyleBackColor = true;
            this.BtnMasGasto.Click += new System.EventHandler(this.BtnMasGasto_Click);
            this.BtnMasGasto.MouseEnter += new System.EventHandler(this.BtnMasGasto_MouseEnter);
            this.BtnMasGasto.MouseLeave += new System.EventHandler(this.BtnMasGasto_MouseLeave);
            // 
            // BtnMenGasto
            // 
            this.BtnMenGasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenGasto.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMenGasto.ForeColor = System.Drawing.Color.White;
            this.BtnMenGasto.Location = new System.Drawing.Point(1118, 398);
            this.BtnMenGasto.Name = "BtnMenGasto";
            this.BtnMenGasto.Size = new System.Drawing.Size(40, 30);
            this.BtnMenGasto.TabIndex = 23;
            this.BtnMenGasto.Text = "-";
            this.BtnMenGasto.UseVisualStyleBackColor = true;
            this.BtnMenGasto.Click += new System.EventHandler(this.BtnMenGasto_Click);
            this.BtnMenGasto.MouseEnter += new System.EventHandler(this.BtnMenGasto_MouseEnter);
            this.BtnMenGasto.MouseLeave += new System.EventHandler(this.BtnMenGasto_MouseLeave);
            // 
            // BtnMasConce
            // 
            this.BtnMasConce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMasConce.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMasConce.ForeColor = System.Drawing.Color.White;
            this.BtnMasConce.Location = new System.Drawing.Point(1072, 460);
            this.BtnMasConce.Name = "BtnMasConce";
            this.BtnMasConce.Size = new System.Drawing.Size(40, 30);
            this.BtnMasConce.TabIndex = 24;
            this.BtnMasConce.Text = "+";
            this.BtnMasConce.UseVisualStyleBackColor = true;
            this.BtnMasConce.Click += new System.EventHandler(this.BtnMasConce_Click);
            this.BtnMasConce.MouseEnter += new System.EventHandler(this.BtnMasConce_MouseEnter);
            this.BtnMasConce.MouseLeave += new System.EventHandler(this.BtnMasConce_MouseLeave);
            // 
            // BtnMenConce
            // 
            this.BtnMenConce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenConce.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnMenConce.ForeColor = System.Drawing.Color.White;
            this.BtnMenConce.Location = new System.Drawing.Point(1118, 460);
            this.BtnMenConce.Name = "BtnMenConce";
            this.BtnMenConce.Size = new System.Drawing.Size(40, 30);
            this.BtnMenConce.TabIndex = 25;
            this.BtnMenConce.Text = "-";
            this.BtnMenConce.UseVisualStyleBackColor = true;
            this.BtnMenConce.Click += new System.EventHandler(this.BtnMenConce_Click);
            this.BtnMenConce.MouseEnter += new System.EventHandler(this.BtnMenConce_MouseEnter);
            this.BtnMenConce.MouseLeave += new System.EventHandler(this.BtnMenConce_MouseLeave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(500, 590);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(70, 40);
            this.BtnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.TabStop = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpia
            // 
            this.BtnLimpia.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpia.Image")));
            this.BtnLimpia.Location = new System.Drawing.Point(677, 590);
            this.BtnLimpia.Name = "BtnLimpia";
            this.BtnLimpia.Size = new System.Drawing.Size(70, 40);
            this.BtnLimpia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLimpia.TabIndex = 27;
            this.BtnLimpia.TabStop = false;
            this.BtnLimpia.Click += new System.EventHandler(this.BtnLimpia_Click);
            // 
            // BtnVerDatos
            // 
            this.BtnVerDatos.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerDatos.Image")));
            this.BtnVerDatos.Location = new System.Drawing.Point(854, 590);
            this.BtnVerDatos.Name = "BtnVerDatos";
            this.BtnVerDatos.Size = new System.Drawing.Size(70, 40);
            this.BtnVerDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVerDatos.TabIndex = 28;
            this.BtnVerDatos.TabStop = false;
            this.BtnVerDatos.Click += new System.EventHandler(this.BtnVerDatos_Click);
            // 
            // BtnCargaArchivo
            // 
            this.BtnCargaArchivo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCargaArchivo.Image")));
            this.BtnCargaArchivo.Location = new System.Drawing.Point(1031, 590);
            this.BtnCargaArchivo.Name = "BtnCargaArchivo";
            this.BtnCargaArchivo.Size = new System.Drawing.Size(70, 40);
            this.BtnCargaArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCargaArchivo.TabIndex = 29;
            this.BtnCargaArchivo.TabStop = false;
            this.BtnCargaArchivo.Click += new System.EventHandler(this.BtnCargaArchivo_Click);
            // 
            // BtnGastos1
            // 
            this.BtnGastos1.BackColor = System.Drawing.Color.Transparent;
            this.BtnGastos1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGastos1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGastos1.ForeColor = System.Drawing.Color.White;
            this.BtnGastos1.Location = new System.Drawing.Point(552, 8);
            this.BtnGastos1.Name = "BtnGastos1";
            this.BtnGastos1.Size = new System.Drawing.Size(75, 30);
            this.BtnGastos1.TabIndex = 30;
            this.BtnGastos1.Text = "Gastos";
            this.BtnGastos1.UseVisualStyleBackColor = false;
            // 
            // BtnForm2
            // 
            this.BtnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnForm2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForm2.ForeColor = System.Drawing.Color.White;
            this.BtnForm2.Location = new System.Drawing.Point(633, 8);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(230, 30);
            this.BtnForm2.TabIndex = 31;
            this.BtnForm2.Text = "Resumen de Gastos General";
            this.BtnForm2.UseVisualStyleBackColor = true;
            this.BtnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(869, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 32;
            this.button3.Text = "Caja Alipao";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(995, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 33;
            this.button4.Text = "Ventas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1076, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 30);
            this.button5.TabIndex = 34;
            this.button5.Text = "General";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnForm2);
            this.Controls.Add(this.BtnGastos1);
            this.Controls.Add(this.BtnCargaArchivo);
            this.Controls.Add(this.BtnVerDatos);
            this.Controls.Add(this.BtnLimpia);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnMenConce);
            this.Controls.Add(this.BtnMasConce);
            this.Controls.Add(this.BtnMenGasto);
            this.Controls.Add(this.BtnMasGasto);
            this.Controls.Add(this.BtnMenosRancho);
            this.Controls.Add(this.BtnMasRancho);
            this.Controls.Add(this.TxtCombustible);
            this.Controls.Add(this.CmbConce);
            this.Controls.Add(this.CmbGasto);
            this.Controls.Add(this.CmbRancho);
            this.Controls.Add(this.TxtDocto);
            this.Controls.Add(this.TxtSuma);
            this.Controls.Add(this.BtnMenEmisor);
            this.Controls.Add(this.BtnMasEmisor);
            this.Controls.Add(this.CmbEmisor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LCombustible);
            this.Controls.Add(this.LConcepto);
            this.Controls.Add(this.LTipoGasto);
            this.Controls.Add(this.LRancho);
            this.Controls.Add(this.LDctoCtaPago);
            this.Controls.Add(this.LSuma);
            this.Controls.Add(this.LNombreEmisor);
            this.Controls.Add(this.LFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALPX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargaArchivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LNombreEmisor;
        private System.Windows.Forms.Label LSuma;
        private System.Windows.Forms.Label LDctoCtaPago;
        private System.Windows.Forms.Label LRancho;
        private System.Windows.Forms.Label LTipoGasto;
        private System.Windows.Forms.Label LConcepto;
        private System.Windows.Forms.Label LCombustible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbEmisor;
        private System.Windows.Forms.Button BtnMasEmisor;
        private System.Windows.Forms.Button BtnMenEmisor;
        private System.Windows.Forms.TextBox TxtSuma;
        private System.Windows.Forms.TextBox TxtDocto;
        private System.Windows.Forms.ComboBox CmbRancho;
        private System.Windows.Forms.ComboBox CmbGasto;
        private System.Windows.Forms.ComboBox CmbConce;
        private System.Windows.Forms.TextBox TxtCombustible;
        private System.Windows.Forms.Button BtnMasRancho;
        private System.Windows.Forms.Button BtnMenosRancho;
        private System.Windows.Forms.Button BtnMasGasto;
        private System.Windows.Forms.Button BtnMenGasto;
        private System.Windows.Forms.Button BtnMasConce;
        private System.Windows.Forms.Button BtnMenConce;
        private System.Windows.Forms.PictureBox BtnGuardar;
        private System.Windows.Forms.PictureBox BtnLimpia;
        private System.Windows.Forms.PictureBox BtnVerDatos;
        private System.Windows.Forms.PictureBox BtnCargaArchivo;
        private System.Windows.Forms.Button BtnGastos1;
        private System.Windows.Forms.Button BtnForm2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

