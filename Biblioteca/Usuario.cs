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
    public partial class Usuario : Form
    {
        private string connectionString = "Server=DESKTOP-K226KK4\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;";

        public Usuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (radAgregar.Checked)
            {
                AgregarUsuario();
            }
            else if (radModificar.Checked)
            {
                ModificarUsuario();
            }
            else if (radEliminar.Checked)
            {
                EliminarUsuario();
            }
        }

        private void AgregarUsuario()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Usuarios (nombre, apellidos, direccion, telefono, email) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario registrado exitosamente.");
        }

        private void ModificarUsuario()
        {
            if (!int.TryParse(txtId.Text, out int id_usuario))
            {
                MessageBox.Show("Por favor, ingrese un número de ID válido.");
                txtId.Clear();
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Usuarios SET nombre=@Nombre, apellidos=@Apellido, direccion=@Direccion, telefono=@Telefono, email=@Email WHERE id_usuario=@id_usuario", connection))
                {
                    command.Parameters.AddWithValue("@id_usuario", txtId.Text);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario modificado exitosamente.");
        }

        private void EliminarUsuario()
        {
            if (!int.TryParse(txtId.Text, out int id_usuario))
            {
                MessageBox.Show("Por favor, ingrese un número de ID válido.");
                txtId.Clear();
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Usuarios WHERE id_usuario=@id_usuario", connection))
                {
                    command.Parameters.AddWithValue("@id_usuario", txtId.Text);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario eliminado exitosamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtEnabled();
            txtId.Focus();
            txtId.Clear();
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtDisable();
            txtId.Enabled = true;
            txtId.Focus();
            txtId.Clear();
        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            txtEnabled();
            txtId.Enabled = false;
            txtNombre.Focus();
            txtId.Clear();
        }
        private void txtDisable()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
        }
        private void txtEnabled()
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
        }
    }
}
