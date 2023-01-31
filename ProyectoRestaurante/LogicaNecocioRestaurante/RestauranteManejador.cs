using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccesoDatosRestaurante;
using EntidadesRestaurante;

namespace LogicaNecocioRestaurante
{
    public class RestauranteManejador
    {
        RestauranteAccesoDatos _restauranteAccesoDatos = new RestauranteAccesoDatos();
        public bool ExisteUsuario(string usuario, string contrasena)
        {
            var existe = _restauranteAccesoDatos.ExisteAdmin(usuario, contrasena);
            return existe;
        }
        public bool ExisteAdmin(string usuario, string contrasena)
        {
            var existe = _restauranteAccesoDatos.ExisteAdmin2(usuario, contrasena);
            return existe;
        }
        public void GuardarAdmin(Administradores admin)
        {
            try
            {
                _restauranteAccesoDatos.GuardarAdmin(admin);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo el guardado" + ex.Message);
            }
        }
        //*********************Categorias*******************      
        public Tuple<bool, string> ValidarCategoria(Categorias categoria)
        {
            bool error = true;
            string cadenaErrores = "";

            if (categoria.Nombre.Length == 0 || categoria.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Nombre\" no puede ser vacio. \n";
                error = false;
            }
            if (categoria.Descripcion.Length == 0 || categoria.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Descripción\" no puede ser vacio. \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public void GuardarCategoria(Categorias categoria)
        {
            try
            {
                _restauranteAccesoDatos.GuardarCategoria(categoria);
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
                _restauranteAccesoDatos.ActualizarCategoria(categoria);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Categorias> ObtenerCategorias(string filtro)
        {
            var listaCategorias = _restauranteAccesoDatos.ObtenerCategorias(filtro);
            return listaCategorias;
        }
        public void EliminarCategoria(string categoria)
        {
            try
            {
                _restauranteAccesoDatos.EliminarCategoria(categoria);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }
        //*********************Platillos*******************
        public Tuple<bool, string> ValidarPlatillo(Platillos platillo)
        {
            bool error = true;
            string cadenaErrores = "";

            if (platillo.Nombre.Length == 0 || platillo.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Nombre\" no puede ser vacio. \n";
                error = false;
            }            
            if (platillo.Precio.Length == 0 || platillo.Precio == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Precio\" no puede ser vacio. \n";
                error = false;
            }            
            if (platillo.Descripcion.Length == 0 || platillo.Descripcion == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Descripcion\" no puede ser vacio. \n";
                error = false;
            }
            if (platillo.Categoria.Length == 0 || platillo.Categoria == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Categoria\" no puede ser vacio. \n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public void GuardarPlatillo(Platillos platillo)
        {
            try
            {
                _restauranteAccesoDatos.GuardarPlatillo(platillo);
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
                _restauranteAccesoDatos.ActualizarPlatillo(platillo);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Platillos> ObtenerPlatillos(string filtro)
        {
            var listaPlatillos = _restauranteAccesoDatos.ObtenerPlatillos(filtro);
            return listaPlatillos;
        }
        public void EliminarPlatillo(string platillo)
        {
            try
            {
                _restauranteAccesoDatos.EliminarPlatillo(platillo);
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
                _restauranteAccesoDatos.LlenarCombo(combo);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló el llenado" + ex.Message);
            }
        }
        //*********************Pedido*******************
        public Tuple<bool, string> ValidarPedidos(Pedidos pedido)
        {
            bool error = true;
            string cadenaErrores = "";

            if (pedido.PrecioTotal.Length == 0 || pedido.PrecioTotal == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Precio\" no puede ser vacio. \n";
                error = false;
            }
            if (pedido.NombreCliente.Length == 0 || pedido.NombreCliente == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Cliente\" no puede ser vacio. \n";
                error = false;
            }
            if (pedido.Platillos.Length == 0 || pedido.Platillos == null)
            {
                cadenaErrores = cadenaErrores + "El campo \"Plato\" no puede ser vacio. \n";
                error = false;
            }            
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
        public void GuardarPedido(Pedidos pedido)
        {
            try
            {
                _restauranteAccesoDatos.GuardarPedido(pedido);
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
                _restauranteAccesoDatos.ActualizarPedido(pedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la actualización" + ex.Message);
            }
        }
        public List<Pedidos> ObtenerPedidos(string filtro)
        {
            var listaPedidos = _restauranteAccesoDatos.ObtenerPedidos(filtro);
            return listaPedidos;
        }
        public List<PlatilloPrecio> ObtenerPlatillosPrecio(string filtro)
        {
            var listaPlatillos = _restauranteAccesoDatos.ObtenerPlatillosPrecio(filtro);
            return listaPlatillos;
        }
        public void EliminarPedido(string pedido)
        {
            try
            {
                _restauranteAccesoDatos.EliminarPedido(pedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falló la eliminación" + ex.Message);
            }
        }               
    }
}
