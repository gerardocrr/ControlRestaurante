using System;
using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmPlatillos : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Platillos _platillos;
        public FrmPlatillos()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _platillos = new Platillos();
            CargarPlatillos("");
            dtgPlatillos.Columns["IdPlatillo"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModalPlatillo mplatillo = new FrmModalPlatillo();
            mplatillo.ShowDialog();
            CargarPlatillos("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarPlatillos(string filtro)
        {
            dtgPlatillos.DataSource = _restauranteManejador.ObtenerPlatillos(filtro);
            dtgPlatillos.AutoResizeColumns();
        }

        private void dtgPlatillos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _platillos.Idplatillo = dtgPlatillos.CurrentRow.Cells["idplatillo"].Value.ToString();
            _platillos.Nombre = dtgPlatillos.CurrentRow.Cells["nombre"].Value.ToString();
            _platillos.Precio = dtgPlatillos.CurrentRow.Cells["precio"].Value.ToString();
            _platillos.Descripcion = dtgPlatillos.CurrentRow.Cells["descripcion"].Value.ToString();
            _platillos.Categoria = dtgPlatillos.CurrentRow.Cells["categoria"].Value.ToString();
            FrmModalPlatillo mplatillo = new FrmModalPlatillo(_platillos);
            mplatillo.ShowDialog();
            CargarPlatillos("");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPlatillo();
            CargarPlatillos("");
        }

        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            CargarPlatillos(txtBuscar.Text);
        }
        private void EliminarPlatillo()
        {
            if (MessageBox.Show("¿Desea eliminar el platillo seleccionado?", "Eliminar platillo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var platillo = dtgPlatillos.CurrentRow.Cells["idplatillo"].Value.ToString();
                _restauranteManejador.EliminarPlatillo(platillo);
            }
        }
    }
}
