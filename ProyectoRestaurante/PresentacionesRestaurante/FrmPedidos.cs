using System;
using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmPedidos : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Pedidos _pedidos;
        public FrmPedidos()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _pedidos = new Pedidos();
            CargarPedidos("");
            dtgPedidos.Columns["IdPedido"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmModalPedidos mpedido = new FrmModalPedidos();
            mpedido.ShowDialog();
            CargarPedidos("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPedido();
            CargarPedidos("");
        }

        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            CargarPedidos(txtBuscar.Text);
        }
        private void CargarPedidos(string filtro)
        {
            dtgPedidos.DataSource = _restauranteManejador.ObtenerPedidos(filtro);
        }        

        private void dtgPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _pedidos.Idpedido = dtgPedidos.CurrentRow.Cells["idpedido"].Value.ToString();
            _pedidos.NombreCliente = dtgPedidos.CurrentRow.Cells["nombreCliente"].Value.ToString();
            _pedidos.PrecioTotal = dtgPedidos.CurrentRow.Cells["precioTotal"].Value.ToString();            
            _pedidos.Platillos = dtgPedidos.CurrentRow.Cells["platillos"].Value.ToString();
            FrmModalPedidos mpedido = new FrmModalPedidos(_pedidos);
            mpedido.ShowDialog();
            CargarPedidos("");
        }
        private void EliminarPedido()
        {
            if (MessageBox.Show("¿Desea eliminar el pedido seleccionado?", "Eliminar pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var pedido = dtgPedidos.CurrentRow.Cells["idpedido"].Value.ToString();
                _restauranteManejador.EliminarPedido(pedido);
            }
        }
    }
}
