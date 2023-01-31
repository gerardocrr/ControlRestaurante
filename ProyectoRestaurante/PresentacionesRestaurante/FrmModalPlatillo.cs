using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;


namespace PresentacionesRestaurante
{
    public partial class FrmModalPlatillo : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Platillos _platillos;
        private string banderaGuardar;
        private string idplatillo;       
        public FrmModalPlatillo()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _platillos = new Platillos();
            _restauranteManejador.LlenarCombo(cbxCategoria);
            banderaGuardar = "guardar";            

        }
        public FrmModalPlatillo(Platillos platillo)
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _platillos = new Platillos();
            idplatillo = platillo.Idplatillo;
            txtNombre.Text = platillo.Nombre;
            txtPrecio.Text = platillo.Precio;
            txtDescripcion.Text = platillo.Descripcion;
            cbxCategoria.Text = platillo.Categoria;
            _restauranteManejador.LlenarCombo(cbxCategoria);
            banderaGuardar = "actualizar";
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarPlatillo();
                Close();
            }
            else
            {
                ActualizarPlatillo();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void GuardarPlatillo()
        {
            _platillos.Idplatillo = "null";
            _platillos.Nombre = txtNombre.Text;
            _platillos.Precio = txtPrecio.Text;
            _platillos.Descripcion = txtDescripcion.Text;
            _platillos.Categoria = cbxCategoria.Text;
            var valida = _restauranteManejador.ValidarPlatillo(_platillos);
            if (valida.Item1)
            {
                _restauranteManejador.GuardarPlatillo(_platillos);
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarPlatillo()
        {
            _restauranteManejador.ActualizarPlatillo(new Platillos
            {
                Idplatillo = idplatillo,
                Nombre = txtNombre.Text,
                Precio = txtPrecio.Text,
                Descripcion = txtDescripcion.Text,
                Categoria = cbxCategoria.Text
            });
        }        
    }
}
