using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EntidadesRestaurante;

namespace AccesoDatosRestaurante
{
    public class RestauranteAccesoDatos
    {
        ConexionAccesoDatos _conexion;
        public RestauranteAccesoDatos()
        {            
            try
            {
                _conexion = new ConexionAccesoDatos("localhost", "root", "", "restaurante", 3306);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la conexion" + ex.Message);
            }
        }
        public bool ExisteAdmin(string usuario, string contrasena)
        {
            try
            {
                string consulta = string.Format("select count(*) from usuarios where nombre = '{0}' and contrasena = '{1}'", usuario, contrasena);
                var existe = _conexion.Existencia(consulta);
                if (existe == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la conexion" + ex.Message);
                return false;
            }
        }
        public bool ExisteAdmin2(string usuario, string contrasena)
        {
            try
            {
                string consulta = string.Format("select count(*) from admin where nombre = '{0}' and contrasena = '{1}'", usuario, contrasena);
                var existe = _conexion.Existencia(consulta);
                if (existe == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falló la conexion" + ex.Message);
                return false;
            }
        }
        public void GuardarAdmin(Administradores admin)
        {
            try
            {
                string consulta = string.Format("insert into usuarios values({0},'{1}','{2}')", admin.Idadmin, admin.Usuario, admin.Contrasena);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        //*********************Categorias*******************      
        public void GuardarCategoria(Categorias categoria)
        {
            try
            {
                string consulta = string.Format("insert into categoria values({0},'{1}','{2}')", categoria.Idcategoria, categoria.Nombre, categoria.Descripcion);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarCategoria(Categorias categoria)
        {
            try
            {
                string consulta = string.Format("update categoria set nombre = '{0}', descripcion = '{1}' where idcategoria = {2}", categoria.Nombre, categoria.Descripcion, categoria.Idcategoria);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Categorias> ObtenerCategorias(string filtro)
        {
            var ListaCategorias = new List<Categorias>();
            var ds = new DataSet();
            string consulta = string.Format("select * from categoria where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "categoria");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var categoria = new Categorias
                {
                    Idcategoria = row["idcategoria"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString()
                };
                ListaCategorias.Add(categoria);
            }
            return ListaCategorias;
        }
        public void EliminarCategoria(string  categoria)
        {
            try
            {
                string consulta = string.Format("delete from categoria where idcategoria = {0}", categoria);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
        //*********************Platillos*******************
        public void GuardarPlatillo(Platillos platillo)
        {
            try
            {
                string consulta = string.Format("insert into platillo values({0},'{1}','{2}','{3}','{4}')", platillo.Idplatillo, platillo.Nombre, platillo.Descripcion, platillo.Precio, platillo.Categoria);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarPlatillo(Platillos platillo)
        {
            try
            {
                string consulta = string.Format("update platillo set nombre = '{0}', descripcion = '{1}', precio = {2}, categoria = '{3}' where idplatillo = {4}", platillo.Nombre, platillo.Descripcion, platillo.Precio, platillo.Categoria, platillo.Idplatillo);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Platillos> ObtenerPlatillos(string filtro)
        {
            var ListaPlatillos = new List<Platillos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from platillo where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "platillo");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var platillo = new Platillos
                {
                    Idplatillo = row["idplatillo"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Precio = row["precio"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Categoria = row["categoria"].ToString()
                };
                ListaPlatillos.Add(platillo);
            }
            return ListaPlatillos;
        }
        public void EliminarPlatillo(string platillo)
        {
            try
            {
                string consulta = string.Format("delete from platillo where idplatillo = '{0}'", platillo);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
        public void LlenarCombo(ComboBox combo)
        {
            try
            {
                string consulta = "select * from categoria";
                _conexion.LlenarCombo(consulta, combo, "nombre");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el llenado" + ex.Message);
            }
        }
        //*********************Pedido*******************
        public void GuardarPedido(Pedidos pedido)
        {
            try
            {
                string consulta = string.Format("insert into pedido values({0},'{1}',{2},'{3}')", pedido.Idpedido, pedido.NombreCliente, pedido.PrecioTotal, pedido.Platillos);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el guardado" + ex.Message);
            }
        }
        public void ActualizarPedido(Pedidos pedido)
        {
            try
            {
                string consulta = string.Format("update pedido set nombreCliente = '{0}', precioTotal = '{1}', platillos = '{2}' where idpedido = {3}", pedido.NombreCliente, pedido.PrecioTotal, pedido.Platillos, pedido.Idpedido);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Pedidos> ObtenerPedidos(string filtro)
        {
            var ListaPedidos = new List<Pedidos>();
            var ds = new DataSet();
            string consulta = string.Format("select * from pedido where nombreCliente like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "pedido");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var pedido = new Pedidos
                {                    
                    Idpedido = row["idpedido"].ToString(),
                    NombreCliente = row["nombreCliente"].ToString(),
                    PrecioTotal = row["precioTotal"].ToString(),                    
                    Platillos = row["platillos"].ToString()                  
                };
                ListaPedidos.Add(pedido);
            }
            return ListaPedidos;
        }
        public List<PlatilloPrecio> ObtenerPlatillosPrecio(string filtro)
        {
            var ListaPlatillosPrecio = new List<PlatilloPrecio>();
            var ds = new DataSet();
            string consulta = string.Format("select nombre, precio from platillo where nombre like '%{0}%'", filtro);
            ds = _conexion.ObtenerDatos(consulta, "platillo");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var platilloprecio = new PlatilloPrecio
                {
                    Nombre = row["nombre"].ToString(),
                    Precio = row["precio"].ToString()
                };
                ListaPlatillosPrecio.Add(platilloprecio);
            }
            return ListaPlatillosPrecio;
        }
        public void EliminarPedido(string pedido)
        {
            try
            {
                string consulta = string.Format("delete from pedido where idpedido = '{0}'", pedido);
                _conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }          
    }
}
