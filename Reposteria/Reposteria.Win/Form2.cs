using Reposteria.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reposteria.Win
{
    public partial class Form2 : Form
    {
        ReporteVentasPorProductoBL _reporteVentasPorProductosBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentasPorProductosBL = new ReporteVentasPorProductoBL();

            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
         private void RefrescarDatos()
        {
            var listadeVentasPorProducto = _reporteVentasPorProductosBL.ObtenerVentasPorProducto();
            listadeVentasPorProductoBindingSource.DataSource = listadeVentasPorProducto;
            listadeVentasPorProductoBindingSource.ResetBindings(false);
        }
    }
}
