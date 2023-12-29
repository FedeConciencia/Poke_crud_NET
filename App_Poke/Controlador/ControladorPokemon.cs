using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Conexion;


namespace Controlador
{
    public class ControladorPokemon
    {

        public List<Pokemon> allPoke()
        {
            List<Pokemon> list = new List<Pokemon>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {

                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Numero, Nombre, Descripcion, UrlImagen, Activo FROM POKEMONS";
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Pokemon pokemon = new Pokemon();
                    pokemon.Num = reader.GetInt32(0);
                    //pokemon.Name = (string) reader["Nombre"];
                    //pokemon.Descrip = (string) reader["Descripcion"];
                    pokemon.Name = reader.GetString(1);
                    pokemon.Descrip = reader.GetString(2);
                    pokemon.UrlImag = reader.GetString(3);
                    pokemon.Activo = reader.GetBoolean(4);

                    list.Add(pokemon);

                }


                return list;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                connection.Close();


            }


        }

        public List<Pokemon> allPokeTipoDebilidad()
        {
            List<Pokemon> list = new List<Pokemon>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            try
            {

                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();
                
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion AS Tipo, i.Descripcion AS Debilidad, p.Activo, e.Id, i.Id FROM POKEMONS AS p INNER JOIN \r\nELEMENTOS AS e ON e.id = p.idTipo INNER JOIN ELEMENTOS as i ON i.id = p.IdDebilidad";
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
 
                    Pokemon pokemon = new Pokemon();
                    pokemon.Num = reader.GetInt32(0);
                    //pokemon.Name = (string) reader["Nombre"];
                    //pokemon.Descrip = (string) reader["Descripcion"];
                    pokemon.Name = reader.GetString(1);
                    pokemon.Descrip = reader.GetString(2);
                    pokemon.UrlImag = reader.GetString(3);
                    pokemon.Tipo = new Elemento();
                    pokemon.Tipo.Descripcion = reader.GetString(4);
                    pokemon.Debilidad = new Elemento();
                    pokemon.Debilidad.Descripcion = reader.GetString(5);
                    pokemon.Activo = reader.GetBoolean(6);
                    pokemon.Tipo.Id = reader.GetInt32(7);
                    pokemon.Debilidad.Id = reader.GetInt32(8);


                    list.Add(pokemon);

                }


                return list;
                

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally 
            { 
                connection.Close();
                

            } 

            
        }

        public void insertPoke(Pokemon poke)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) VALUES " +
                $"({poke.Num}, '{poke.Name}', '{poke.Descrip}', '{poke.UrlImag}', {poke.Tipo.Id}, {poke.Debilidad.Id}, 1)";

                command.Connection = connection;

                connection.Open();

                //Ejecutamos el Script:
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }

        }

        public void updatePoke(Pokemon poke)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"UPDATE POKEMONS SET Numero = {poke.Num}, Nombre = '{poke.Name}', Descripcion = '{poke.Descrip}', " +
                                      $"UrlImagen = '{poke.UrlImag}', IdTipo = {poke.Tipo.Id}, IdDebilidad = {poke.Debilidad.Id}, Activo = 1 WHERE Numero = {poke.Num}";

                command.Connection = connection;

                connection.Open();

                //Ejecutamos el Script:
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }

        }


        public void deleteFisicoPoke(int num)
        {

            eliminaciones(true, num);

        }

        public void deleteLogPoke(int num)
        {

            eliminaciones(false, num);

        }

        //Metodo Compartido para eliminar fisico/Logico
        public void eliminaciones(bool bandera, int num)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {

                bool existe = false;

                List<Pokemon> list = allPokeTipoDebilidad();


                //Verificamos que camino tomamos:
                if (bandera)
                {
                    //Conectamos a la BD:
                    connection = Conexion.Conexion.ConexionBD();

                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $"DELETE FROM POKEMONS WHERE Numero = {num}";

                    command.Connection = connection;

                    connection.Open();

                    //Ejecutamos el Script:
                    command.ExecuteNonQuery();
                }
                else
                {

                    //Conectamos a la BD:
                    connection = Conexion.Conexion.ConexionBD();

                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = $"UPDATE POKEMONS SET Activo = 0 WHERE Numero = {num}";

                    command.Connection = connection;

                    connection.Open();

                    //Ejecutamos el Script:
                    command.ExecuteNonQuery();


                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }

        }


        //Metodo que permite obtener List<> de los Pokemons filtro Avanzado:
        public List<Pokemon> filtroAvanzado(string campo, string criterio, string filtro)
        {

            List<Pokemon> list = new List<Pokemon>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {

                Console.WriteLine("*** PRUEBA ***");
                Console.WriteLine(campo);
                Console.WriteLine(criterio);
                Console.WriteLine(filtro);


                string consulta = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion AS Tipo, i.Descripcion AS Debilidad, p.Activo, e.Id, i.Id FROM POKEMONS AS p INNER JOIN ELEMENTOS AS e ON e.id = p.idTipo INNER JOIN ELEMENTOS as i ON i.id = p.IdDebilidad WHERE p.Activo = 1 AND ";
                
                //Verificamos todas las combinaciones posibles del ComboBox para completar Script:
                if (campo == "Numero")
                {
                    if (criterio == "Mayor a")
                    {
                        consulta += $"p.Numero > {int.Parse(filtro)}";
                    }
                    else if (criterio == "Menor a")
                    {
                        consulta += $"p.Numero < {int.Parse(filtro)}";
                    }
                    else
                    {
                        consulta += $"p.Numero = {int.Parse(filtro)}";
                    }
                }
                else if (campo == "Nombre")
                {

                    if (criterio == "Comienza con")
                    {
                        consulta += $"p.Nombre LIKE '{filtro}%'";
                    }
                    else if (criterio == "Termina con")
                    {
                        consulta += $"p.Nombre LIKE '%{filtro}'";
                    }
                    else
                    {
                        consulta += $"p.Nombre LIKE '%{filtro}%'";
                    }

                }
                else if (campo == "Descripcion")
                {

                    if (criterio == "Comienza con")
                    {
                        consulta += $"p.Descripcion LIKE '{filtro}%'";
                    }
                    else if (criterio == "Termina con")
                    {
                        consulta += $"p.Descripcion LIKE '%{filtro}'";
                    }
                    else
                    {
                        consulta += $"p.Descripcion LIKE '%{filtro}%'";
                    }

                }

                Console.WriteLine(consulta);


                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = consulta;
                command.Connection = connection;


                connection.Open();


                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Pokemon pokemon = new Pokemon();
                    pokemon.Num = reader.GetInt32(0);
                    //pokemon.Name = (string) reader["Nombre"];
                    //pokemon.Descrip = (string) reader["Descripcion"];
                    pokemon.Name = reader.GetString(1);
                    pokemon.Descrip = reader.GetString(2);
                    pokemon.UrlImag = reader.GetString(3);
                    pokemon.Tipo = new Elemento();
                    pokemon.Tipo.Descripcion = reader.GetString(4);
                    pokemon.Debilidad = new Elemento();
                    pokemon.Debilidad.Descripcion = reader.GetString(5);
                    pokemon.Activo = reader.GetBoolean(6);
                    pokemon.Tipo.Id = reader.GetInt32(7);
                    pokemon.Debilidad.Id = reader.GetInt32(8);


                    list.Add(pokemon);

                }


                return list;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                connection.Close();


            }


        }


    }
}
