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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(414, 81);
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
            this.LNombreEmisor.Location = new System.Drawing.Point(414, 144);
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
            this.LSuma.Location = new System.Drawing.Point(414, 207);
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
            this.LDctoCtaPago.Location = new System.Drawing.Point(414, 270);
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
            this.LRancho.Location = new System.Drawing.Point(414, 333);
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
            this.LTipoGasto.Location = new System.Drawing.Point(414, 396);
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
            this.LConcepto.Location = new System.Drawing.Point(414, 459);
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
            this.LCombustible.Location = new System.Drawing.Point(414, 522);
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
            this.pictureBox1.Size = new System.Drawing.Size(350, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(354, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 625);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 628);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

