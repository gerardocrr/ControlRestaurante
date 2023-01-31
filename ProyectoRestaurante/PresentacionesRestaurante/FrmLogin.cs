using System;
using System.Windows.Forms;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmLogin : Form
    {
        private RestauranteManejador _restauranteManejador;
        public FrmLogin()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            txtContrasena.PasswordChar = '*';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmModalRegistroAdmin modal = new FrmModalRegistroAdmin();
            modal.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_restauranteManejador.ExisteAdmin(txtUsuario.Text, txtContrasena.Text))
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();
                menu.btnPlatillosProhibido.Visible = false;
                menu.btnCategoriasProhibido.Visible = false;
                Hide();
            }
            else if (_restauranteManejador.ExisteUsuario(txtUsuario.Text, txtContrasena.Text))
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();
                menu.btnPlatillos.Visible = false;
                menu.btnCategorias.Visible = false;
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
            }
        }

        private void checkbxContrasena_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkbxContrasena.Checked == true)
            {
                txtContrasena.PasswordChar = '*';
            }
            else
            {
                txtContrasena.PasswordChar = '\0';
            }
        }
    }
}
