using System.Data;
using Capa_Datos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Negocios
{
    public class CNProveedor
    {


        public void GuardarListaProveedores(List<PROVEEDOR> proveedores)
        {
            connBD datos = new connBD();

            using (SqlConnection conn = new SqlConnection(datos.conexion))
            {
                conn.Open();
                foreach (var p in proveedores)
                {
                    if (!p.EsValido())
                    {
                        throw new ArgumentException($"El proveedor '{p.NOMBRE}' tiene datos no válidos.");
                    }
                    InsertarProveedorEnBD(p, conn);
                }
            }
        }



        public DataTable ObtenerTodosLosProveedores()
        {

            connBD datos = new connBD();
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(datos.conexion))
            {
                string query = "SELECT RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO FROM PROVEEDOR";
                using (SqlDataAdapter adapt = new SqlDataAdapter(query, conn))
                {
                    adapt.Fill(dt);
                }
            }
            return dt;
        }


        public string ObtenerNombrePorRNC(string rnc)
        {
            connBD datos = new connBD();
            string nombre = null;
            using (SqlConnection conexion = new SqlConnection(datos.conexion))
            {
                string query = "SELECT Nombre FROM Proveedores WHERE RNC = @RNC";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@RNC", rnc);

                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    nombre = lector["Nombre"].ToString();
                }
            }
            return nombre;
        }



        private void InsertarProveedorEnBD(PROVEEDOR proveedor, SqlConnection conn)
        {
            // Opcional: Verificar si el RNC/ID ya existe antes de insertar
            string checkQuery = "SELECT COUNT(1) FROM PROVEEDOR WHERE RNC = @RNC";
            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@RNC", proveedor.ObtenerIdentificadorPrincipal());
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    // Puedes lanzar un error o simplemente ignorar el duplicado
                    throw new InvalidOperationException($"El RNC/ID '{proveedor.ObtenerIdentificadorPrincipal()}' ya existe en la base de datos.");
                }
            }

            string query = "INSERT INTO PROVEEDOR (RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO) VALUES (@RNC, @NOMBRE, @TELEFONO, @TIPO, @PRODUCTO)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RNC", proveedor.ObtenerIdentificadorPrincipal());
                cmd.Parameters.AddWithValue("@NOMBRE", proveedor.NOMBRE);
                cmd.Parameters.AddWithValue("@TELEFONO", proveedor.TELEFONO);
                cmd.Parameters.AddWithValue("@TIPO", proveedor.ObtenerTipo());
                cmd.Parameters.AddWithValue("@PRODUCTO", proveedor.PRODUCTO);
                cmd.ExecuteNonQuery();
            }



        }

        public void EliminarProveedor(string rnc)
        {
            connBD datos = new connBD();
            using (SqlConnection conn = new SqlConnection(datos.conexion))
            {
                string query = "DELETE FROM PROVEEDOR WHERE RNC = @RNC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RNC", rnc);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public DataTable BuscarProveedores(string RNC)
        {
            connBD datos = new connBD();

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(datos.conexion))
            {
                // Usamos LIKE para búsquedas parciales
                string query = "SELECT RNC, NOMBRE, TELEFONO, TIPO, PRODUCTO FROM PROVEEDOR WHERE RNC LIKE @RNC";
                using (SqlDataAdapter adapt = new SqlDataAdapter(query, conn))
                {
                    adapt.SelectCommand.Parameters.AddWithValue("@RNC", "%" + RNC + "%");
                    adapt.Fill(dt);
                }


            }

            return dt;
        }


    }

}