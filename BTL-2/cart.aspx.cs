using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class cart : System.Web.UI.Page
    {     
        private void hienDanhSachCartKhongTrung()
        {
            // + Ở trang cart đọc id từ cookie => lấy id so sánh với list để có list sản phẩm trong cart
            if (Request.Cookies["id"] != null)
            {
                string chuoiId = Request.Cookies["id"].Value;
                string[] ids = chuoiId.Split(' '); // 1 1 2
                List<product> ds = (List<product>)Application["danhsach_sp"];
                List<product> ds_cart = new List<product>();
                int total = 0;

                foreach (string id in ids)
                {
                    foreach (product sp in ds)
                    {
                        if (sp.id == id)
                        {
                            ds_cart.Add(sp);
                            total += int.Parse(sp.priceCurrent,NumberStyles.AllowThousands);
                        }
                    }
                }

                cart_count.InnerText = ds_cart.Count.ToString();
                cart_number.InnerText = ds_cart.Count.ToString();
                total_price.InnerText = String.Format("{0:n0}", total);

                string html = "";
                foreach (product sp in ds_cart)
                {
                    html += $"<div class='cart__product-content' >";
                    html += $"<div class='cart__img'><img src ='{sp.img1}' alt ='' class='cart__product-img'></div>";
                    html += $"<div class='cart__product-details'>";
                    html += $"<h3 class='cart__name'>{sp.content}</h3>";
                    html += $"<span class='price'>{sp.priceCurrent} ₫</span>";
                    html += $"<del class='price-origin'>{sp.priceOld}₫</del>";
                    html += $"<div class='cart__quantity'>";
                    html += $"<button type ='button' class='cart__quantity-sub-btn' onclick='tru()'>-</button>";
                    html += $"<input type='text' name='quantity' id='qnt' value='1' class='cart-qnt' disabled>";
                    html += $"<button type='button' class='cart__quantity-add-btn'  onclick='cong()'>+</button>";
                    html += $"</div>";
                    html += $"</div>";
                    html += $"<div class='cart__icon'>";
                    html += $"<a href='deleteCart.aspx?id={sp.id}'><i class='cart__icon-cancel fa-solid fa-xmark'></i></a>";
                    html += $"</div>";
                    html += $"</div>";
                }
                product_cart.InnerHtml = html;
            }
        }

        private void hienDanhSachCartCoTrung()
        {
            string chuoiCookie = Request.Cookies["id"] == null ? "" : Request.Cookies["id"].Value;
           
            if (chuoiCookie != null)
            {
                string[] ids = chuoiCookie.Split(' '); // 1 1 2  => {1: 2 lần, 2: 1 lần}
                List<product> ds = (List<product>)Application["danhsach_sp"];
                List<product> ds_cart = new List<product>();
                List<string> idDaDem = new List<string>();
                string html = "";
                int totalPrice = 0;
                int totalProduct = 0;
                
                for (int i = 0; i < ids.Length; ++i)
                {
                    string idCanDem = ids[i];

                    if (idDaDem.Contains(idCanDem))
                    {
                        continue;
                    }
                    else
                    {
                        int soLuongId = ids.Where(id => id == idCanDem).ToArray().Length;

                        idDaDem.Add(idCanDem);

                        foreach (product product in ds)
                        {
                            if (product.id == idCanDem)
                            {
                                html += $"<div class='cart__product-content' >";
                                html += $"<div class='cart__img'><img src ='{product.img1}' alt ='' class='cart__product-img'></div>";
                                html += $"<div class='cart__product-details'>";
                                html += $"<h3 class='cart__name'>{product.content}</h3>";
                                html += $"<span class='price'>{product.priceCurrent}₫</span>";
                                html += $"<del class='price-origin'>{product.priceOld}₫</del>";
                                html += $"<div class='cart__quantity'>";
                                html += $"<button type ='button' class='cart__quantity-sub-btn' onclick='tru(event)'>-</button>";
                                html += $"<input type='text' name='quantity' id='qnt' value='{soLuongId}' class='cart-qnt' disabled>";
                                html += $"<button type='button' class='cart__quantity-add-btn'  onclick='cong(event)'>+</button>";
                                html += $"</div>";
                                html += $"</div>";
                                html += $"<div class='cart__icon'>";
                                html += $"<a href='deleteCart.aspx?id={product.id}'><i class='cart__icon-cancel fa-solid fa-xmark'></i></a>";
                                html += $"</div>";
                                html += $"</div>";

                                totalPrice += int.Parse(product.priceCurrent, NumberStyles.AllowThousands) * soLuongId;
                                totalProduct += soLuongId;
                            }
                        }
                    }
                }
                product_cart.InnerHtml = html;
                total_price.InnerText = String.Format("{0:n0}", totalPrice);
                cart_count.InnerText = totalProduct.ToString();
                cart_number.InnerText = totalProduct.ToString();
            }
        }

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

            hienDanhSachCartCoTrung();
        }
    }
}