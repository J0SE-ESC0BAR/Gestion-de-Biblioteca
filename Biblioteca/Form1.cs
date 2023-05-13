using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mdificarLibro_Click(object sender, EventArgs e)
        {
            Libro mdificarLibro = new Libro(this);
            mdificarLibro.Show();
        }

        private void btn_mdificarUsuario_Click(object sender, EventArgs e)
        {
            Usuario mdificarUsuario = new Usuario();
            mdificarUsuario.ShowDialog();
        }
    }

}