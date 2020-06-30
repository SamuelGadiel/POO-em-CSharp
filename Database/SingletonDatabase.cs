using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class SingletonDatabase
    {
        static SQLiteConnection conn = null;
        const string databasePath = "academico.db";

        public static SQLiteConnection Connection
        {
            get
            {
                Console.WriteLine("CONECTADO");
                if (conn != null)
                    return conn;
                var cwd = Directory.GetCurrentDirectory();
                Console.WriteLine(cwd);
                var dbpath = Path.Combine(cwd, "academico.db");
                conn = new SQLiteConnection(@"Data Source=" + dbpath);
                conn.Open();

                return conn;
            }
        }

        public static void CloseConn()
        {
            Console.WriteLine("DESCONECTADO");
            if (conn != null)
            {
                conn.Close();
            }
            conn = null;
        }
    }
}
