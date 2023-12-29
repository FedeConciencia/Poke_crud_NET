using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Conexion
    {
        

        //Con SQL Server con Usuario de Windows:
        //connection.ConnectionString = "server=NBK-FSABATINI; database=POKEDEX_DB; integrated security=true";

        //Con SQL Server con Usuario Sql y Password:
        //connection.ConnectionString = "server=NBK-FSABATINI; database=POKEDEX_DB; integrated security=false; user=sa; password=12345";

        public static SqlConnection ConexionBD()
        {

            SqlConnection connection;
            string server = "NBK-FSABATINI";
            string database = "POKEDEX_DB";
            string usuario = "";
            string password = "";

            connection = new SqlConnection("server="+server+"; database="+database+"; integrated security=true");
            
            return connection;
        }
    }
}
