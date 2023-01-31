using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatosRestaurante
{
    public class ConexionAccesoDatos
    {
        private MySqlConnection _conn;
        public ConexionAccesoDatos(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();

            cadenaConexion.Server = server;
            cadenaConexion.UserID = user;
            cadenaConexion.Password = password;
            cadenaConexion.Database = database;
            cadenaConexion.Port = port;


            _conn = new MySqlConnection(cadenaConexion.ToString());
        }

        public int Existencia(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            var res = Convert.ToInt32(command.ExecuteScalar().ToString());
            _conn.Close();
            return res;
        }
        public void EjecutarConsulta(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
            da.Fill(ds, tabla);
            return ds;
        }        
        public void LlenarCombo(string consulta, ComboBox combo, string columna)
        {
            var command = new MySqlCommand(consulta, _conn);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = columna;                               
        }        
    }
}
