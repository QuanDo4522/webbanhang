using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sign in
            if (Session["daDangNhap"].ToString() == "1")
            {
                string username = Session["name"].ToString();
                top_header_status.InnerHtml = "<p class='top-header_login'>Xin Chào," + username + "</p>" +
                                                "<p class='top-header_item-space'>|</p>" +
                                                "<p ><a href='signOut.aspx' class='top-header_link-logout' >Đăng Xuất</a></p>";


            }

            //list product
            List<product> ds = (List<product>)Application["danhsach_sp"];

            //  count.InnerText = ds.Count.ToString();
            string html = "";
            foreach (product sp in ds)
            {

                html += "<div class='product-item col l-3 m-6 c-6'><div class='product-item__img' >";
                html += "<img src='" + sp.img1 + "' alt=''>";
                html += " </div>";
                html += " <div class='product-item__content'>";
                html += $"<p class='product__tiltle '><a href='productDetailaspx.aspx?id={sp.id}'>{sp.content}</a></p>";
                html += "</div>";
                html += "<div class='product__price'>";
                html += "<p class='product__price-new'>" + sp.priceCurrent + "₫</p>";
                html += "<p class='product__price-old'>" + sp.priceOld + "₫</p>";
                html += "</div>";
                html += "</div>";
            }
            //  count.InnerText = ds.Count.ToString();
            row.InnerHtml = html;
            //gio hang
            if (Request.Cookies["id"] != null)
            {
                string chuoiId = Request.Cookies["id"].Value;


                string[] ids = chuoiId.Split(' '); // 1 1 2
                List<product> ds_cart = new List<product>();
                int total = 0;

                foreach (string id in ids)
                {
                    foreach (product sp in ds)
                    {
                        if (sp.id == id)
                        {
                            ds_cart.Add(sp);

                        }
                    }
                }
                cart_number.InnerText = ds_cart.Count.ToString();
            }

        }
    }
}