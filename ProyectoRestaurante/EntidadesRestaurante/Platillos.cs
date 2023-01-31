namespace EntidadesRestaurante
{
    public class Platillos
    {
        private string _idplatillo;
        private string _nombre;
        private string _precio;
        private string _descripcion;
        private string _categoria;

        public string Idplatillo { get => _idplatillo; set => _idplatillo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
