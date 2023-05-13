using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Biblioteca
{
    public partial class Libro : Form
    {
        private Form1 form1;
        public Libro(Form1 form1)
        {
            InitializeComponent();
            InitializeDateTimePicker();
            this.form1 = form1;
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker_AñoPublicacion.Format = DateTimePickerFormat.Custom;
            dateTimePicker_AñoPublicacion.CustomFormat = "yyyy";
            dateTimePicker_AñoPublicacion.ShowUpDown = true;
            dateTimePicker_AñoPublicacion.ValueChanged += DateTimePicker1_ValueChanged;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            if (dtp != null)
            {
                dtp.Value = new DateTime(dtp.Value.Year, 1, 1);
            }
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-K226KK4\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Libros (titulo, autor, editorial, año_publicacion, genero, num_paginas) VALUES (@Titulo, @Autor, @Editorial, @AñoPublicacion, @Genero, @Paginas)", connection))
                {
                    command.Parameters.AddWithValue("@Titulo", textBox_Titulo.Text);
                    command.Parameters.AddWithValue("@Autor", textBox_Autor.Text);
                    command.Parameters.AddWithValue("@Editorial", textBox_Editorial.Text);
                    command.Parameters.AddWithValue("@AñoPublicacion", dateTimePicker_AñoPublicacion.Value);
                    command.Parameters.AddWithValue("@Genero", textBox_Genero.Text);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Libro registrado exitosamente.");
            this.Close();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
