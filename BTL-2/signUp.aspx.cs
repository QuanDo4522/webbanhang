using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lưu tài khoản
            success.InnerText = "";



            if (IsPostBack)
            {
                //Lấy dữ liệu
                string username = Request.Form["input-username"];
                string email = Request.Form["input-email"];
                string password = Request.Form["input-password"];
                string repassword = Request.Form["input-repassword"];


                //Check rỗng, ..
                bool ck = true;
                if (username == "" && email == "" && password == "" && repassword == "")
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
                    if (ds.Count != 0)
                    {
                        bool khongTrung = true;
                        foreach (user us in ds) //1 - k trùng 2- trùng 3- k trùng
                        {
                            if (username != us.username)
                            {
                                khongTrung = true;
                            }
                            else
                            {
                                khongTrung = false;
                                break;
                            }

                        }

                        if (khongTrung)
                        {
                            user user = new user(username, email, password, repassword);
                            ds.Add(user);
                            success.InnerText = $"Chúc mừng bạn đã đăng kí thành công";
                        }
                        else
                        {
                            success.InnerText = "Tên đăng nhập đã tồn tại!!!";
                        }
                    }
                    else
                    {
                        user user = new user(username, email, password, repassword);
                        ds.Add(user);
                        success.InnerText = "Chúc mừng bạn đã đăng kí thành công";
                    }
                }

                Application["danhsach_user"] = ds;
               

            }
            
        }
    }
}