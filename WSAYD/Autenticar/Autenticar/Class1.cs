using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB;

namespace Autenticar
{
    public class Autenticar
    {
        DB.DB con;

        public Autenticar()
        {
            con = new DB.DB(@"Provider=SQLOLEDB;Database=MONITOR;Initial Catalog=DB1;Server=.\SQLEXPRESS;User Id=sa;Password=sa");            
        }

        public bool Exists(string username, string password) 
        {
            return con.Select("SELECT 1 FROM USUARIO WHERE USERNAME='" + username + "' AND PASSWORD='" + password + "'").HasRows;
        }
    }
}
