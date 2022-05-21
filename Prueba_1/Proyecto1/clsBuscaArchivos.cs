using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class clsBuscaArchivos
    {
        private string Direccion;

        public string process;
        public string notApplicable;
        private string DireccionGeneral;
        IEnumerable<System.IO.FileInfo> lista;

        public clsBuscaArchivos()
        {

        }

        public IEnumerable<System.IO.FileInfo> BuscarArchivos()
        {
            Direccion = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Direccion += @"\Archivos";

            DireccionGeneral = Direccion;

            if (!Directory.Exists(Direccion))
            {
                Directory.CreateDirectory(Direccion);
            }

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Direccion);

            lista = dir.GetFiles("*.*");
            MoverArchivos();
            return lista;
        }

        public IEnumerable<System.IO.FileInfo> BuscarExcel(string Direccion)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Direccion);
            lista = dir.GetFiles("*.*");
            return lista;

        }

        private void MoverArchivos()
        {
            process = CrearCarpeta("Process");
            notApplicable = CrearCarpeta("notApplicable");

            foreach (var item in lista)
            {
                var fileName = item.Name;
                var originFile = Path.Combine(DireccionGeneral, fileName);

                if (item.Extension.Contains("xls"))
                {
                    var destFile = Path.Combine(process, fileName);
                    File.Move(originFile, destFile);
                }
                else
                {
                    var destFile = Path.Combine(notApplicable, fileName);
                    File.Move(originFile, destFile);
                }
            }
        }

        private string CrearCarpeta(string carpeta)
        {
            Direccion = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            Direccion += $@"\{carpeta}";

            if (!Directory.Exists(Direccion))
            {
                Directory.CreateDirectory(Direccion);
            }

            return Direccion;
        }
    }
}
