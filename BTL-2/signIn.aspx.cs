using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class signIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                //Lấy dữ liệu
                string username = Request.Form["input-username"];
                string password = Request.Form["input-password"];


                //Check rỗng, ..
                bool ck = true;
                if (username == "" && password == "")
                {
                    ck = false;
                }
                else
                {
                    ck = true;
                }

                List<user> ds = (List<user>)Application["danhsach_user"];


                //Thành công thì Lưu vào list
                if (ck)
                {
                    

                        bool Trung = false;
                        foreach (user us in ds) //1 - k trùng 2- trùng 3- k trùng
                        {
                            if (username == us.username && password==us.password)
                            {
                                Trung = true;
                            }
                            else
                            {
                                Trung = false;
                                break;
                            }

                        }

                        

                        if (Trung)
                        {
                            Session["daDangNhap"] = 1;
                            Session["name"] = username;
                            Response.Redirect("trangchu.aspx");
                        }
                        else
                        {
                            messeage.InnerText = "Sai tên đăng nhập hoặc mật khẩu :))";
                        }
                    
                 
                }

                


            }

        }
    }
}