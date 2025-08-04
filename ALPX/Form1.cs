using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ALPX.ExcelManager;
using Excel = Microsoft.Office.Interop.Excel;

namespace ALPX
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]

        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        public static int fila = 2;
        public static int columna = 1;
        private bool hayCambios = false;

        private static readonly string FilePathCmbEmisor = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs", "CmbEmisor.txt");
        private static readonly string FilePathCmbGasto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs", "CmbGasto.txt");
        private static readonly string FilePathCmbConce = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs", "CmbConce.txt");
        private static readonly string FilePathCmbRancho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "docs", "CmbRancho.txt");

        public Form1()
        {
            InitializeComponent();
            InitializeExcelObjects();
            CmbEmisorLoadItems();
            CmbGastoLoadItems();
            CmbConceLoadItems();
            TextChangedElements();
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color bg_color = ColorTranslator.FromHtml("#050505");
            this.BackColor = bg_color;

            this.Opacity = 0.85;

            /* Autocompletado de los ComboBoxes */
            CmbEmisor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbEmisor.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbEmisor.DropDownStyle = ComboBoxStyle.DropDown;
            CmbRancho.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbRancho.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbRancho.DropDownStyle = ComboBoxStyle.DropDown;
            CmbGasto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbGasto.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGasto.DropDownStyle = ComboBoxStyle.DropDown;
            CmbConce.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbConce.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbConce.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambios) // Solo pregunta si hubo cambios
            {
                DialogResult result = MessageBox.Show("Hay cambios no guardados. ¿Deseas guardar antes de salir?", "Guardar cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    GuardarExcel(); // Guarda si el usuario lo decide
                }
                else if (result == DialogResult.Cancel || result == DialogResult.No)
                {
                    CerrarExcel(); // Llamar al método para cerrar Excel cuando se cierra el formulario
                    System.Windows.Forms.Application.Exit(); // Termina la ejecución del programa
                }
            }
            else
            {
                CerrarExcel(); // Llamar al método para cerrar Excel cuando se cierra el formulario
                System.Windows.Forms.Application.Exit(); // Termina la ejecución del programa
            }
        }


        #region [ EXCELOBJECTS ]
        private void InitializeExcelObjects()
        {
            // Aquí las instancias se obtienen desde la clase ExcelManager
            var excelApp = ExcelManager.ExcelApp;
            var workbook = ExcelManager.Workbook;
            var worksheet = ExcelManager.Worksheet;
        }
        #endregion

        #region [ COMBOBOX ]
        private void CmbEmisorLoadItems()
        {
            if (File.Exists(FilePathCmbEmisor))
            {
                var items = File.ReadAllLines(FilePathCmbEmisor);
                CmbEmisor.Items.AddRange(items);
            }
        }
        private void CmbGastoLoadItems()
        {
            if (File.Exists(FilePathCmbGasto))
            {
                var items = File.ReadAllLines(FilePathCmbGasto);
                CmbGasto.Items.AddRange(items);
            }
        }
        private void CmbConceLoadItems()
        {
            if (File.Exists(FilePathCmbConce))
            {
                var items = File.ReadAllLines(FilePathCmbConce);
                CmbConce.Items.AddRange(items);
            }
        }
        private void CmbRanchoLoadItems()
        {
            if (File.Exists(FilePathCmbRancho))
            {
                var items = File.ReadAllLines(FilePathCmbRancho);
                CmbRancho.Items.AddRange(items);
            }
        }
        private void BtnMasEmisor_Click(object sender, EventArgs e)
        {
            var newItem = CmbEmisor.Text.Trim();
            if (!string.IsNullOrEmpty(newItem) && !CmbEmisor.Items.Contains(newItem))
            {
                CmbEmisor.Items.Add(newItem);
                SaveItemsCmbEmisor();
            }
        }
        private void BtnMasGasto_Click(object sender, EventArgs e)
        {
            var newItem2 = CmbGasto.Text.Trim();
            if (!string.IsNullOrEmpty(newItem2) && !CmbGasto.Items.Contains(newItem2))
            {
                CmbGasto.Items.Add(newItem2);
                SaveItemsCmbGasto();
            }
        }
        private void BtnMasConce_Click(object sender, EventArgs e)
        {
            var newItem3 = CmbConce.Text.Trim();
            if (!string.IsNullOrEmpty(newItem3) && !CmbConce.Items.Contains(newItem3))
            {
                CmbConce.Items.Add(newItem3);
                SaveItemsCmbConce();
            }
        }
        private void BtnMasRancho_Click(object sender, EventArgs e)
        {
            var newItem4 = CmbRancho.Text.Trim();
            if (!string.IsNullOrEmpty(newItem4) && !CmbRancho.Items.Contains(newItem4))
            {
                CmbRancho.Items.Add(newItem4);
                SaveItemsCmbRancho();
            }
        }
        private void SaveItemsCmbEmisor()
        {
            var items = CmbEmisor.Items.Cast<string>().ToArray();
            File.WriteAllLines(FilePathCmbEmisor, items);
        }
        private void SaveItemsCmbGasto()
        {
            var items2 = CmbGasto.Items.Cast<string>().ToArray();
            File.WriteAllLines(FilePathCmbGasto, items2);
        }
        private void SaveItemsCmbConce()
        {
            var items3 = CmbConce.Items.Cast<string>().ToArray();
            File.WriteAllLines(FilePathCmbConce, items3);
        }
        private void SaveItemsCmbRancho()
        {
            var items = CmbRancho.Items.Cast<string>().ToArray();
            File.WriteAllLines(FilePathCmbEmisor, items);
        }
        private void BtnMenEmisor_Click(object sender, EventArgs e)
        {
            var selectedItem = CmbEmisor.SelectedItem;
            if (selectedItem != null)
            {
                CmbEmisor.Items.Remove(selectedItem);
                SaveItemsCmbEmisor();
            }
        }
        private void BtnMenGasto_Click(object sender, EventArgs e)
        {
            var selectedItem2 = CmbGasto.SelectedItem;
            if (selectedItem2 != null)
            {
                CmbGasto.Items.Remove(selectedItem2);
                CmbGasto.Text = "";
                SaveItemsCmbGasto();
            }
        }
        private void BtnMenConce_Click(object sender, EventArgs e)
        {
            var selectedItem3 = CmbConce.SelectedItem;
            if (selectedItem3 != null)
            {
                CmbConce.Items.Remove(selectedItem3);
                CmbConce.Text = "";
                SaveItemsCmbConce();
            }
        }
        private void BtnMenosRancho_Click(object sender, EventArgs e)
        {
            var selectedItem4 = CmbRancho.SelectedItem;
            if (selectedItem4 != null)
            {
                CmbRancho.Items.Remove(selectedItem4);
                CmbRancho.Text = "";
                SaveItemsCmbRancho();
            }
        }
        #endregion

        #region [ GUARDAR/CERRAR EXCEL ] 
        private void GuardarExcel()
        {
            try
            {
                // Solo intenta guardar si hubo cambios
                if (hayCambios && excelApp != null && workbook != null)
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = "programaALPX.xlsx";
                    string filePath = System.IO.Path.Combine(desktopPath, fileName);

                    // Guarda el archivo en el escritorio
                    BtnGuardar_Click(this, EventArgs.Empty);
                    workbook.SaveAs(filePath);

                    // Cierra el libro de trabajo y libera recursos
                    workbook.Close(true);
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;

                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                    excelApp = null;

                    MessageBox.Show("Archivo guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (worksheet != null)
                {
                    Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show($"Error liberando recursos de Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Recolección de basura para liberar objetos COM de Excel
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Verifica si aún existe la instancia de Excel y cierra solo esa instancia
                if (excelApp != null)
                {
                    try
                    {
                        int excelProcessId = 0;
                        GetWindowThreadProcessId(new IntPtr(excelApp.Hwnd), out excelProcessId);

                        if (excelProcessId != 0)
                        {
                            Process excelProcess = Process.GetProcessById(excelProcessId);
                            if (excelProcess != null && !excelProcess.HasExited)
                            {
                                excelProcess.Kill();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error cerrando la instancia de Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CerrarExcel()
        {
            try
            {
                // Liberar recursos de Excel
                if (worksheet != null)
                {
                    Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }

                if (workbook != null)
                {
                    workbook.Close(false); // Cierra el workbook sin guardar los cambios
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }

                if (excelApp != null)
                {
                    excelApp.Quit(); // Cierra la aplicación de Excel
                    Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show($"Error liberando recursos de Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Recolección de basura para liberar objetos COM de Excel
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Verifica si aún existe la instancia de Excel y cierra solo esa instancia
                if (excelApp != null)
                {
                    try
                    {
                        int excelProcessId = 0;
                        GetWindowThreadProcessId(new IntPtr(excelApp.Hwnd), out excelProcessId);

                        if (excelProcessId != 0)
                        {
                            Process excelProcess = Process.GetProcessById(excelProcessId);
                            if (excelProcess != null && !excelProcess.HasExited)
                            {
                                excelProcess.Kill();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error cerrando la instancia de Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region [ BTN GUARDAR/NUEVO ]
        private void TxtSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es un número (dígitos del 0 al 9) ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número o tecla de retroceso, cancelar el evento para bloquear la entrada
                e.Handled = true;
            }
        }
        private void TxtDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter no es un número (dígitos del 0 al 9) ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número o tecla de retroceso, cancelar el evento para bloquear la entrada
                e.Handled = true;
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el valor del DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;
            string CmbEmisorText = "";
            string CmbGastoText = "";
            string CmbConceText = "";
            string CmbRanchoText = "";

            // Obtener el valor de CmbEmisor
            if (CmbEmisor.SelectedItem != null)
            {
                CmbEmisorText = CmbEmisor.SelectedItem.ToString();
            }
            else
            {
                CmbEmisorText = CmbEmisor.Text;
            }

            // Obtener el valor de CmbRancho
            if (CmbRancho.SelectedItem != null)
            {
                CmbRanchoText = CmbRancho.SelectedItem.ToString();
            }
            else
            {
                CmbRanchoText = CmbRancho.Text;
            }

            // Obtener el valor de CmbGasto
            if (CmbGasto.SelectedItem != null)
            {
                CmbGastoText = CmbGasto.SelectedItem.ToString();
            }
            else
            {
                CmbGastoText = CmbGasto.Text;
            }

            // Obtener el valor de CmbConce
            if (CmbConce.SelectedItem != null)
            {
                CmbConceText = CmbConce.SelectedItem.ToString();
            }
            else
            {
                CmbConceText = CmbConce.Text;
            }

            decimal? sumaValue = null;
            try
            {
                // Intenta convertir el texto a decimal utilizando la cultura específica
                if (!string.IsNullOrEmpty(TxtSuma.Text))
                {
                    sumaValue = Convert.ToDecimal(TxtSuma.Text, new CultureInfo("es-ES"));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, introduce un número válido. Error: " + ex.ToString(), "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Error: " + ex.ToString(), "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Crear e inicializar un array de info sacada de las cajas de texto
            object[] datos_array = new object[] {
                year,
                month,
                day,
                CmbEmisorText,
                sumaValue,
                !string.IsNullOrEmpty(TxtDocto.Text) ? Convert.ToInt32(TxtDocto.Text) : (int?)null,
                CmbRanchoText,
                CmbGastoText,
                CmbConceText,
                TxtCombustible.Text
            };

            int valor_vacio = 0;

            for (int i = 0; i < datos_array.Length; i++)
            {
                if (string.IsNullOrEmpty(datos_array[i]?.ToString().Trim()))
                {
                    valor_vacio += 1;
                    if (valor_vacio == 7)
                    {
                        MessageBox.Show("Por favor ingrese algún dato en las celdas", "Cajas vacías", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Excel.Range cell = (Excel.Range)worksheet.Cells[fila, columna]; // Obtener el rango de la celda actual

                    if (columna == 5 && sumaValue.HasValue) // Si es la columna 5 y sumaValue tiene un valor, aplica formato de moneda
                    {
                        cell.NumberFormat = "$#,##0.00"; // Formato de moneda
                    }

                    cell.Value2 = datos_array[i]; // Asignar el valor a la celda

                    columna++; // Incrementar el contador de columna
                }
            }

            LimpiarTodo();
            fila++;
            columna = 1;
        }
        #endregion

        #region [ BTN LIMPIAR ]
        private void BtnLimpia_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        private void LimpiarTodo()
        {
            dateTimePicker1.Value = DateTime.Now;
            CmbEmisor.SelectedIndex = -1;
            CmbEmisor.Text = "";
            TxtSuma.Clear();
            TxtDocto.Clear();
            CmbRancho.SelectedIndex = -1;
            CmbRancho.Text = "";
            CmbGasto.SelectedIndex = -1;
            CmbGasto.Text = "";
            CmbConce.SelectedIndex = -1;
            CmbConce.Text = "";
            TxtCombustible.Clear();
        }
        #endregion

        #region [ BTN VER DATOS ]
        private void BtnVerDatos_Click(object sender, EventArgs e)
        {
            excelApp.Visible = true;
        }
        private void BtnCargaArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Seleccionar archivo de Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Abrir el archivo de Excel
                    excelApp = new Excel.Application();
                    workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                    worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Primera hoja

                    // Encontrar la última fila con datos
                    Excel.Range lastCell = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                    fila = lastCell.Row + 1;
                    columna = 1;

                    MessageBox.Show("Archivo cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region [ BTN SIGUIENTE ]
        private void BtnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.Show();

            form2.FormClosed += (s, args) => this.Close();
        }
        #endregion


        #region / ANIMACIONES /
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

        #region  / TEXTCHANGED /
        private void CambiosRealizados_Event(object sender, EventArgs e)
        {
            hayCambios = true;
        }
        private void TextChangedElements()
        {
            // Asignamos los eventos a las cajas de texto
            TxtSuma.TextChanged += new EventHandler(CambiosRealizados_Event);
            CmbEmisor.SelectedIndexChanged += new EventHandler(CambiosRealizados_Event);
            CmbRancho.SelectedIndexChanged += new EventHandler(CambiosRealizados_Event);

            // Asignamos el evento click a los botones
            BtnGuardar.Click += new EventHandler(CambiosRealizados_Event);
            BtnVerDatos.Click += new EventHandler(CambiosRealizados_Event);
            BtnCargaArchivo.Click += new EventHandler(CambiosRealizados_Event);
        }
        #endregion
    }
}