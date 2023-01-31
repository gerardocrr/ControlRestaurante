using System;
using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmModalCategoria : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Categorias _categorias;
        private string banderaGuardar;
        private string idcategoria;
        public FrmModalCategoria()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _categorias = new Categorias();
            banderaGuardar = "guardar";
        }
        public FrmModalCategoria(Categorias categoria)
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _categorias = new Categorias();
            idcategoria = categoria.Idcategoria;
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
            banderaGuardar = "actualizar";

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarCategoria();
                Close();
            }
            else
            {
                ActualizarCategoria();
                Close();
            }
        }
        private void GuardarCategoria()
        {
            _categorias.Idcategoria = "null";
            _categorias.Nombre = txtNombre.Text;
            _categorias.Descripcion = txtDescripcion.Text;
            var valida = _restauranteManejador.ValidarCategoria(_categorias);
            if (valida.Item1)
            {
                _restauranteManejador.GuardarCategoria(_categorias);
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarCategoria()
        {
            _restauranteManejador.ActualizarCategoria(new Categorias
            {
                Idcategoria = idcategoria,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
            });
        }
    }
}
