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

namespace Biblioteca
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-K226KK4\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Usuarios (nombre, apellidos, direccion, telefono, email) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", textBox_Nombre.Text);
                    command.Parameters.AddWithValue("@Apellido", textBox_Apellido.Text);
                    command.Parameters.AddWithValue("@Direccion", textBox_Direccion.Text);
                    command.Parameters.AddWithValue("@Telefono", textBox_Telefono.Text);
                    command.Parameters.AddWithValue("@Email", textBox_Email.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario registrado exitosamente.");
            this.Close();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
