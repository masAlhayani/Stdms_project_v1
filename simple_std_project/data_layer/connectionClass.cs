using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace simple_std_project.data_layer
{
    class connectionClass
    {

        

        SqlConnection sqlConnection;
        public connectionClass()
        {
           // sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\MyProjects\simple_std_project\simple_std_project\db_std.mdf;Integrated Security=True;");
             sqlConnection = new SqlConnection(@"Data Source=DESKTOP-MGQNIRJ;Initial Catalog=E:\MYPROJECTS\SIMPLE_STD_PROJECT\SIMPLE_STD_PROJECT\DB_STD.MDF;Integrated Security=True;");
        }

        // oping method
        public void openConn()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        // closing method
        public void CloseConn()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // read data from database

        public DataTable readData(string stored_procedure, SqlParameter[] para)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;

            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    sqlcmd.Parameters.Add(para[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        /// method to insert, update , delet from database

        public void excuteCmd(string stored_proceduer, SqlParameter[] para)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                openConn();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_proceduer;
                sqlcmd.Connection = sqlConnection;

                if (para != null)
                {
                    for (int i = 0; i < para.Length; i++)
                    {
                        sqlcmd.Parameters.Add(para[i]);

                    }
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();
                    CloseConn();

                }
            }
            catch (Exception d)
            {
                MessageBox.Show("an error : " + d.GetType());

            }



        }




    }
}
