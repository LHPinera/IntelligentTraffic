using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace App.Data
{
    public class Conection
    {
        public static string GetConLocal()
        {
            //Local Desarrollo
            //string con = @"Data Source=ITS-DESARROLLO\SQLEXPRESS; Initial Catalog=Pruebas; Integrated Security=False; User ID=sa; Password=its2018";

            //Demo HP
            //string con = @"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=DB_A35D2D_saav2; Integrated Security=False; User ID=sa; Password=ITStech2018#1";

            //Demo Local
            //string con = @"Data Source=LOCALHOST\SQLEXPRESS; Initial Catalog=DB_A35D2D_saav2; Integrated Security=False; User ID=sa; Password=its2018";

            //Servidor Veracruz
            string con = @"Data Source=10.27.120.30\SQLC5ITSLPR; Initial Catalog=saav2; Integrated Security=False; User ID=saav2; Password=ITStech2018#1";

            return con;
        }

        public static string GetConNube()
        {
            //Original
            string con = @"Data Source=sql5035.site4now.net; Initial Catalog=DB_A35D2D_saav2; Integrated Security=False; User ID=DB_A35D2D_saav2_admin; Password=ITStech2018#1";
            
            return con;
        }
    }
}
