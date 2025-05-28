using Proyecto_Final_Estructura.Context;
using Proyecto_Final_Estructura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;

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
        public List<Videogame> LeerJuegos(string user)
        {
            List<Videogame> game = new List<Videogame>();
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("readvg", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iduser", Convert.ToInt32(user));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Videogame gamu = new Videogame
                                {
                                    id = Convert.ToInt32(reader["idjuego"]),
                                    name = reader["nombre"].ToString(),
                                    platform = reader["plataforma"].ToString(),
                                    iduser = Convert.ToInt32(reader["idusuario"])
                                };
                                game.Add(gamu);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los videojuegos: " + ex.Message);
            }
            return game;
        }
        public bool InsertarJuego(string name, string platform, int iduser)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertvg", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@game", name);
                        cmd.Parameters.AddWithValue("@platform", platform);
                        cmd.Parameters.AddWithValue("@iduser", iduser);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el videojuego: " + ex.Message);
            }
        }
        public bool ActualizarJuego(int idgame, string name, string platform, int iduser)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("updateVG", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@vgid", idgame);
                        cmd.Parameters.AddWithValue("@game", name);
                        cmd.Parameters.AddWithValue("@platform", platform);
                        cmd.Parameters.AddWithValue("@iduser", iduser);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el videojuego: " + ex.Message);
            }
        }
        public bool EliminarJuego(int idgame)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("deletevg", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idvg", idgame);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el videojuego: " + ex.Message);
            }
        }
        public List<Genre> ReadGenre()
        {
            List<Genre> genres = new List<Genre>();
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("readgenre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Genre genre = new Genre
                                {
                                    id = Convert.ToInt32(reader["idgenero"]),
                                    name = reader["nombre"].ToString()
                                };
                                genres.Add(genre);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los géneros: " + ex.Message);
            }
            return genres;
        }
        public bool InsertGenre(string name)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertgenre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el género: " + ex.Message);
            }
        }
        public List<Rate> ReadRate()
        {
            List<Rate> rates = new List<Rate>();
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("readrate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rate rate = new Rate
                                {
                                    id = Convert.ToInt32(reader["idcalif"]),
                                    idgame = Convert.ToInt32(reader["idjuego"]),
                                    score = Convert.ToInt32(reader["puntuaje"]),
                                    comment = reader["comentario"].ToString(),
                                };
                                rates.Add(rate);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las calificaciones: " + ex.Message);
            }
            return rates;
        }
        public bool InsertRate(int idgame, int score, string comment)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertrate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idgame", idgame);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la calificación: " + ex.Message);
            }
        }
        public bool UpdateRate(int idrate, int idgame, int score, string comment)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("updaterate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idrate", idrate);
                        cmd.Parameters.AddWithValue("@idgame", idgame);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la calificación: " + ex.Message);
            }
        }
        public bool DeleteRate(int idrate)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("deleterate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idrate", idrate);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la calificación: " + ex.Message);
            }
        }
    }
}
