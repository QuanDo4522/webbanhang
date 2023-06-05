"use strict";

const imagesContainer = document.querySelector(".product__content-feature");
let imagesContainerHeight = imagesContainer.offsetHeight;
console.log(imagesContainerHeight)
// menu
const iconMenu = document.querySelector(".header-menu-icon")

iconMenu.onclick = (e) => {
    console.log(e);
    console.log(e.target);
    e.target.style.display = 'none';
    document.querySelector('.header-menu-icon-2').style.display = 'inline';
    document.querySelector('.icon-2').style.display = 'inline';
    document.querySelector('.menu-content').style.zIndex = 1;
    document.querySelector('.menu-content').style.opacity = 1;
}
const iconMenu2 = document.querySelector(".header-menu-icon-2");
iconMenu2.onclick = (e) => {
    console.log(e);
    console.log(e.target);
    e.target.style.display = 'none';
    document.querySelector('.icon-1').style.display = 'inline';
    document.querySelector('.menu-content').style.zIndex = 1;
    document.querySelector('.menu-content').style.opacity = 0;
}

//sự kiện click ảnh 
// let imgFeature=document.querySelector('.product__content-feature-img');
// const listImg=document.querySelectorAll('.product__content-gallery img');
// let currentIndex=0;
// function updateImageByIndex(index){
//   //remove active class
//   document.querySelectorAll('.product__content-gallery-img.active').forEach(item=>{
//      item.classList.remove('active');

//   })

//    currentIndex=index;
//    imgFeature.src=listImg[index].getAttribute('src');
//     listImg[index].classList.add('active');

// }

// listImg.forEach( (imgElement,index)=>{
//    imgElement.addEventListener('click',e=>{

//       updateImageByIndex(index)
//       const imagesContainer = document.querySelector(".product__content-feature");
// let imagesContainerHeight = imagesContainer.offsetHeight;
// console.log(imagesContainerHeight)
// imagesContainer.style.transform = `translateY(-${imagesContainerHeight}px)`;

//    })
// })

// click ảnh
const ProductClick = (() => {
    const sliderImg = Array.from(document.getElementsByClassName("product__content-gallery-img"));
    console.log(sliderImg)
    sliderImg.forEach((button, currentIndex) => {
        button.addEventListener("click", () => {
            console.log(currentIndex)
            const ImgButtonActive = document.querySelector(".product__content-gallery-img.active")
            const imagesContainer = document.querySelector(".product__content-feature");
            const images = document.querySelector(".product__content-feature-img");
            let imagesContainerHeight = imagesContainer.offsetHeight;
            let imageHeight = images.offsetHeight;
            console.log(imagesContainerHeight)
            console.log(imageHeight)
            ImgButtonActive.classList.remove("active");
            button.classList.add("active");
            imagesContainer.style.transform = `translateY(-${imageHeight * (currentIndex)}px)`;
        });
    });
})();





















//Circle button
const circleClick = (() => {
    const sliderButtons = Array.from(document.getElementsByClassName("gallery__circle"));
    console.log(sliderButtons)
    sliderButtons.forEach((button, currentIndex) => {
        button.addEventListener("click", () => {
            const sliderButtonActive = document.querySelector(".gallery__circle.active")
            const imagesContainer = document.querySelector(".product__content-feature");
            let imagesContainerWidth = imagesContainer.offsetWidth;
            console.log(imagesContainerWidth)
            sliderButtonActive.classList.remove("active");
            button.classList.add("active");
            imagesContainer.style.transform = `translateX(-${imagesContainerWidth * currentIndex}px)`;
        });
    });
})();


//sự kiện click số lượng
let Productprice = document.querySelector('.pro-price');
const listPrice = document.querySelectorAll('.product__content-details-quantity.product__content-details-quantity-item');
let IndexCurrent = 0;
function updatePriceByIndex(index) {
    //remove dark class
    document.querySelectorAll('.product__content-details-quantity-item-dark').forEach(item => {
        item.classList.remove('product__content-details-quantity-item-dark');

    })

    //    IndexCurrent=index;
    //    Productprice.src=listPrice[index].getAttribute('');
    //     listPrice[index].classList.add('product__content-details-quantity-item-dark');

}

listPrice.forEach((PriceElement, index) => {
    imgElement.addEventListener('click', e => {

        updatePriceByIndex(index)

    })
})


//tăng giảm số lượng hàng
function cong() {
    var t = document.getElementById("qnt").value;
    if (parseInt(t) < 100) {

        document.getElementById("qnt").value = parseInt(t) + 1;
    }
}
function tru() {

    var tru = document.getElementById("qnt").value;
    if (parseInt(tru) > 1) {

        document.getElementById("qnt").value = parseInt(tru) - 1;
    }
}

