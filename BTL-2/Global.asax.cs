using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_2
{


    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["danhsach_user"] = new List<user>();
            Application["danhsach_sp"] = new List<product>(); // => Application rỗng


            List<product> product=new List<product>(); // => List product rỗng 

            //sản phẩm mới
            product.Add(new product() { id = "1", img1 = "./images/product-2/Bánh_1.jpg", img2 = "./images/detail-img/banh-cookie-2.jpg", content= "Bánh quy hạt dẻ thơm ngon - 600gr",priceCurrent= "54,000",priceOld= "65,000" ,type = new string[]{ "Sản Phẩm Mới Nhất" }, color=""});
            product.Add(new product() { id = "2", img1 = "./images/product-2/bo-bit-tet.jpg", img2 = "./images/detail-img/bò2.jpg", content = "Bò bit tết kiểu Ý 500gr", priceCurrent = "250,000", priceOld = "300,000", type = new string[]{ "Sản Phẩm Mới Nhất" }, color = "" });
            product.Add(new product() { id = "3", img1 = "./images/product-2/ca-kho-1.jpg", img2 = "./images/detail-img/ca-ri-ca-bop-an-do.jpg", content = "Cà Ri cá Bớt Ấn Độ", priceCurrent = "100,000", priceOld = "130,000", type = new string[]{ "Sản Phẩm Mới Nhất" }, color = "" });
            product.Add(new product() { id = "4", img1 = "./images/product-2/anh-dao-2.jpg", img2 = "./images/detail-img/anh-da0-2.jpg", content = " Cherry Đỏ Mỹ Size 9.5 (Hộp 500G)", priceCurrent = "150,000", priceOld = "160,000", type = new string[]{ "Sản Phẩm Mới Nhất" }, color = "" });
            product.Add(new product() { id = "5", img1 = "./images/product-2/dưa.jpg", img2 = "./images/detail-img/dua-hau-2.jpg", content = "Dưa Hấu Đỏ Không Hạt Long An Trái 3kg", priceCurrent = "20,000", priceOld = "", type = new string[]{ "Sản Phẩm Mới Nhất", "Sản Phẩm Bán Chạy", "Sản Phẩm Liên Quan" }, color = "" });
            
            // sản phẩm bán chạy
            product.Add(new product() { id = "6", img1 = "./images/product-1/nho-3.jpg", img2 = "./images/detail-img/nho-2.jpg", content = "Nho Đỏ Crimson Úc", priceCurrent = "120,000", priceOld = "150,000", type = new string[] { }, color = "" });
            product.Add(new product() { id = "7", img1 = "./images/product-2/ca-chua-1.jpg", img2 = "./images/detail-img/gallery3.jpg", content = " Cà Chua Đà Lạt tươi ngon 500gr ", priceCurrent = "20,000", priceOld = "", type = new string[]{ "Sản Phẩm Bán Chạy" }, color = "" });
            product.Add(new product() { id = "8", img1 = "./images/product-2/nam-1.jpg", img2 = "./images/detail-img/product2.jpg", content = " Nấm Bào Ngư Xám Tươi - FoodMap", priceCurrent = "100,000", priceOld = "200,000", type = new string[]{ "Sản Phẩm Bán Chạy", "Sản Phẩm Liên Quan" }, color = "" });
            product.Add(new product() { id = "9", img1 = "./images/product-2/trung-4.jpg", img2 = "./images/detail-img/trung-2.jpg", content = "Trứng Gà Thảo Mộc - Vỉ 10 Quả", priceCurrent = "86,000", priceOld = "", type = new string[]{ "Sản Phẩm Bán Chạy", "Sản Phẩm Liên Quan" }, color = "" });
            product.Add(new product() { id = "10", img1 = "./images/product-2/chicken-meat.jpg", img2 = "./images/detail-img/ức_ga_2.jpg", content = "Ức Gà Ướp gia vị siêu cay", priceCurrent = "60,000", priceOld = "75,000", type = new string[]{ "Sản Phẩm Bán Chạy", "Sản Phẩm Liên Quan" }, color = "" });
            product.Add(new product() { id = "11", img1 = "./images/product-2/cam-1.jpg", img2 = "./images/detail-img/cam2.jpg", content = "Cam Vàng Ai Cập", priceCurrent = "40,000", priceOld = "50,000", type = new string[]{ "Sản Phẩm Bán Chạy" }, color = "" });
            product.Add(new product() { id = "12", img1 = "./images/product-2/dua-leo.jpg", img2 = "./images/detail-img/dua-leo-2.jpg", content = "Cải xanh Đà Lạt Tươi Ngon 500gr - FoodMap", priceCurrent = "20,000", priceOld = "30,000", type = new string[]{ "Sản Phẩm Bán Chạy" }, color = "" });
            product.Add(new product() { id = "13", img1 = "./images/product-2/khoai-tay.jpg", img2 = "./images/detail-img/khoai-tay-2.jpg", content = "Khoai Tây Bi Đà Lạt", priceCurrent = "90,000", priceOld = "", type = new string[]{ "Sản Phẩm Bán Chạy", "Sản Phẩm Liên Quan" }, color = "" });
            product.Add(new product() { id = "14", img1 = "./images/product-2/tao-do-3.jpg", img2 = "./images/detail-img/tao-do-2.jpg", content = "Táo Juliet Hữu Cơ Pháp", priceCurrent = "150,000", priceOld = "", type = new string[]{ "Sản Phẩm Bán Chạy" }, color = "" });
            product.Add(new product() { id = "15", img1 = "./images/product-2/hat-de.jpg", img2 = "./images/detail-img/hat-hanh-nhan-2.jpg", content = "Mỏng hạnh nhân nguyên Badam hạt giá rẻ - 1Kg", priceCurrent = "60,000", priceOld = "75,000", type = new string[]{ "Sản Phẩm Bán Chạy" }, color = "" });
            product.Add(new product() { id = "16", img1 = "./images/product-1/gao.jpg", img2 = "./images/detail-img/nep_sap.jpg", content = "Nếp Sáp túi 10Kg", priceCurrent = "120,000", priceOld = "", type = new string[]{  }, color = "" });
            product.Add(new product() { id = "17", img1 = "./images/product-1/bong-cai-2.jpg", img2 = "./images/detail-img/bong-cai-2.jpg", content = " Bông cải xanh hữu cơ Organicfood - 400g", priceCurrent = "20,000", priceOld = "", type = new string[]{  }, color = "" });
            product.Add(new product() { id = "18", img1 = "./images/product-1/dau-xanh.jpg", img2 = "./images/detail-img/dau-xanh2.jpg", content = "Đậu Hà Lan hữu cơ Rapunzel 350gr", priceCurrent = "100,000", priceOld = "", type = new string[]{  }, color = "" });
            product.Add(new product() { id = "19", img1 = "./images/product-1/banh-cookie-3.jpg", img2 = "./images/detail-img/banh-cookie-4.jpg", content = " Bánh Cookie Chocolate xốp giòn tan - 900gr", priceCurrent = "65,000", priceOld = "", type = new string[]{  }, color = "" });
            product.Add(new product() { id = "20", img1 = "./images/product-1/banh-mi.jpg", img2 = "./images/detail-img/banh-mi-2.jpg", content = " Bánh mì Pháp Baguette", priceCurrent = "20,000", priceOld = "26,000", type = new string[]{  }, color = "" });

            Application["danhsach_sp"] = product;


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["daDangNhap"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}