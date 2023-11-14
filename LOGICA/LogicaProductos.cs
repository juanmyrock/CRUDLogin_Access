using DATOS;
using System;
using System.Data;

namespace LOGICA
{
    public class ProdLogica
    {
        ProdDatos logica_prod = new ProdDatos();

        private string id_producto;
        private string nombre_prod;
        private string descripcion_prod;
        private string marca_prod;
        private string precio_prod;
        private string stock_prod;

        #region Propiedades
        public string Id_Producto
        {
            get => id_producto;
            set { id_producto = value; }
        }
        public string Nombre_Prod
        {
            get => nombre_prod;
            set
            {
                nombre_prod = value;
                if (String.IsNullOrEmpty(nombre_prod))
                {
                    throw new Exception("El nombre del producto no puede ser nulo o vacio");
                }
            }
        }
        public string Descripcion_prod
        {
            get => descripcion_prod;
            set
            {
                descripcion_prod = value;
                if (String.IsNullOrEmpty(descripcion_prod))
                {
                    throw new Exception("La descripcion del producto no puede ser nula o vacia");
                }
            }
        }
        public string Marca_prod
        {
            get => marca_prod;
            set
            {
                marca_prod = value;
                if (String.IsNullOrEmpty(marca_prod))
                {
                    throw new Exception("La marca del producto no puede ser nula o vacia");
                }
            }
        }
        public string Precio_prod
        {
            get => precio_prod;
            set
            {
                precio_prod = value;
                if (String.IsNullOrEmpty(precio_prod))
                {
                    throw new Exception("El precio del producto no puede ser nulo o vacio");
                }
                else if (Convert.ToDouble(precio_prod) < 0)
                {
                    throw new Exception("El precio no puede ser menor a 0");
                }
            }
        }
        public string Stock_prod
        {
            get => stock_prod;
            set
            {
                stock_prod = value;
            }
        }
        #endregion

        #region Metodos
        public void Guardar()
        {
            pasarDatos();
            logica_prod.InsertProducto();
        }

        public DataTable LN_TraerTodos(string datos = "")
        {
            return logica_prod.Buscar(datos);
        }

        public void Eliminar()
        {
            pasarDatos();
            logica_prod.EliminarProducto();
        }

        private void pasarDatos()
        {
            logica_prod.Id_Producto = Convert.ToInt32(id_producto);
            logica_prod.Nombre_Prod = nombre_prod;
            logica_prod.Descripcion_prod = descripcion_prod;
            logica_prod.Marca_prod = marca_prod;
            logica_prod.Precio_prod = Convert.ToDouble(precio_prod);
            logica_prod.Stock_prod = Convert.ToInt32(stock_prod);
        }
        
        private ProdDatos prodDatos;

        public ProdLogica()
        {
            // instancio la capa de datos para comunicarnos con la base de datos
            this.prodDatos = new ProdDatos();
        }

        public void EliminarProductoEnLogica(int idProducto)
        {
            // asigno el ID del producto que deseamos eliminar a la capa de datos
            prodDatos.Id_Producto = idProducto;

            // llamamos al método en la capa de datos para llevar a cabo la eliminación
            prodDatos.EliminarProducto();
        }
        
        public void ActualizarProductoEnLogica(int idProducto, string nuevoNombre, string nuevaDescripcion, string nuevaMarca, double nuevoPrecio, int nuevoStock)
        {
            // Asignamos los valores que queremos actualizar a la capa de datos
            prodDatos.Id_Producto = idProducto;
            prodDatos.Nombre_Prod = nuevoNombre;
            prodDatos.Descripcion_prod = nuevaDescripcion;
            prodDatos.Marca_prod = nuevaMarca;
            prodDatos.Precio_prod = nuevoPrecio;
            prodDatos.Stock_prod = nuevoStock;

            // Llamamos al método en la capa de datos para llevar a cabo la actualización
            prodDatos.UpdateProducto();
        }
        #endregion


    }



    #region Logica Login
    public static class LogicaUsuario
    {
        public static bool AutenticarUsuario(string usuario, string contraseña)
        {
            return ConexionBD2.AutenticarUsuario(usuario, contraseña);
        }

    }
    #endregion
}




