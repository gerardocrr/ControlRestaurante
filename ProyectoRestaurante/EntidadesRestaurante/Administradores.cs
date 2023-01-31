namespace EntidadesRestaurante
{
    public class Administradores
    {
        private string _idadmin;
        private string _usuario;
        private string _contrasena;

        public string Idadmin { get => _idadmin; set => _idadmin = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
    }
}
