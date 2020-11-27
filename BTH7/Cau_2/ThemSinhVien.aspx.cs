using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTH7.Cau_2
{

    public partial class ThemSinhVien : System.Web.UI.Page
    {
        static List<SinhVien> sinhviens;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 sinhviens = new List<SinhVien>();
                listLop.Items.Add("58K1");
                listLop.Items.Add("58K2");
                listLop.Items.Add("58K3");
                listLop.Items.Add("58K4");
                listTinh.Items.Add("Nghệ An");
                listTinh.Items.Add("An Giang");
                listTinh.Items.Add("Bạc Liêu");
                listTinh.Items.Add("Bắc Giang");
                listTinh.Items.Add("Bắc Ninh");
                listTinh.Items.Add("Bến Tre");
                listTinh.Items.Add("Bình Định");
                listTinh.Items.Add("Bình Thuận");
                listTinh.Items.Add("Cà Mau");
            }
           
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            TxtDienThoai.Text = "";
            TxtHoTen.Text = "";
            TxtMaSo.Text = "";
            
        }

        protected void btnTHem_Click(object sender, EventArgs e)
        {
            //List<SinhVien> sinhViens2 = (List<SinhVien>)Session["sinhviens"];
            //sinhviens = sinhViens2;
            SinhVien a = new SinhVien { masv = TxtMaSo.Text,hoTen= TxtHoTen.Text,lop1= listLop.SelectedValue, tinh=listTinh.SelectedValue,dienThoai= TxtDienThoai.Text,hinhAnh= FileUpload.FileName };
            sinhviens.Add(a);

            Session["sinhviens"] = sinhviens;
            //Response.Redirect("DanhSachSinhVien.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DanhSachSinhVien.aspx");
        }
    }
}