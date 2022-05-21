using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {

        #region Variables

        public clsBuscaArchivos buscaArchivos = new clsBuscaArchivos();
        public clsDatosExcel datosExcel = new clsDatosExcel();
        public IEnumerable<System.IO.FileInfo> lista;
        public IEnumerable<System.IO.FileInfo> excel;
        public IEnumerable<System.IO.FileInfo> otros;
        bool accion = true;

        #endregion

        public Form1()
        {
            InitializeComponent();

            lista = buscaArchivos.BuscarArchivos();
            ordenar();
            comboBox1.SelectedIndex = 0;
        }

        private void EscribirLista()
        {
            lBlArchivos.Items.Clear();
            int arch = 1;
            foreach(var datos in excel)
            {
                lBlArchivos.Items.Add(datos.Name);
                if (accion)
                {
                    datosExcel.LeerDatos(datos.FullName);
                    datosExcel.EscribirDatos(arch.ToString());
                    arch++;
                }
            }
        }

        private void ordenar()
        {
            excel = buscaArchivos.BuscarExcel(buscaArchivos.process);
            otros = buscaArchivos.BuscarExcel(buscaArchivos.notApplicable);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                EscribirLista();
                accion = false;
            }
            else
            {
                EscribirOtros();
            }
        }

        private void EscribirOtros()
        {
            lBlArchivos.Items.Clear();
            foreach (var datos in otros)
            {
                lBlArchivos.Items.Add(datos.Name);
            }
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            string Direccion = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Direccion += @"\Master";
            System.Diagnostics.Process.Start(Direccion);
        }
    }
}
