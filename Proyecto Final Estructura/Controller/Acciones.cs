using Proyecto_Final_Estructura.Context;
using Proyecto_Final_Estructura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Proyecto_Final_Estructura.Controller
{
    class Acciones
    {
        private readonly Conection conexion = new Conection();
        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("userlogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users user = new Users
                                {
                                    user = reader["usuario"].ToString(),
                                    password = reader["Contraseña Desencriptada"].ToString()
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
            return users;
        }
        public bool Login(string user, List<Users> users, string password)
        {
            foreach (var u in users)
            {
                if (u.user == user)
                {
                    if (u.password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Register(string user, string password)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertuser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el usuario: " + ex.Message);
            }
        }

    }
}
