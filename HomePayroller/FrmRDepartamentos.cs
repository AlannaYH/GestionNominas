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
    public partial class FrmRDepartamentos : Form
    {
        conexion conexion = new conexion();
        public FrmRDepartamentos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty && txtResponsableArea.Text != String.Empty && txtUbicacionFisica.Text != String.Empty)
            {
                string nombre = txtNombre.Text; //nombre.Propiedad;
                string responsableArea = txtResponsableArea.Text;
                string ubicacionFisica = txtUbicacionFisica.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO Departamentos VALUES('" + nombre + "', '" + ubicacionFisica + "', '" + responsableArea + "')", conexion.con);//Primero se pone el query y luego , conexion

                try
                {
                    conexion.con.Open(); //Y esto? eso debe ir arriba, te permite ejecutar un query, y debe ser cerrada cuando termines 
                    cmd.ExecuteNonQuery(); //Usa esto cuando no te importe traer datos, solo insertar o actualizar o eliminar xD
                    conexion.con.Close(); //olvide cerrarla

                    MessageBox.Show("Se ha registrado el departamento " + nombre + " satisfactoriamente.");
                    txtNombre.Text = String.Empty; //Estoy borrando los valores de los textbox;
                    txtUbicacionFisica.Text = String.Empty;
                    txtResponsableArea.Text = String.Empty; //Nombre.eopiadkkajfakljf
                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("Tiene que rellenar los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
