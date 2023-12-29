using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorElemento
    {

        public List<Elemento> allElementos()
        {
            List<Elemento> list = new List<Elemento>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {

                //Conectamos a la BD:
                connection = Conexion.Conexion.ConexionBD();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Id, Descripcion FROM ELEMENTOS";
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Elemento elemento = new Elemento();
                    elemento.Id = reader.GetInt32(0);
                    elemento.Descripcion = reader.GetString(1);
                  
                    list.Add(elemento);

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
