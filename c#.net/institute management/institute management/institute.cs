using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace institute_management
{
    internal class institute
    {

            private static string connectionstring = "server=LAPTOP-ETMMI9QB\\SQLEXPRESS;integrated security=true;database=institute;";
            public static SqlConnection GetConnection()
            {
                SqlConnection con = new SqlConnection(connectionstring);
                try
                {
                    //con.Open();
                    return con;
                }
                catch 
                { 
                    return null; 
                }



            }
           public static DataSet getnation()
            {
                SqlConnection con=GetConnection();
                string query = "select * from nation";
                DataSet ds = new DataSet();
                SqlDataAdapter da=new SqlDataAdapter(query,con);
                da.Fill(ds, "tablenation");
                return ds;
            }
        public static DataSet getstate(string nationname)
        {
            SqlConnection con = GetConnection();
            string query = "select s.stateid,s.statename from state s inner join nation n on\r\ns.nationid=n.nationid\r\nwhere nationname=@nationname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@nationname",nationname);
            da.Fill(ds, "tablestate");
            return ds;
        }

        public static DataSet getcity( string statename)
        {
            SqlConnection con = GetConnection();
            string query = "select s.cityid,s.cityname from city s inner join state n on\r\ns.stateid = n.stateid\r\nwhere statename = @statename";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@statename", statename);
            da.Fill(ds, "tablecity");
            return ds;
        }
        public static string savetablecourseregdetail(int CategoryID, string FullName, int GenderID)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = "insert into courseid values(@categoryid,@fullname,@genderid)";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@categoryid", CategoryID);
            cmd.Parameters.AddWithValue("@fullname", FullName);
            cmd.Parameters.AddWithValue("@genderid", GenderID);
            cmd.ExecuteNonQuery();
            s.Close();
            return "record saved in courseid successfully";
        }

        static int courseregid = 0;
        public static string savetablereg(int NationID, int StateID, int CityID)
        {
            SqlConnection s = GetConnection();
            s.Open();
            string query = " SELECT top 1 courseregid FROM addres ORDER BY courseregid DESC";
            SqlCommand cmd = new SqlCommand(query, s);
            courseregid = Convert.ToInt32(cmd.ExecuteScalar());//return single value
            query = "insert into addres values (@courseregid,@NationID,@StateID,@CityId)";
            cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@courseregid", courseregid);
            cmd.Parameters.AddWithValue("@NationID", NationID);
            cmd.Parameters.AddWithValue("@StateID", StateID);
            cmd.Parameters.AddWithValue("@CityId", CityID);
            cmd.ExecuteNonQuery();
            s.Close();
            return "record save in addres ";


        }
    }
}

