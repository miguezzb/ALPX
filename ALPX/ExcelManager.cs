using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;

namespace ALPX
{
    public static class ExcelManager
    {
        public static Excel.Application excelApp;
        public static Excel.Workbook workbook;
        public static Excel.Worksheet worksheet;

        public static Excel.Application ExcelApp
        {
            get
            {
                if (excelApp == null)
                {
                    InitializeExcelObjects();
                }
                return excelApp;
            }
        }

        public static Excel.Workbook Workbook
        {
            get
            {
                if (workbook == null)
                {
                    InitializeExcelObjects();
                }
                return workbook;
            }
        }

        public static Excel.Worksheet Worksheet
        {
            get
            {
                if (worksheet == null)
                {
                    InitializeExcelObjects();
                }
                return worksheet;
            }
        }

        public static void InitializeExcelObjects()
        {
            excelApp = new Excel.Application();
            excelApp.Visible = false;
            workbook = excelApp.Workbooks.Add(Type.Missing);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[1, 1] = "AÑO";
            worksheet.Cells[1, 2] = "MES";
            worksheet.Cells[1, 3] = "DÍA";
            worksheet.Cells[1, 4] = "NOMBRE EMISOR";
            worksheet.Cells[1, 5] = "SUMA";
            worksheet.Cells[1, 6] = "DCTO. Y CTA. DE PAGO REF";
            worksheet.Cells[1, 7] = "# RANCHO";
            worksheet.Cells[1, 8] = "TIPO DE GASTO";
            worksheet.Cells[1, 9] = "CONCEPTOS";
            worksheet.Cells[1, 10] = "COMBUSTIBLE";
        }

        public static void ReleaseExcelObjects()
        {
            if (workbook != null)
            {
                workbook.Close(false);
                Marshal.ReleaseComObject(workbook);
                workbook = null;
            }
            if (excelApp != null)
            {
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
                excelApp = null;
            }
        }
    }
}
