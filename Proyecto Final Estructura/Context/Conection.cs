using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Proyecto_Final_Estructura.Context
{
    class Conection
    {
        private string connectionString = "Server=DESKTOP-UBLQO8B;Database=ign;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
