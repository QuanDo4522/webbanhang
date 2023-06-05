const listNav = document.querySelectorAll(".header_nav-items")
console.log(listNav)

listNav.forEach((navItem) => {
    console.log(navItem)
    navItem.onclick = function() {
        document.querySelector('.header_nav-items.active').classList.remove('active');
        this.classList.add('active');
    }

})




const circleClick = (() => {
    const sliderButtons = Array.from(document.getElementsByClassName("slider__circle"));
    sliderButtons.forEach((button, currentIndex) => {
        button.addEventListener("click", () => {
            const sliderButtonActive = document.querySelector(".slider__circle.active")
            const imagesContainer = document.querySelector(".slider__images-container");
            let imagesContainerWidth = imagesContainer.offsetWidth;
            sliderButtonActive.classList.remove("active");
            button.classList.add("active");
            imagesContainer.style.transform = `translateX(-${imagesContainerWidth * currentIndex}px)`;
        });
    });
})();

const slideAutoPlay = (() => {
    const sliderButtons = Array.from(document.getElementsByClassName("slider__circle"));
    const imagesContainer = document.querySelector(".slider__images-container");
    let currentIndex = 0;
    setInterval(() => {
        let imagesContainerWidth = imagesContainer.offsetWidth;
        const sliderButtonActive = document.querySelector(".slider__circle.active")
        if (currentIndex == 2) currentIndex = -1;
        currentIndex++;
        sliderButtonActive.classList.remove("active");
        sliderButtons[currentIndex].classList.add("active");
        imagesContainer.style.transform = `translateX(-${imagesContainerWidth * currentIndex}px)`;
    },7500);
})();

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

