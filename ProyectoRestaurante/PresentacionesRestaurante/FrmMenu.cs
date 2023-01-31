using System;
using System.Windows.Forms;

namespace PresentacionesRestaurante
{
    public partial class FrmMenu : Form
    {
        FrmLogin login;
        public FrmMenu()
        {
            InitializeComponent();
            login = new FrmLogin();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.Show();
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            FrmPlatillos platillos = new FrmPlatillos();
            platillos.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new FrmCategorias();
            categorias.Show();
        }

        private void btnPlatillosProhibido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo el administrador puede ingresar a este menu.\n\nCierre sesión e ingrese como administrador.", "Error");
        }

        private void btnCategoriasProhibido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo el administrador puede ingresar a este menu.\n\nCierre sesión e ingrese como administrador.", "Error");                        
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            login.Show();

        }
    }
}
