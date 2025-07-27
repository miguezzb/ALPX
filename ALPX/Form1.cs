using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using static ALPX.ExcelManager;

namespace ALPX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color bg_color = ColorTranslator.FromHtml("#050505");
            this.BackColor = bg_color;

            this.Opacity = 0.85;
        }

        #region ANIMACIONES
        private void Form1_Activated(object sender, EventArgs e)
        {
            // Cuando el Form1 está activo
            BtnGastos1.BackColor = ColorTranslator.FromHtml("#9389d2"); // Elige el color que quieras
            BtnGastos1.Enabled = false;
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // Cuando Form1 pierde el foco (por ejemplo, otro formulario o ventana externa)
            BtnGastos1.BackColor = Color.Transparent;  // Color por defecto o el que prefieras
            BtnGastos1.Enabled = true;
        }

        private void BtnMasEmisor_MouseEnter(object sender, EventArgs e)
        {
            BtnMasEmisor.BackColor = ColorTranslator.FromHtml("#cef17b");
            BtnMasEmisor.ForeColor = Color.Black;
        }
        private void BtnMasEmisor_MouseLeave(object sender, EventArgs e)
        {
            BtnMasEmisor.FlatStyle = FlatStyle.Flat;
            BtnMasEmisor.FlatAppearance.BorderSize = 0;
            BtnMasEmisor.BackColor = Color.Transparent;
            BtnMasEmisor.ForeColor = Color.White;
        }
        private void BtnMenEmisor_MouseEnter(object sender, EventArgs e)
        {
            BtnMenEmisor.BackColor = ColorTranslator.FromHtml("#e61421");
        }
        private void BtnMenEmisor_MouseLeave(object sender, EventArgs e)
        {
            BtnMenEmisor.FlatStyle = FlatStyle.Flat;
            BtnMenEmisor.FlatAppearance.BorderSize = 0;
            BtnMenEmisor.BackColor = Color.Transparent;
        }
        private void BtnMasRancho_MouseEnter(object sender, EventArgs e)
        {
            BtnMasRancho.BackColor = ColorTranslator.FromHtml("#cef17b");
            BtnMasRancho.ForeColor = Color.Black;
        }
        private void BtnMasRancho_MouseLeave(object sender, EventArgs e)
        {
            BtnMasRancho.FlatStyle = FlatStyle.Flat;
            BtnMasRancho.FlatAppearance.BorderSize = 0;
            BtnMasRancho.BackColor = Color.Transparent;
            BtnMasRancho.ForeColor = Color.White;
        }
        private void BtnMenosRancho_MouseEnter(object sender, EventArgs e)
        {
            BtnMenosRancho.BackColor = ColorTranslator.FromHtml("#e61421");
        }
        private void BtnMenosRancho_MouseLeave(object sender, EventArgs e)
        {
            BtnMenosRancho.FlatStyle = FlatStyle.Flat;
            BtnMenosRancho.FlatAppearance.BorderSize = 0;
            BtnMenosRancho.BackColor = Color.Transparent;
        }
        private void BtnMasGasto_MouseEnter(object sender, EventArgs e)
        {
            BtnMasGasto.BackColor = ColorTranslator.FromHtml("#cef17b");
            BtnMasGasto.ForeColor = Color.Black;
        }
        private void BtnMasGasto_MouseLeave(object sender, EventArgs e)
        {
            BtnMasGasto.FlatStyle = FlatStyle.Flat;
            BtnMasGasto.FlatAppearance.BorderSize = 0;
            BtnMasGasto.BackColor = Color.Transparent;
            BtnMasGasto.ForeColor = Color.White;
        }
        private void BtnMenGasto_MouseEnter(object sender, EventArgs e)
        {
            BtnMenGasto.BackColor = ColorTranslator.FromHtml("#e61421");
        }
        private void BtnMenGasto_MouseLeave(object sender, EventArgs e)
        {
            BtnMenGasto.FlatStyle = FlatStyle.Flat;
            BtnMenGasto.FlatAppearance.BorderSize = 0;
            BtnMenGasto.BackColor = Color.Transparent;
        }
        private void BtnMasConce_MouseEnter(object sender, EventArgs e)
        {
            BtnMasConce.BackColor = ColorTranslator.FromHtml("#cef17b");
            BtnMasConce.ForeColor = Color.Black;
        }
        private void BtnMasConce_MouseLeave(object sender, EventArgs e)
        {
            BtnMasConce.FlatStyle = FlatStyle.Flat;
            BtnMasConce.FlatAppearance.BorderSize = 0;
            BtnMasConce.BackColor = Color.Transparent;
            BtnMasConce.ForeColor = Color.White;
        }
        private void BtnMenConce_MouseEnter(object sender, EventArgs e)
        {
            BtnMenConce.BackColor = ColorTranslator.FromHtml("#e61421");
        }
        private void BtnMenConce_MouseLeave(object sender, EventArgs e)
        {
            BtnMenConce.FlatStyle = FlatStyle.Flat;
            BtnMenConce.FlatAppearance.BorderSize = 0;
            BtnMenConce.BackColor = Color.Transparent;
        }
        #endregion
    }
}