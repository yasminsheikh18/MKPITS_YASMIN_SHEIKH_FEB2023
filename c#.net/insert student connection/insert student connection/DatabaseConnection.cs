using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace insert_student_connection
{
    public static class DatabaseConnection
    {
        //creating a static variable
        private static string connectionString = "server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=adocivica";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }
        //creating a static method to insert record into student table
        public static string InsertRecord(string firstname, string lastname, string course )
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into student values(@firstname,@lastname,@course)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@firstname",firstname);
                command.Parameters.AddWithValue("@lastname",lastname);
                command.Parameters.AddWithValue("@course", course);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }


    }
}
