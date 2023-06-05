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
//tăng giảm số lượng hàng
/*
function cong(){
    var t=document.getElementById("qnt").value;
    if(parseInt(t)<100){
 
       document.getElementById("qnt").value=parseInt(t)+1 ;
    }
 }
 function tru(){
 
    var tru =document.getElementById("qnt").value;
    if(parseInt(tru)>1){
 
       document.getElementById("qnt").value=parseInt(tru)-1 ;
    }
 }
 */

function cong(e) {
    e.target.previousSibling.value++;
}

function tru(e) {
    if (e.target.nextSibling.value > 1) {
        e.target.nextSibling.value--;
    }
}