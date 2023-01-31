using System;
using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmCategorias : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Categorias _categorias;
        public FrmCategorias()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _categorias = new Categorias();
            CargarCategorias("");
            dtgCategorias.Columns["IdCategoria"].Visible = false;
        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModalCategoria mcategoria = new FrmModalCategoria();
            mcategoria.ShowDialog();
            CargarCategorias("");
        }

        private void dtgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _categorias.Idcategoria = dtgCategorias.CurrentRow.Cells["idcategoria"].Value.ToString();
            _categorias.Nombre = dtgCategorias.CurrentRow.Cells["nombre"].Value.ToString();
            _categorias.Descripcion = dtgCategorias.CurrentRow.Cells["descripcion"].Value.ToString();
            FrmModalCategoria mcategoria = new FrmModalCategoria(_categorias);
            mcategoria.ShowDialog();
            CargarCategorias("");
        }
        private void EliminarCategoria()
        {
            if (MessageBox.Show("¿Desea eliminar la categoria seleccionada?", "Eliminar categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoria = (dtgCategorias.CurrentRow.Cells["idcategoria"].Value.ToString());
                _restauranteManejador.EliminarCategoria(categoria);
            }
        }

        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            CargarCategorias(txtBuscar.Text);
        }
        private void CargarCategorias(string filtro)
        {
            dtgCategorias.DataSource = _restauranteManejador.ObtenerCategorias(filtro);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
            CargarCategorias("");
        }
    }
}
