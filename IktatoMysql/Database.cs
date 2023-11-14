using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IktatoMysql
{
    class Database
    {
        static readonly string server = "127.0.0.1",user = "root", password = "", database = "iktato";
        public static string connection_string = $"Server ='{server}'; user ='{user}'; database ='{database}';password ='{password}'";

        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);

        public Database()
        {

        }

        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool open_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
