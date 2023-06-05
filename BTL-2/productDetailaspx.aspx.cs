using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class productDetailaspx : System.Web.UI.Page
    {

        private void HienSoGioHang()
        {
            List<product> ds = new List<product>();
            ds = (List<product>)Application["danhsach_sp"];
            //gio hang
            if (Request.Cookies["id"] != null)
            {
                string chuoiId = Request.Cookies["id"].Value;


                string[] ids = chuoiId.Split(' '); // 1 1 2
                List<product> ds_cart = new List<product>();
                

                foreach (string id1 in ids)
                {
                    foreach (product sp in ds)
                    {
                        if (sp.id == id1)
                        {
                            ds_cart.Add(sp);

                        }
                    }
                }
                cart_number.InnerText = ds_cart.Count.ToString();
            }

        }
        //hien ds lien quan
        private void product_related()
        {
            List<product> ds = new List<product>();
            ds = (List<product>)Application["danhsach_sp"];
            List<product> ds_lq = new List<product>();
            foreach (product sp in ds)
            {
                if (sp.type.Contains("Sản Phẩm Liên Quan"))
                {
                    ds_lq.Add(sp);
                }
            }
            string html = "";
            foreach(product sp in ds_lq)
            {
                html +=$"<div class='product__related-item l-2-4 m-6 c-6 '>";
                html += $"<div class='product__related-img'>";
                html += $"<a href='productDetailaspx.aspx?id={sp.id}' class='product__related-img-item'><img src='{sp.img1}' alt='' class='product-img-link'></a></div>";
                html += $"<div class='product__related-clearfix'>";
                html += $"<a href='productDetailaspx.aspx?id={sp.id}' class='product__related-name' title='{sp.content}'>{sp.content}</a>";
                html += $"<p class='product__related-price'>{sp.priceCurrent}₫</p>";
                html += $"<span class='product__related-price-del'><del>{sp.priceOld}₫</del></span ></div> ";
                html += $"</div>";
            }
            product_relate.InnerHtml = html;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //dang ki , dang nhap
            if (Session["daDangNhap"].ToString() == "1")
            {
                string username = Session["name"].ToString();
                top_header_status.InnerHtml = "<p class='top-header_login'>Xin Chào," + username + "</p>" +
                                                "<p class='top-header_item-space'>|</p>" +
                                                "<p ><a href='signOut.aspx' class='top-header_link-logout' >Đăng Xuất</a></p>";


            }
            //Hiện thông tin chi tiết sp
            List<product> ds = new List<product>();
            ds = (List<product>)Application["danhsach_sp"];
            List<product> ds_detail = new List<product>();

            //Lấy id từ url
            string id = Request.QueryString.Get("id");
            //Duyệt ds => add sản phẩm có id đó vào ds mới
            foreach (product sp in ds)
            {
                if (sp.id == id)
                {
                    ds_detail.Add(sp);
                }
            }
            string html1 = "";
            string html2 = "";
            string html3 = "";
            string html4 = "";
            foreach (product sp in ds_detail)
            {
                html1 += $"<img src='{sp.img1}' alt='' class='product__content-gallery-img active'>";
                html1 += $"<img src='{sp.img2}' alt='' class='product__content-gallery-img'>";
                html1 += $"<img src='{sp.img1}' alt='' class='product__content-gallery-img'>";
                html1 += $"<img src='{sp.img2}' alt='' class='product__content-gallery-img'>";

                html2 += $"<img src='{sp.img1}' alt='' class='product__content-feature-img'>";
                html2 += $"<img src='{sp.img2}' alt='' class='product__content-feature-img'>";
                html2 += $"<img src='{sp.img1}' alt='' class='product__content-feature-img'>";
                html2 += $"<img src='{sp.img2}' alt='' class='product__content-feature-img'>";
                html3 += sp.content;
                html4 += sp.priceCurrent;

            }
            content1.InnerHtml = html1;
            content2.InnerHtml = html2;
            content3.InnerHtml = html3;
            content4.InnerHtml = html4;
            // hiện ds sp liên quan 
            product_related();
            //hien giỏ hàng
            HienSoGioHang();
        }

            protected void AddProduct_ServerClick(object sender, EventArgs e)
            {
                //-----------------------------------------------------------------
                //Thêm cart
                // + Lưu id sản phẩm vào cookie
                string id = Request.QueryString.Get("id");

                int soLuongSanPham = int.Parse(qnt.Value);

                string cookieCu = "";
                string cookieSanPhamCanThem = "";

                if (Request.Cookies["id"] != null)
                {
                    cookieCu = Request.Cookies["id"].Value;
                    cookieSanPhamCanThem = " "; //Thêm dấu cách vào trước cookie mới để k dính vào cái cookie cũ
                }

                for(int i = 1; i <= soLuongSanPham; ++i)
                {
                    cookieSanPhamCanThem += $"{id} ";
                }

                Response.Cookies["id"].Value = cookieCu + cookieSanPhamCanThem;
                Response.Cookies["id"].Expires = DateTime.Now.AddDays(10);

                //HienSoGioHang();
            }
        }
    }

