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
    public partial class FrmREmpleados : Form
    {
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
            FrmRDepartamentos RDepartamentos = new FrmRDepartamentos();
            RDepartamentos.Show();
        }
    }
}
