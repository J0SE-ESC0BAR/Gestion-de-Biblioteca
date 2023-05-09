using System.Data.SqlClient;
using System.Data;
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
            RegistrarLibro registrarLibroForm = new RegistrarLibro();
            registrarLibroForm.ShowDialog();
        }
    }

}