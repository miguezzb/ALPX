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
            this.SuspendLayout();
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(227, 23);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(73, 24);
            this.LFecha.TabIndex = 0;
            this.LFecha.Text = "Fecha:";
            // 
            // LNombreEmisor
            // 
            this.LNombreEmisor.AutoSize = true;
            this.LNombreEmisor.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreEmisor.ForeColor = System.Drawing.Color.White;
            this.LNombreEmisor.Location = new System.Drawing.Point(227, 74);
            this.LNombreEmisor.Name = "LNombreEmisor";
            this.LNombreEmisor.Size = new System.Drawing.Size(167, 24);
            this.LNombreEmisor.TabIndex = 1;
            this.LNombreEmisor.Text = "Nombre emisor: ";
            // 
            // LSuma
            // 
            this.LSuma.AutoSize = true;
            this.LSuma.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSuma.ForeColor = System.Drawing.Color.White;
            this.LSuma.Location = new System.Drawing.Point(227, 125);
            this.LSuma.Name = "LSuma";
            this.LSuma.Size = new System.Drawing.Size(70, 24);
            this.LSuma.TabIndex = 2;
            this.LSuma.Text = "Suma:";
            // 
            // LDctoCtaPago
            // 
            this.LDctoCtaPago.AutoSize = true;
            this.LDctoCtaPago.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDctoCtaPago.ForeColor = System.Drawing.Color.White;
            this.LDctoCtaPago.Location = new System.Drawing.Point(227, 176);
            this.LDctoCtaPago.Name = "LDctoCtaPago";
            this.LDctoCtaPago.Size = new System.Drawing.Size(206, 24);
            this.LDctoCtaPago.TabIndex = 3;
            this.LDctoCtaPago.Text = "Dcto. y cta. de pago:";
            // 
            // LRancho
            // 
            this.LRancho.AutoSize = true;
            this.LRancho.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRancho.ForeColor = System.Drawing.Color.White;
            this.LRancho.Location = new System.Drawing.Point(227, 227);
            this.LRancho.Name = "LRancho";
            this.LRancho.Size = new System.Drawing.Size(99, 24);
            this.LRancho.TabIndex = 4;
            this.LRancho.Text = "#Rancho:";
            // 
            // LTipoGasto
            // 
            this.LTipoGasto.AutoSize = true;
            this.LTipoGasto.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoGasto.ForeColor = System.Drawing.Color.White;
            this.LTipoGasto.Location = new System.Drawing.Point(227, 278);
            this.LTipoGasto.Name = "LTipoGasto";
            this.LTipoGasto.Size = new System.Drawing.Size(146, 24);
            this.LTipoGasto.TabIndex = 5;
            this.LTipoGasto.Text = "Tipo de gasto:";
            // 
            // LConcepto
            // 
            this.LConcepto.AutoSize = true;
            this.LConcepto.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConcepto.ForeColor = System.Drawing.Color.White;
            this.LConcepto.Location = new System.Drawing.Point(227, 329);
            this.LConcepto.Name = "LConcepto";
            this.LConcepto.Size = new System.Drawing.Size(107, 24);
            this.LConcepto.TabIndex = 6;
            this.LConcepto.Text = "Concepto:";
            // 
            // LCombustible
            // 
            this.LCombustible.AutoSize = true;
            this.LCombustible.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCombustible.ForeColor = System.Drawing.Color.White;
            this.LCombustible.Location = new System.Drawing.Point(227, 380);
            this.LCombustible.Name = "LCombustible";
            this.LCombustible.Size = new System.Drawing.Size(136, 24);
            this.LCombustible.TabIndex = 7;
            this.LCombustible.Text = "Combustible:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

