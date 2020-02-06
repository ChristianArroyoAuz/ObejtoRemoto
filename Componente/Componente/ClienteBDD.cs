using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System;


namespace Componente
{
    class ClienteBDD : MarshalByRefObject
    {
        private static string cadenaConexion = "";

        public int AgregarCliente(ClienteDetalle nuevoCliente)
        {
            string sentenciaSql = "INSERT INTO Cliente ";
            sentenciaSql += "(nombreCompleto, correo, password) VALUES ('";
            sentenciaSql += nuevoCliente.Nombre + "', '";
            sentenciaSql += nuevoCliente.Email + "', '";
            sentenciaSql += nuevoCliente.Password + "')";
            return EjecutarSentencia(sentenciaSql);
        }

        public int ActualizarCliente(ClienteDetalle cliente)
        {
            string sentenciaSql = "UPDATE Cliente SET";
            sentenciaSql += "nombreCompleto='" + cliente.Nombre + "', ";
            sentenciaSql += "correo='" + cliente.Email + "', ";
            sentenciaSql += "password='" + cliente.Password + "' ";
            sentenciaSql += " WHERE clienteID=" + cliente.ID.ToString();
            return EjecutarSentencia(sentenciaSql);
        }

        public ClienteDetalle ObtenerCliente(int idCliente)
        {
            return null;
        }

        private int EjecutarSentencia(string sentenciaSql)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(sentenciaSql, conexion);
            int resultado = 0;
            try
            {
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                resultado = 0;
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        public int EliminarCliente(int clienteID)
        {
            string sentenciaSql = "DELETE FROM Cliente WHERE clienteID=";
            sentenciaSql += clienteID.ToString();
            return EjecutarSentencia(sentenciaSql);
        }
    }
}