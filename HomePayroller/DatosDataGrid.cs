using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HomePayroller
{
    public class DatosDataGrid
    {
        public DataTable tablaDatos(string query)
        {
            DataTable table = new DataTable();

            try
            {
                conexion conexion = new conexion();
                SqlDataAdapter dataAdapter;

                // Create a new data adapter based on the specified query.
                conexion.con.Open();
                dataAdapter = new SqlDataAdapter(query, conexion.con);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                conexion.con.Close();
                // Resize the DataGridView columns to fit the newly loaded content.
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

            return table;
        }
    }
}
