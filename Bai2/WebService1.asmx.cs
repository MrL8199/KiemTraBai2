using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Bai2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public WebService1()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string systemtime()
        {
            string time = DateTime.Today.ToLongDateString();
            return time;
        }
        [WebMethod]
        public string Get_ListStudentsClassName(string className)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=QLSV_CNLTTH;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien, LopNienChe where SinhVien.MaLopNC = LopNienChe.MaLopNC and LopNienChe.Ten like '%"+className+"%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string str = ds.GetXml();
            return str;
        }
        [WebMethod]
        public string Get_ListStudentsCourseClassName(string className)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=QLSV_CNLTTH;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien, LopNienChe where SinhVien.MaLopNC = LopNienChe.MaLopNC and LopNienChe.Ten like '%" + className + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string str = ds.GetXml();
            return str;
        }
        [WebMethod]
        public string Get_Top5Students(string semester)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=QLSV_CNLTTH;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 5 SinhVien.Ten as [Tên SV], MonHoc.TenMon as [Tên Môn học], Sum(diem*HeSo) as [Điểm số] from Diem " +
                "inner join SinhVien on sinhvien.masv = diem.masv" +
                " inner join MonHoc on MonHoc.MaMon = diem.MaMon" +
                " where Diem.MaHocKy = '"+semester+"' group by Diem.MaSV, DIem.MaMon, SinhVien.Ten, MonHoc.TenMon" +
                " order by SUM(diem * heso) DESC", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string str = ds.GetXml();
            return str;
        }
    }
}