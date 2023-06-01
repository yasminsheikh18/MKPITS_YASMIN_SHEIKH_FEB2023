using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details_ado
{
    public static class DatabaseConnection1
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
        //creating a static method to insert record into user table
        public static string InsertRecord(int Empno, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into EmployeeDetails values(@Empno,@Empname,@Gender,@Email,@Mobileno,@City,@Dob)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("Empno",Empno);
                command.Parameters.AddWithValue("@password", password);
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
        //creating a static method to update record into users table
        public static string UpdateUsers(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "update adocivika set password=@password where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record updated successfully";
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

        //creating a static method to delete record from users table
        public static string DeleteUsers(string username)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from adocivika  where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record deleted successfully";
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
