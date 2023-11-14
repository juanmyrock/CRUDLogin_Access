using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace DATOS
{
    public abstract class ConexionDB
    {
        private readonly string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|crud.accdb;";

        public DataTable Ejecutar(string sSQL, OleDbParameter[] lista, bool consulta = false)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(cadena))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sSQL, conn);
                if (lista != null) command.Parameters.AddRange(lista);
                if (consulta)
                {
                    dt.Load(command.ExecuteReader());
                }
                else
                {
                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear();
            }
            return dt;
        }
    }

    public static class ConexionBD2
    {
        public static bool AutenticarUsuario(string usuario, string contraseña)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|crud.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta correctamente.");
                    string consulta = "SELECT * FROM Tbl_Users WHERE User=@txtBoxUsers AND Password=@txtBoxPassw";
                    Console.WriteLine("Consulta SQL: " + consulta);
                    using (OleDbCommand command = new OleDbCommand(consulta, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@User", usuario);
                            command.Parameters.AddWithValue("@Password", contraseña);

                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                return reader.Read();
                            }
                        }
                        catch (OleDbException ex)
                        {
                            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Maneja otras excepciones
                    Console.WriteLine("Error: " + ex.Message);
                    return false; // o lanza la excepción nuevamente si es necesario
                }


            }
        }
    }
}
