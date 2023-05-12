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

        private void btn_RegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarClienteForm = new RegistrarCliente();
            registrarClienteForm.ShowDialog();
        }

        private void btn_RegistrarLibro_Click(object sender, EventArgs e)
        {
            RegistrarLibro registrarLibro = new RegistrarLibro(this);
            registrarLibro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}