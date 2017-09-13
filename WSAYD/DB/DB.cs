using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace DB
{
    public class DB
    {   OleDbConnection con = new OleDbConnection();
        public DB(string connection) 
        {
            con.ConnectionString = connection;
            con.Open();
        }

        public OleDbDataReader Select(string query) 
        {
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader rd = cmd.ExecuteReader();

            return rd;
        }
    }
}
