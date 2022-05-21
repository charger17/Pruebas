using ExcelDataReader;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class clsDatosExcel
    {
        public DataSet result = new DataSet();
        private string Direccion;
        public clsDatosExcel()
        {

        }

        public void LeerDatos(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    result = reader.AsDataSet();

                    //DataTable table = result.Tables[0];
                    //DataRow row = table.Rows[0];
                    //string cell = row[0].ToString();
                }
            }
        }

        public void EscribirDatos(string numArchivo)
        {
            
            Direccion = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Direccion += @"\Master";

            if (!Directory.Exists(Direccion))
            {
                Directory.CreateDirectory(Direccion);
            }
            else
            {
                
            }
            Direccion += @"\masterl.xlsx";

            existe();

            SLDocument sl = new SLDocument(Direccion);

            for (int i = 0; i < result.Tables.Count; i++)
            {
                var nombre = $"Hola_{(i+1)}Archivo_{numArchivo}";
                if (sl.AddWorksheet(nombre))
                {

                    for (int j = 0; j < result.Tables[i].Columns.Count; j++)
                    {
                        for (int k = 0; k < result.Tables[i].Rows.Count; k++)
                        {
                            string d = result.Tables[i].Rows[k][j].ToString();
                            sl.SetCellValue((k + 1), (j + 1), result.Tables[i].Rows[k][j].ToString());
                        }
                    }
                }
                //sl.MoveWorksheet($"Hoja{i}_{nombreHoja}", 1);
            }


            sl.Save();
        }


        private void existe()
        {
            Direccion = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Direccion += @"\Master";

            Direccion += @"\masterl.xlsx";

            if (!File.Exists(Direccion))
            {

                SLDocument sl = new SLDocument();
                sl.SaveAs(Direccion);
            }
        }

    }
}
