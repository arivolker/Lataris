using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


// Ini adalah Class untuk aktifitas yang berhubungan dengan MySQL
namespace Lataris
{
    class DBConnect
    {
        private static MySqlConnection koneksi;
        public static string status;



        public static void konekdb()
        {
            string connectionString;
            string server = "localhost";
            string database = "aris3";
            string user = "root";
            string password = "";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            koneksi = new MySqlConnection(connectionString);
            status = "Status : Terhubung";
        }


        private static bool openConnection()
        {
            try
            {
                koneksi.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Tidak dapat terhubung ke server. Hubungi Administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Username/password salah, mohon periksa kembali");
                        break;
                }
                return false;
            }
        }


        private static bool closeConnection()
        {
            try
            {
                koneksi.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public static DataTable Selectdb(string querysql)
        {
            DataTable data = new DataTable();

            if (openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(querysql, koneksi);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                data.Load(dataReader);

                closeConnection();
                return data;
            }
            else
            {
                return data;
            }
        }


        public static void Insertdb(String querysql)
        {
            if (openConnection())
            {
                MySqlTransaction transaction = koneksi.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand(querysql, koneksi);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                closeConnection();
            }
        }


        public static void Updatedb(String querysql)
        {
            if (openConnection())
            {
                MySqlTransaction transaction = koneksi.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand(querysql, koneksi);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                closeConnection();
            }
        }

        public static void Deletedb(String querysql)
        {
            if (openConnection())
            {
                MySqlTransaction transaction = koneksi.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand(querysql, koneksi);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                closeConnection();
            }
        }


        public static int getCount(String querysql)
        {
            int ret = 0;
            string query = "select count(*) from " + querysql;
            if (openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(querysql, koneksi);
                ret = Convert.ToInt32(cmd.ExecuteScalar());
                closeConnection();
            }
            return ret;
        }


    }
}
