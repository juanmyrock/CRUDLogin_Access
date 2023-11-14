using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ProdDatos : ConexionDB
    {
        private int id_producto;
        private string nombre_prod;
        private string descripcion_prod;
        private string marca_prod;
        private double precio_prod;
        private int stock_prod;
        OleDbParameter[] lista = null;


        #region Propiedades
        public int Id_Producto
        {
            get => id_producto;
            set { id_producto = value; }
        }
        public string Nombre_Prod
        {
            get => nombre_prod;
            set { nombre_prod = value; }
        }
        public string Descripcion_prod
        {
            get => descripcion_prod;
            set { descripcion_prod = value; }
        }
        public string Marca_prod
        {
            get => marca_prod;
            set { marca_prod = value; }
        }
        public double Precio_prod
        {
            get => precio_prod;
            set { precio_prod = value; }
        }
        public int Stock_prod
        {
            get => stock_prod;
            set { stock_prod = value; }
        }
        #endregion


        #region Metodos
        public void InsertProducto()
        {
            string sSql = "INSERT INTO Tbl_Productos (nombre, descripcion, marca, precio, stock ) values (?,?,?,?,?)";

            OleDbParameter param1 = new OleDbParameter("nombre", nombre_prod);
            OleDbParameter param2 = new OleDbParameter("descripcion", descripcion_prod);
            OleDbParameter param3 = new OleDbParameter("marca", marca_prod);
            OleDbParameter param4 = new OleDbParameter("precio", precio_prod);
            OleDbParameter param5 = new OleDbParameter("stock", stock_prod);

            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2, param3, param4, param5 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }

        public void UpdateProducto()
        {
            string sSql = "UPDATE Tbl_Productos set nombre=?, descripcion=?, marca=?, precio=?, stock=? WHERE Id=?";
            OleDbParameter param1 = new OleDbParameter("nombre", nombre_prod);
            OleDbParameter param2 = new OleDbParameter("descripcion", descripcion_prod);
            OleDbParameter param3 = new OleDbParameter("marca", marca_prod);
            OleDbParameter param4 = new OleDbParameter("precio", precio_prod);
            OleDbParameter param5 = new OleDbParameter("stock", stock_prod);
            OleDbParameter param6 = new OleDbParameter("Id", id_producto);

            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1, param2, param3, param4, param5, param6 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }

        public void EliminarProducto()
        {
            string sSql = "DELETE FROM Tbl_Productos WHERE Id = ?";
            OleDbParameter param1 = new OleDbParameter("Id", id_producto);
            List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
            lista = listaParametros.ToArray();

            Ejecutar(sSql, lista);
        }

        public DataTable Buscar(string datos)
        {
            string sSQL;
            if (string.IsNullOrEmpty(datos))
            {
                sSQL = "Select * from Tbl_Productos";
            }
            else
            {
                sSQL = "Select * from Tbl_Productos where nombre + descripcion like ? ";

                OleDbParameter param1 = new OleDbParameter("nombre", "%" + datos.Trim() + "%");
                List<OleDbParameter> listaParametros = new List<OleDbParameter>() { param1 };
                lista = listaParametros.ToArray();
            }
            return Ejecutar(sSQL, lista, true);
        }
        #endregion
    }
                
    

}
