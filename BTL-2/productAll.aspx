<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productAll.aspx.cs" Inherits="BTL_2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" type="image/png" href="./images/favicon_0264a241ad4a42b3a3912ebc01444768.png"/>
    <title>Tất cả sản phẩm</title>
    <link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'>
    <link rel="stylesheet" href="./style/procduct.css">
    <link rel="stylesheet" href="./style/gird.css">

</head>
<body>
    <form id="form1" runat="server">
           <div class="wrap">
        <div class="top-header">
           <div class="top-header-container " runat="server" id="top_header_status">
                <p class="top-header_item">
                    <a href="signUp.aspx" class="top-header_item-link">Đăng Kí</a>
                </p>
                <p class="top-header_item-space">|</p>
                <p class="top-header_item">
                    <a href="signIn.aspx" class="top-header_item-link"> Đăng Nhập</a>
                </p>
            </div>
        </div>
        <div class="grid wide">
            <header class="header">
                <div class="header-menu">
                    <p class="header-menu-icon" ">
                        <i class='bx bx-menu icon-1 ' style=" display: inline; "></i>
                    </p>
                    <p class=" header-menu-icon-2 " style=" display: none; ">
                        <i class='bx bx-x-circle icon-2' style=" display:inline; "></i>
                    </p>
                    <div class=" menu-content ">
                        <ul class=" menu-content-lis ">
                              <li class="menu-content-items ">
                                <a href="trangchu.aspx" class="menu-content-items-link ">Trang Chủ</a>
                            </li>
                            <li class="menu-content-items ">
                                <a href="#" class="menu-content-items-link active ">Sản Phẩm</a>
                            </li>
                            <li class="menu-content-items ">
                                <a href="#" class="menu-content-items-link ">Tin Tức</a>
                            </li>
                            <li class="menu-content-items ">
                                <a href="#" class="menu-content-items-link ">Giới Thiệu</a>
                            </li>
                            <li class=" menu-content-items mm-divider ">
                                <div class=" mobile-menu__section mobile-menu__section--loose ">
                                    <p class=" mobile-menu__section-title ">Bạn cần hỗ trợ?</p>
                                    <div class=" mobile-menu__help-wrapper ">
                                        <svg class=" icon icon--bi-phone " viewBox=" 0 0 24 24 " role=" presentation ">
                                            <g stroke-width=" 2 " fill=" none " fill-rule=" evenodd " stroke-linecap=" square ">
                                                <path d=" M17 15l-3 3-8-8 3-3-5-5-3 3c0 9.941 8.059 18 18 18l3-3-5-5z " stroke=" #1e2d7d "></path>
                                                <path d=" M14 1c4.971 0 9 4.029 9 9m-9-5c2.761 0 5 2.239 5 5 " stroke=" #00badb "></path>
                                            </g>
                                        </svg>
                                        <a href=" tel:1900636099 " rel=" nofollow ">Liên hệ: 1900.636.099 </a>
                                    </div>
                                    <div class=" mobile-menu__help-wrapper ">
                                        <svg class=" icon icon--bi-email " viewBox=" 0 0 22 22 " role=" presentation ">
                                            <g fill=" none " fill-rule=" evenodd ">
                                                <path stroke=" #00badb " d=" M.916667 10.08333367l3.66666667-2.65833334v4.65849997zm20.1666667 0L17.416667 7.42500033v4.65849997z "></path>
                                                <path stroke=" #1e2d7d " stroke-width=" 2 " d=" M4.58333367 7.42500033L.916667 10.08333367V21.0833337h20.1666667V10.08333367L17.416667 7.42500033 "></path>
                                                <path stroke=" #1e2d7d " stroke-width=" 2 " d=" M4.58333367 12.1000003V.916667H17.416667v11.1833333m-16.5-2.01666663L21.0833337 21.0833337m0-11.00000003L11.0000003 15.5833337 "></path>
                                                <path d=" M8.25000033 5.50000033h5.49999997M8.25000033 9.166667h5.49999997 " stroke=" #00badb " stroke-width=" 2 " stroke-linecap=" square "></path>
                                            </g>
                                        </svg>
                                        <a href=" mailto:hi@haravan.com " rel=" nofollow ">hi@haravan.com</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
    
                </div>
                <div class=" header_text__logo ">
                    <a href="trangchu.aspx" class=" header_logo-link ">Fresh Organic</a>
                </div>
                <div class=" header_nav ">
                    <ul class=" header_nav-lis ">
                        <li class=" header_nav-items ">
                            <a href=" trangchu.aspx" class=" header_nav-items-link  ">Trang Chủ</a>
                        </li>
                        <li class=" header_nav-items ">
                            <a href="#" class=" header_nav-items-link active ">Sản Phẩm</a>
                        </li>
                        <li class=" header_nav-items ">
                            <a href="productDetailaspx.aspx" class=" header_nav-items-link ">Tin Tức</a>
                        </li>
                        <li class=" header_nav-items ">
                            <a href="#" class=" header_nav-items-link ">Giới Thiệu</a>
                        </li>
                    </ul>
    
    
                </div>
                <div class=" header_nav-contact ">
                    <div class=" header_nav-search ">
                        <i class='bx bx-search'></i>
                    </div>
    
                   <%-- <div class=" header_nav-sign ">
                        <svg class=" svg-ico-account " version=" 1.1 " xmlns=" http://www.w3.org/2000/svg " xmlns:xlink=" http://www.w3.org/1999/xlink " x=" 0px " y=" 0px " width=" 510px " height=" 510px " viewBox=" 0 0 510 510 " style=" enable-background:new
                        0 0 510 510; " xml:space=" preserve ">
                            <g><g id=" account-circle ">
                                <path d=" M255,0C114.75,0,0,114.75,0,255s114.75,255,255,255s255-114.75,255-255S395.25,0,255,0z M255,76.5 c43.35,0,76.5,33.15,76.5,76.5s-33.15,76.5-76.5,76.5c-43.35,0-76.5-33.15-76.5-76.5S211.65,76.5,255,76.5z M255,438.6
                        c-63.75,0-119.85-33.149-153-81.6c0-51,102-79.05,153-79.05S408,306,408,357C374.85,405.45,318.75,438.6,255,438.6z "></path>
                                </g></g>
                        </svg>
                    </div>--%>
                    <div class=" header_nav-cart ">
                        <a href="cart.aspx" >
                        <svg version=" 1.1 " class=" svg-ico-cart " xmlns=" http://www.w3.org/2000/svg " xmlns:xlink=" http://www.w3.org/1999/xlink " x=" 0px " y=" 0px " viewBox=" 0 0 24 27 " style=" enable-background:new 0 0 24 27; " xml:space=" preserve ">
                            <g>
                                <path d=" M0,6v21h24V6H0z M22,25H2V8h20V25z "></path>
                            </g>
                            <g>
                                <path d=" M12,2c3,0,3,2.3,3,4h2c0-2.8-1-6-5-6S7,3.2,7,6h2C9,4.3,9,2,12,2z "></path>
                            </g>
                        </svg>
                        <div class="cart-number">
                            <span id="cart_number" runat="server"></span>
                        </div>
                        </a>
                    </div>
                </div>
            </header>
            <div class=" box-search ">
                <div class=" container-search ">
                    <div class=" input-search ">
                        <span> <i class='bx bx-search'></i></span>
                        <input type=" text ">
                    </div>
                    <button>Tìm Kiếm</button>
                </div>
    
            </div>
        </div>
        <div class=" banner-product ">
            <img src="./images/product-1/collection_banner.jpg" alt=" ">
        </div>
        <div class=" product-container ">
            <div class=" grid wide ">
                <div class=" row ">
                    <div class="filter-container col l-2-4 m-12 c-12 ">
                        <div class="wrap-filter">
							<div class="box_sidebar">
            	<div class="block left-module">
		<div class=" filter_xs">
			<div class="layered">
				<p class="title_block ">
					Bộ lọc sản phẩm
					<span class="down"><i class='bx bxs-chevron-down'></i></span>
				</p>
				<div class="block_content">
					<!-- ./filter brand -->
					
					<div class="group-filter" aria-expanded="true">
						<div class="layered_subtitle dropdown-filter"><span>Thương hiệu</span><span class="icon-control"><i class='bx bx-minus'></i></span></div>
						<div class="layered-content bl-filter filter-brand">
							<ul class="check-box-list">
									
								<li>
									<input type="checkbox" id="data-brand-p1" value="Khác" name="brand-filter" data-vendor="(vendor:product contains Khác)">
									<label for="data-brand-p1">Khác</label>   
								</li>
								
							</ul>
						</div>
					</div>
					
					<!-- ./filter price -->
					
					<div class="group-filter" aria-expanded="true">
						<div class="layered_subtitle dropdown-filter"><span>Giá sản phẩm</span><span class="icon-control"><i class='bx bx-minus'></i></span></div>
						<div class="layered-content bl-filter filter-price">
							<ul class="check-box-list">
								<li>
									<input type="checkbox" id="p1" name="cc" data-price="(price:product<=500000)">
									<label for="p1">
										<span>Dưới</span> 500,000₫
									</label>   
								</li>
								<li>
									<input type="checkbox" id="p2" name="cc" data-price="((price:product>500000)&amp;&amp;(price:product<=1000000))">
									<label for="p2">
										500,000₫ - 1,000,000₫
									</label>   
								</li>
								<li>
									<input type="checkbox" id="p3" name="cc" data-price="((price:product>1000000)&amp;&amp;(price:product<=1500000))">
									<label for="p3">
										1,000,000₫ - 1,500,000₫
									</label>   
								</li>
								<li>
									<input type="checkbox" id="p4" name="cc" data-price="((price:product>2000000)&amp;&amp;(price:product<=5000000))">
									<label for="p4">
										2,000,000₫ - 5,000,000₫
									</label>   
								</li>
								<li>
									<input type="checkbox" id="p5" name="cc" data-price="(price:product>=5000000)">
									<label for="p5">
										<span>Trên</span> 5,000,000₫
									</label>   
								</li>
							</ul>
						</div>
					</div>
								
					<!-- ./filter color -->
					
					<div class="group-filter" aria-expanded="true">
						<div class="layered_subtitle dropdown-filter"><span>Màu sắc</span><span class="icon-control"><i class='bx bx-minus'></i></span></div>
						<div class="layered-content filter-color s-filter">
							<ul class="check-box-list">
								<li>
									<input type="checkbox" id="data-color-p1" value="Hồng" name="color-filter" data-color="(variant:product contains Hồng)">
									<label for="data-color-p1" style="background-color: #ef5777"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p2" value="Vàng" name="color-filter" data-color="(variant:product contains Vàng)">
									<label for="data-color-p2" style="background-color: #ffd32a"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p3" value="Xám" name="color-filter" data-color="(variant:product contains Xám)">
									<label for="data-color-p3" style="background-color: #d2dae2"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p4" value="Xanh" name="color-filter" data-color="(variant:product contains Xanh)">
									<label for="data-color-p4" style="background-color: #3c40c6"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p5" value="Xanh lá" name="color-filter" data-color="(variant:product contains Xanh lá)">
									<label for="data-color-p5" style="background-color: #0be881"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p6" value="Sen" name="color-filter" data-color="(variant:product contains Sen)">
									<label for="data-color-p6" style="background-color: #f53b57"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p7" value="Xanh biển" name="color-filter" data-color="(variant:product contains Xanh biển)">
									<label for="data-color-p7" style="background-color: #0fbcf9"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p8" value="Đen" name="color-filter" data-color="(variant:product contains Đen)">
									<label for="data-color-p8" style="background-color: #000000"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p9" value="Trắng" name="color-filter" data-color="(variant:product contains Trắng)">
									<label for="data-color-p9" style="background-color: #ffffff"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p10" value="Đỏ" name="color-filter" data-color="(variant:product contains Đỏ)">
									<label for="data-color-p10" style="background-color: #ff3f34"></label>  
								</li>
								
								<li>
									<input type="checkbox" id="data-color-p11" value="Tím" name="color-filter" data-color="(variant:product contains Tím)">
									<label for="data-color-p11" style="background-color: #a55eea"></label>  
								</li>
							
								<li>
									<input type="checkbox" id="data-color-p12" value="Pure Apple" name="color-filter" data-color="(variant:product contains Pure Apple)">
									<label for="data-color-p12" style="background-color: #6ab04c"></label>  
								</li>
					
								<li>
									<input type="checkbox" id="data-color-p13" value="Blue" name="color-filter" data-color="(variant:product contains Blue)">
									<label for="data-color-p13" style="background-color: #0c2461"></label>  
								</li>
						
								<li>
									<input type="checkbox" id="data-color-p14" value="Cam" name="color-filter" data-color="(variant:product contains Cam)">
									<label for="data-color-p14" style="background-color: #fa8231"></label>  
								</li>
									
							</ul>
						</div>
					</div>
					
					<!-- ./filter size -->
					
					<div class="group-filter" aria-expanded="true">
						<div class="layered_subtitle dropdown-filter"><span>Kích thước</span><span class="icon-control"><i class='bx bx-minus'></i></span></div>
						<div class="layered-content filter-size s-filter">
							
							<ul class="check-box-list clearfix">
								
								<li>
									<input type="checkbox" id="data-size-p1" value="S" name="size-filter" data-size="(variant:product contains S)">
									<label for="data-size-p1">S</label>   
								</li>
								
								<li>
									<input type="checkbox" id="data-size-p2" value="M" name="size-filter" data-size="(variant:product contains M)">
									<label for="data-size-p2">M</label>   
								</li>
								
								<li>
									<input type="checkbox" id="data-size-p3" value="L" name="size-filter" data-size="(variant:product contains L)">
									<label for="data-size-p3">L</label>   
								</li>
								
								<li>
									<input type="checkbox" id="data-size-p4" value="XL" name="size-filter" data-size="(variant:product contains XL)">
									<label for="data-size-p4">XL</label>   
								</li>
								
							</ul>
						</div>
					</div>
					
				</div>
				

			</div>
		</div>
	</div>

</div>

						</div>
                    </div>
                    <div class="col l-9 m-12 c-12 ">
                        <div class="product-heading l-o-5">
                            <h3>Tất cả các sản phẩm</h3>
                        </div>
                        <%--  --%>
                        <div class="row " id="row" runat="server">     
                              <div class="page-control l-o-5">
                                  <span class="active">1</span>
                                  <span>2</span>
                                  <span><i class='bx bx-right-arrow-alt'></i></span>
                              </div>
                         </div>
                        <%--  --%>
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


    </div>

    </form>
    <script src="./js/base.css"></script>
    <script src="./js/procduct.js"></script>
</body>
</html>
