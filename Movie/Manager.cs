using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Movie
{
    class Manager
    {
        public static void Query(string Command)
        {
            Database.Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Database.Connection);
            cmd.ExecuteNonQuery();
            Database.Connection.Close();
        }

        public static void Insertmovie(string m_name, string m_cat, string m_director, string m_imb)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO table_movie(m_name,m_cat,m_director,m_imb) VALUES(@m_name,@m_cat,@m_director,@m_imb)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_name", m_name);
                Command.Parameters.AddWithValue("@m_cat", m_cat);
                Command.Parameters.AddWithValue("@m_director", m_director);
                Command.Parameters.AddWithValue("@m_imb", m_imb);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        //ฟังชันก์ อัพเดทที่เพิ่มเข้ามา
        public static void Updatemovie(string m_name, string m_cat, string m_director, string m_imb)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"UPDATE table_movie SET m_cat=@m_cat,m_director=@m_director,m_imb=@m_imb WHERE m_name='" + m_name + "'";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_name", m_name);
                Command.Parameters.AddWithValue("@m_cat", m_cat);
                Command.Parameters.AddWithValue("@m_director", m_director);
                Command.Parameters.AddWithValue("@m_imb", m_imb);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        //ฟังชั่นก์ ลบที่เพิ่มเข้ามา
        public static void Deletemovie(string m_name)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM table_movie WHERE m_name=@m_name";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@m_name", m_name);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }
}
