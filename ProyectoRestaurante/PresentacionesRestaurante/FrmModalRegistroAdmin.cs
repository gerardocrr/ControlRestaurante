using System;
using System.Windows.Forms;
using LogicaNecocioRestaurante;
using EntidadesRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmModalRegistroAdmin : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Administradores _admin;
        public FrmModalRegistroAdmin()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _admin = new Administradores();
            txtContrasena.PasswordChar = '*';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();            
        }
        private void GuardarContactos()
        {
            _admin.Idadmin = "null";
            _admin.Usuario = txtUsuario.Text;
            _admin.Contrasena = txtContrasena.Text;
            _restauranteManejador.GuardarAdmin(_admin);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            GuardarContactos();
            Close();
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
