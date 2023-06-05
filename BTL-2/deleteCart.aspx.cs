using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class deleteCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lấy id muốn xóa từ url
            string id = Request.QueryString.Get("id");
            //Lấy danh sách cookie để xóa
            string chuoiCookie = Request.Cookies["id"].Value;
            //Tìm vị trí id trong chuỗi cookie
            int viTriIDTrongChuoiCookie = chuoiCookie.IndexOf(id);



            //Xóa id trong cookie
            //string chuoiCookieSauKhiXoa = chuoiCookie.Remove(viTriIDTrongChuoiCookie, 1);

            string chuoiCookieSauKhiXoa = chuoiCookie.Replace(id, String.Empty);

            Response.Cookies["id"].Value = chuoiCookieSauKhiXoa;
            Response.Redirect("cart.aspx");


            
           
        }
    }
}