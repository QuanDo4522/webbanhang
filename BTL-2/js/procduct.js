// product
// bo loc sp
const tilted_up = document.querySelector('.title_block .up');
const controllerFilter = document.querySelector('.title_block')

controllerFilter.onclick = () =>{
    if(document.querySelector('.block_content').style.display =='none'){

        document.querySelector('.block_content').style.display = 'block';
    }
    else
    {
        document.querySelector('.block_content').style.display = 'none'
    }

}