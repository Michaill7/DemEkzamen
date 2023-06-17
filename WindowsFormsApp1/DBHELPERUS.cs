using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DBHELPERUS
    {
        private static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M0LTBB9;Initial Catalog=ACTIONS;Integrated Security=True");
        public static DataTable gay (string login,string pass)
        {
            var sda = new SqlDataAdapter($"Select role from Users where login = '{login}' and password = '{pass}'",con );
            var dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static DataTable ShowDataToDataGridOfModerWindow() 
        {
            var sda = new SqlDataAdapter("select * from Модераторы$", con);
            var dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
