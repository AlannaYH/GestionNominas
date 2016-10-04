using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePayroller
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmREmpleados REmpleados = new FrmREmpleados();
            REmpleados.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBEmpleados BEmpleados = new FrmBEmpleados();
            BEmpleados.Show();

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRDepartamentos RDepartamentos = new FrmRDepartamentos();
            RDepartamentos.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBDepartamentos BDepartamentos = new FrmBDepartamentos();
            BDepartamentos.Show();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBPuestos BPuestos = new FrmBPuestos();
            BPuestos.Show();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRPuestos RPuestos = new FrmRPuestos();
            RPuestos.Show();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRIngresos RIngresos = new FrmRIngresos();
            RIngresos.Show();
        }

        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmBIngresos BIngresos = new FrmBIngresos();
            BIngresos.Show();
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmRDeducciones RDeducciones = new FrmRDeducciones();
            RDeducciones.Show();
        }

        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmBDeducciones BDeducciones = new FrmBDeducciones();
            BDeducciones.Show();
        }

        private void registrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmRTransacciones RTransacciones = new FrmRTransacciones();
            RTransacciones.Show();
        }

        private void buscarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmBTransacciones BTransacciones = new FrmBTransacciones();
            BTransacciones.Show();

        }
    }
}
