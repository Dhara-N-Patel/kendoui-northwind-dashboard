$("#panel1").click(function () {
    if (document.getElementById('info-1-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-1-' + i).classList.remove('hide');
        }
        document.getElementById("panel1").classList.remove('fa-arrow-circle-down');
        document.getElementById("panel1").classList.add('fa-arrow-circle-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-1-' + i).classList.add('hide');
        }
        document.getElementById("panel1").classList.remove('fa-arrow-circle-up');
        document.getElementById("panel1").classList.add('fa-arrow-circle-down');
    }
});
$("#panel2").click(function () {
    if (document.getElementById('info-2-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-2-' + i).classList.remove('hide');
        }
        document.getElementById("panel2").classList.remove('fa-arrow-circle-down');
        document.getElementById("panel2").classList.add('fa-arrow-circle-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-2-' + i).classList.add('hide');
        }
        document.getElementById("panel2").classList.remove('fa-arrow-circle-up');
        document.getElementById("panel2").classList.add('fa-arrow-circle-down');
    }
});
$("#panel3").click(function () {
    if (document.getElementById('info-3-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-3-' + i).classList.remove('hide');
        }
        document.getElementById("panel3").classList.remove('fa-arrow-circle-down');
        document.getElementById("panel3").classList.add('fa-arrow-circle-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-3-' + i).classList.add('hide');
        }
        document.getElementById("panel3").classList.remove('fa-arrow-circle-up');
        document.getElementById("panel3").classList.add('fa-arrow-circle-down');
    }
});