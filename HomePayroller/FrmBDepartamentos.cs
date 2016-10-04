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
    public partial class FrmBDepartamentos : Form
    {
        DatosDataGrid ddg = new DatosDataGrid();
        private string atributo = String.Empty;
        public FrmBDepartamentos()
        {
            InitializeComponent();
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            string query;

            if (txtTextoABuscar.Text == String.Empty || cbxCriterio.SelectedItem == null) 
            {
                query = "SELECT * FROM Departamentos";
                dgvDepartamentos.DataSource = ddg.tablaDatos(query);
            }
            else
            {
                int i = 0;
                bool result = int.TryParse(txtTextoABuscar.Text, out i); //i now = 108
                if (!result)
                {
                    query = "SELECT * FROM Departamentos WHERE " + atributo + " LIKE '%" + txtTextoABuscar.Text + "%'";
                }
                    
                else
                {
                    query = "SELECT * FROM Departamentos WHERE " + atributo + " = " + txtTextoABuscar.Text;
                }

                dgvDepartamentos.DataSource = ddg.tablaDatos(query);
            }
        }

        private void cbxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCriterio.SelectedItem.ToString() == "ID")
            {
                atributo = "Id_Departamento";
            }
            else if(cbxCriterio.SelectedItem.ToString() == "Nombre")
            {
                atributo = "Nombre_Departamento";
            }
            else if(cbxCriterio.SelectedItem.ToString() == "Ubicación")
            {
                atributo = "Ubicacion_Departamento";
            }
            else if(cbxCriterio.SelectedItem.ToString() == "Responsable del Área")
            {
                atributo = "ResponsableArea_Departamento";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
