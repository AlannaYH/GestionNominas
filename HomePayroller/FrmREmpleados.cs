using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomePayroller
{
    public partial class FrmREmpleados : Form
    {
        private SqlConnection oCon = null;
        public string nombres = "";
        public string Apellidos = "";
        public string cedula = "";
        public string direccion = "";
        public string telefono = "";
        public string nacionalidad = "";
        public string telefonoe = "";

        public FrmREmpleados()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBEmpleados BEmpleados = new FrmBEmpleados();
            BEmpleados.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRPuestos RDepartamentos = new FrmRPuestos();
            RDepartamentos.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
