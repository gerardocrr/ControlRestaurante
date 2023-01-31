namespace EntidadesRestaurante
{
    public class Pedidos
    {
        private string _idpedido;
        private string _precioTotal;
        private string _nombreCliente;
        private string _platillos;

        public string Idpedido { get => _idpedido; set => _idpedido = value; }
        public string PrecioTotal { get => _precioTotal; set => _precioTotal = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string Platillos { get => _platillos; set => _platillos = value; }
    }
}
