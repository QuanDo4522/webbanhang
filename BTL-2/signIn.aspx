<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="BTL_2.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<title>Đăng Nhập</title>
	<link rel="stylesheet" href="./style/singup.css" />
	<link rel="stylesheet" href="./style/gird.css" />
	<link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet' />
</head>
<body>
    <form id="form1" runat="server">
        <!-- header -->
	<div class="grid wide">

		<header class="header">
			<div class=" header_text__logo ">
				<a href="trangchu.aspx" class=" header_logo-link ">Fresh Organic</a>
			</div>
			<h2>Đăng Nhập</h2>
		</header>
	</div>
		<div class="containner">
		<div class="home-wrap sing_in">
			<div class="home-tiltle">
				<h2>Đăng Nhập</h2>
			</div>
			<div class="form">
				<div class="sign-in-username">
					<label for="input-username">
						<i class='bx bxs-user'></i>
					</label>
                    <input type="text" name="input-username" id="input-username" placeholder="Username*">
                    <p class="message username-message"></p>
                </div>
                <div class="sign-in-password">
					<label for="input-password">
						<i class='bx bxs-lock'></i>
					</label>
                    <input type="password" name="input-password" id="input-password" placeholder="Password*" >
                    <p class="message password-message"></p>
                </div>
                <div class="show-password">
                    <label for="show-psw-btn">
                        <i class='bx bxs-bullseye'></i>
                    </label>
                    <button type="button" id="show-psw-btn">Hiển thị password</button>
                </div>
				<div id="messeage" runat="server"></div>
                <div class="sign-in-submit">
                    <p class="sign-in-status"></p>
                    <button type="submit" class="submit-button">Đăng Nhập</button>
                </div>
				<div class="form-footer">
					<span>Bạn mới biết đến Fresh Organic ?</span>
					<p><a href="signUp.aspx">Đăng Kí</a></p>
				</div>
			</div>
			
			
		</div>
	</div>
		<footer class="footer ">
		<div class="footer-container ">
			<div class="grid wide ">
				<div class="footer-wrap row ">
					<div class="footer-content col l-4 m-12 c-12 ">
						<h2 class="footer-content-header ">Giới thiệu</h2>
						<p class="footer-content-text ">
							Fresh Organic trang mua sắm trực tuyến của thương hiệu thời trang Lama, thời trang nam, nữ, phụ kiện, giúp bạn tiếp cận xu hướng thời trang mới nhất.
						</p>
					</div>

					<div class="col l-8 m-12 c-12 ">
						<div class="row ">
							<div class="footer-content col l-4 m-12 c-12 ">
								<h2 class="footer-content-header ">Thông tin liên hệ</h2>
								<div class=" footer-contact ">
									<ul>
										<li class="contact-1 "><i class='bx bxs-map'></i> Tầng 4, tòa nhà Flemington, số 182, đường Lê Đại Hành, phường 15, quận 11, Tp. Hồ Chí Minh.</li>
										<li class="contact-2 "><i class='bx bxs-phone-call'></i> 1900.636.099</li>
										<li class="contact-4 "><i class='bx bxl-gmail'></i> hi@haravan.com</li>
									</ul>
								</div>
							</div>
							<div class="footer-content col l-4 m-12 c-12 ">
								<h2 class="footer-content-header ">Liên kết</h2>
								<div class=" toggle-footer ">
									<ul>

										<li class="item ">
											<a href=" " title="Sản phẩm khuyến mãi ">Sản phẩm khuyến mãi</a>
										</li>

										<li class="item ">
											<a href=" " title="Sản phẩm nổi bật ">Sản phẩm nổi bật</a>
										</li>

										<li class="item ">
											<a href=" " title="Tất cả sản phẩm ">Tất cả sản phẩm</a>
										</li>

									</ul>
								</div>
							</div>
							<div class="footer-content col l-4 m-12 c-12 ">
								<h2 class="footer-content-header ">Hỗ trợ</h2>
								<div class="footer-content toggle-footer ">
									<ul>

										<li class="item ">
											<a href="/search " title="Tìm kiếm ">Tìm kiếm</a>
										</li>

										<li class="item ">
											<a href="/pages/about-us " title="Giới thiệu ">Giới thiệu</a>
										</li>

										<li class="item ">
											<a href="/pages/chinh-sach-doi-tra " title="Chính sách đổi trả ">Chính sách đổi trả</a>
										</li>

										<li class="item ">
											<a href="/pages/chinh-sach-bao-mat " title="Chính sách bảo mật ">Chính sách bảo mật</a>
										</li>

										<li class="item ">
											<a href="/pages/dieu-khoan-dich-vu " title="Điều khoản dịch vụ ">Điều khoản dịch vụ</a>
										</li>

										<li class="item ">
											<a href="/pages/lien-he " title="Liên hệ ">Liên hệ</a>
										</li>

									</ul>
								</div>
							</div>
						</div>
					</div>


				</div>

			</div>
		</div>

	</footer>
    </form>
	<script src="./js/signIn.js"> </script>
</body>
</html>
