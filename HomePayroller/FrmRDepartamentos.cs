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
    public partial class FrmRDepartamentos : Form
    {
        public FrmRDepartamentos()
        {
            InitializeComponent();
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

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBDepartamentos BDepartamentos = new FrmBDepartamentos();
            BDepartamentos.Show();
        }
    }
}
