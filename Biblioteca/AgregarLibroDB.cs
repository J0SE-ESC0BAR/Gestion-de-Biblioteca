using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AgregarLibroDB
    {
        //Direccion de la coneccion a la base de datos
        private string connectionString = 
            "Date Source=localhost; Initial Catalog=Biblioteca;User=sa;Password=123456";
        public void Add(string Cliente)
        {
            string query = "Insert into venta(cliente,fecha)+" +
                " values(@cliente,@fecha)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Sirve para ejecutar un nuevo query
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@cliente",Cliente);
                command.Parameters.AddWithValue("@fecha", DateTime.Now);
                //Abre la coneccion
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            } 
        }

    }
}
