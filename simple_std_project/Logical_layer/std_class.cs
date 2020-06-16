using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_std_project.data_layer;
using System.Data.SqlClient;
using System.Data;


using System.Windows.Forms;

namespace simple_std_project.Logical_layer
{
    class std_class
    {
        public int std_id { get; set; }
        public string std_fname { get; set; }

        public string std_lname { get; set; }

        public string std_gname { get; set; }

        public string std_gender { get; set; }

        public string std_email { get; set; }

        public string std_phone { get; set; }

        // all studennndts
        public DataTable getAllStd()
        {
            connectionClass obj = new connectionClass();


            obj.openConn();

            DataTable dt = new DataTable();
            dt = obj.readData("GET_ALL_STD", null); 
            obj.CloseConn();
            return dt;
            
        }


        // add std

        public void inserting_std(string fname, string lname, string gname,  string gender, string phone="" , string email="")
        {

            SqlParameter[] paraStd = new SqlParameter[6];

            connectionClass obj = new connectionClass();
             
            obj.openConn();



            paraStd[0] = new SqlParameter("@std_fname ", SqlDbType.NVarChar,30);
            paraStd[0].Value = fname;

            paraStd[1] = new SqlParameter("@std_lname ", SqlDbType.NVarChar, 30);
            paraStd[1].Value = lname;


            paraStd[2] = new SqlParameter("@std_gname ", SqlDbType.NVarChar, 30);
            paraStd[2].Value = gname;

          


            paraStd[3] = new SqlParameter("@std_gender", SqlDbType.NVarChar,5);
            paraStd[3].Value = gender;

            paraStd[4] = new SqlParameter("@std_phone", SqlDbType.NVarChar, 15);
            paraStd[4].Value = phone;

            paraStd[5] = new SqlParameter("@std_email", SqlDbType.NVarChar, 50);
            paraStd[5].Value = email;

            obj.excuteCmd("ADD_STD", paraStd);

            

            obj.CloseConn();


           MessageBox.Show("تمت اضافة الطالب " + fname +" "+ lname + " بنجاح");




        }

        // delete std


        public void DELETE_STD(int ID)
        {

            SqlParameter[] paraStdId = new SqlParameter[1];

            connectionClass obj = new connectionClass();
            obj.openConn();



            paraStdId[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            paraStdId[0].Value = ID;



            obj.excuteCmd("DELETE_STD", paraStdId);

           obj.CloseConn();




        }

        // get all matched std

        public DataTable getAllMatchedStd(string  fname)
        {
            SqlParameter[] paraFname = new SqlParameter[1];
            connectionClass obj = new connectionClass();


            obj.openConn();

            paraFname[0] = new SqlParameter("@std_fname",SqlDbType.NVarChar,30);
            paraFname[0].Value = fname;


            DataTable dt = new DataTable();
            dt = obj.readData("GET_ALL_MATCHED_STD", paraFname);
            obj.CloseConn();
            return dt;

        }


    }



}
