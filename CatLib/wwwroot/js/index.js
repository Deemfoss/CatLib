const checkboxList = document.getElementsByClassName('checbox-list'),
    nameFilter = document.querySelectorAll('.name-filter');

function toggleSkills() {
    let itemClass = this.nextElementSibling;
    let arrow = this.children[1];
    if (itemClass.className === 'checbox-list checbox-list-close') {
        this.nextElementSibling.className = 'checbox-list checbox-list-open';
        arrow.classList.add('arrow-filter-open');
        return;
    }
    if (itemClass.className === 'checbox-list checbox-list-open') {
        this.nextElementSibling.className = 'checbox-list checbox-list-close';
        arrow.classList.remove('arrow-filter-open');
        return;
    }
}
   


    nameFilter.forEach((el) => {
        el.addEventListener('click', toggleSkills);
    })


    function clearFilter() {
        var checkboxes = document.getElementsByClassName("checbox-filter");

        for (var i = 0; i < checkboxes.length; i++) {

            checkboxes[i].checked = false;
        }
}



