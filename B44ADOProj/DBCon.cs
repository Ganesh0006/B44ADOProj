using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace B44ADOProj
{
    class DBCon
    {
        SqlConnection con = new SqlConnection("server = .;Initial Catalog = B44Project;Integrated Security=true");
        public int InsertProduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("InsProd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }

        //internal int insuser(int v, string text1, string text2)
        //{
        //    throw new NotImplementedException();
        //}

        public int UpdateProduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("UpdProd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int DeleteProduct(int @pid)
        {
            SqlCommand cmd = new SqlCommand("Delprod1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            //cmd.Parameters.AddWithValue("@pname", pname);
            //cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }


        public DataTable ViewProduct()
        {
            SqlCommand cmd = new SqlCommand("Dispprod", con);
            cmd.CommandType = CommandType.StoredProcedure;          
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }

        public int InModel(int @mid, string @mname, int @pid,string @pname,string @spec,int @uprice,int @soh)
        {
            SqlCommand cmd = new SqlCommand("InsModel",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid",pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh",soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int upmodel(int @mid, string @mname,int @pid,string @pname,string @spec,int @uprice,int @soh)
        {
            SqlCommand cmd = new SqlCommand("upmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec",spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int DeleteModel(int @mid)
        {
            SqlCommand cmd = new SqlCommand("Delmodel1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }

        public DataTable ViewModel()
        {
            SqlCommand cmd = new SqlCommand("Dispmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public int insertuser(int @uid, string @uname, string @utype)
        {
            SqlCommand cmd = new SqlCommand("insuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@utype", utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int Updateuser(int @uid, string @uname, string @utype)
        {
            SqlCommand cmd = new SqlCommand("Upduser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@utype", utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public DataTable viewuser()
        {
            SqlCommand cmd = new SqlCommand("disp_user", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable viewuserbyuid(int @uid)
        {
            SqlCommand cmd = new SqlCommand("disp1_user", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", uid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int deleteuser(int @uid)
        {
            SqlCommand cmd = new SqlCommand("del1user", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }

        public int sales(int @pid, string @pname, int @mid, string @mname, string @spec, int @unitprice, int @qty, int @totamt)
        {
            SqlCommand cmd = new SqlCommand("inssales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@totamt", totamt);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public DataTable salesrpt(int fdate, int tdate)
        {
            SqlCommand cmd = new SqlCommand("salesrpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@fdate", fdate);
            cmd.Parameters.AddWithValue("@tdate", tdate);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

        public DataTable DailyRpt(DateTime @fdate)
        {
            SqlCommand cmd = new SqlCommand("DailyRpt1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@fdate", fdate);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable productrpt(int @pid)
        {
            SqlCommand cmd = new SqlCommand("dispsales1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable productrpt1()
        {
            SqlCommand cmd = new SqlCommand("dispsales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }
        public DataTable productrpt2(int @mid)
        {
            SqlCommand cmd = new SqlCommand("dispsales2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mid", mid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }


        public DataTable ViewProductbyPid(int @pid)
        {
            SqlCommand cmd = new SqlCommand("Dispprod1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;

        }

        public int chklog(string uid,string pwd,string utype)
        {
           
                SqlCommand cmd = new SqlCommand("chklog", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@utype",utype);
                int x = cmd.ExecuteNonQuery();
                con.Close();
                return x;

           
        }
    }
}
