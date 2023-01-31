using System;
using System.Windows.Forms;
using EntidadesRestaurante;
using LogicaNecocioRestaurante;

namespace PresentacionesRestaurante
{
    public partial class FrmModalPedidos : Form
    {
        private RestauranteManejador _restauranteManejador;
        private Pedidos _pedidos;
        private string banderaGuardar;
        private string idpedido;
        private DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        public FrmModalPedidos()
        {
            InitializeComponent();
            _restauranteManejador = new RestauranteManejador();
            _pedidos = new Pedidos();
            banderaGuardar = "guardar";
            CargarPlatillos("");
            buttonColumn.Name = "btnAgregar";
            buttonColumn.Text = "+";
            buttonColumn.HeaderText = "Agregar";
            buttonColumn.UseColumnTextForButtonValue = true;
            dtgPlatillos.Columns.Add(buttonColumn);
        }
        public FrmModalPedidos(Pedidos pedido)
        {
            InitializeComponent();            
            _restauranteManejador = new RestauranteManejador();
            _pedidos = new Pedidos();            
            idpedido = pedido.Idpedido;
            txtNombreCliente.Text = pedido.NombreCliente;
            txtPedido.Text = pedido.Platillos;
            lblTotal.Text = pedido.PrecioTotal;
            CargarPlatillos("");
            buttonColumn.Name = "btnAgregar";
            buttonColumn.Text = "+";
            buttonColumn.HeaderText = "Agregar";
            buttonColumn.UseColumnTextForButtonValue = true;
            dtgPlatillos.Columns.Add(buttonColumn);
            banderaGuardar = "actualizar";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar == "guardar")
            {
                GuardarPedido();
                Close();                
            }
            else
            {
                ActualizarPedido();
                Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarPedido()
        {
            _pedidos.Idpedido = "null";
            _pedidos.NombreCliente = txtNombreCliente.Text;
            _pedidos.PrecioTotal = lblTotal.Text;
            _pedidos.Platillos = txtPedido.Text;
            var valida = _restauranteManejador.ValidarPedidos(_pedidos);
            if (valida.Item1)
            {
                _restauranteManejador.GuardarPedido(_pedidos);
                FrmTicket ticket = new FrmTicket();
                ticket.txtTicket.Enabled = false;
                ticket.txtTicket.Text = "Fecha: " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "Cliente: " + txtNombreCliente.Text + Environment.NewLine + Environment.NewLine + "Platillos:" + Environment.NewLine + txtPedido.Text + Environment.NewLine + "Total: $" + lblTotal.Text;
                ticket.ShowDialog();
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarPedido()
        {
            _restauranteManejador.ActualizarPedido(new Pedidos
            {
                Idpedido = idpedido,
                NombreCliente = txtNombreCliente.Text,
                PrecioTotal = lblTotal.Text,
                Platillos = txtPedido.Text,
            });
            FrmTicket ticket = new FrmTicket();
            ticket.txtTicket.Enabled = false;
            ticket.txtTicket.Text = "Fecha: " + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine + "Cliente: "+ txtNombreCliente.Text + Environment.NewLine+ Environment.NewLine + "Platillos:" + Environment.NewLine + txtPedido.Text + Environment.NewLine + "Total: $" + lblTotal.Text;
            ticket.ShowDialog();
        }
        private void CargarPlatillos(string filtro)
        {
            dtgPlatillos.DataSource = _restauranteManejador.ObtenerPlatillosPrecio(filtro);
        }

        private void dtgPlatillos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dtgPlatillos.Columns.IndexOf(buttonColumn))
            {
                txtPedido.Text += "Platillo: " + dtgPlatillos.CurrentRow.Cells["nombre"].Value.ToString() +" - Precio: $" + dtgPlatillos.CurrentRow.Cells["precio"].Value.ToString() + Environment.NewLine;                
                lblTotal.Text = (int.Parse(lblTotal.Text) + int.Parse(dtgPlatillos.CurrentRow.Cells["precio"].Value.ToString())).ToString();
                txtPedido.Select(txtPedido.Text.Length, 0);
                txtPedido.ScrollToCaret();
                
            }            
        }

        private void btnReiniciarPedido_Click(object sender, EventArgs e)
        {
            txtPedido.Text = "";
            lblTotal.Text = "0";
        }           
    }
}
