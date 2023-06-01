using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace adoinsert
{

    public static class EmployeeDetails
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
       

        public static SqlDataReader GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                //sqldatareader is used to store record returned from city table
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }

        }
        public static DataSet getEmployeeDetails()
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string qr = "select * from employee";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.Fill(ds, "employee");
            return ds;

        }
          public static DataSet searchemployee(int empno)
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string qr = "select * from employee where empno=@empno";

            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.SelectCommand.Parameters.AddWithValue("@empno", empno);
            da.Fill(ds, "employee");
            return ds;
        }


    }
}

