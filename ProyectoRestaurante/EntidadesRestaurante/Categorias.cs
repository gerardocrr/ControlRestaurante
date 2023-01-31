namespace EntidadesRestaurante
{
    public class Categorias
    {
        private string _idcategoria;
        private string _nombre;
        private string _descripcion;

        public string Idcategoria { get => _idcategoria; set => _idcategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
