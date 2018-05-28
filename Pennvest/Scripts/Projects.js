$("#panel1").click(function () {
    if (document.getElementById('info-1-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-1-' + i).classList.remove('hide');
        }
        document.getElementById("panel1").classList.remove('k-i-arrow-down');
        document.getElementById("panel1").classList.add('k-i-arrow-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-1-' + i).classList.add('hide');
        }
        document.getElementById("panel1").classList.remove('k-i-arrow-up');
        document.getElementById("panel1").classList.add('k-i-arrow-down');
    }
});
$("#panel2").click(function () {
    if (document.getElementById('info-2-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-2-' + i).classList.remove('hide');
        }
        document.getElementById("panel2").classList.remove('k-i-arrow-down');
        document.getElementById("panel2").classList.add('k-i-arrow-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-2-' + i).classList.add('hide');
        }
        document.getElementById("panel2").classList.remove('k-i-arrow-up');
        document.getElementById("panel2").classList.add('k-i-arrow-down');
    }
});
$("#panel3").click(function () {
    if (document.getElementById('info-3-1').classList.contains('hide')) {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-3-' + i).classList.remove('hide');
        }
        document.getElementById("panel3").classList.remove('k-i-arrow-down');
        document.getElementById("panel3").classList.add('k-i-arrow-up');
    }
    else {
        for (var i = 1; i < 10; i++) {
            document.getElementById('info-3-' + i).classList.add('hide');
        }
        document.getElementById("panel3").classList.remove('k-i-arrow-up');
        document.getElementById("panel3").classList.add('k-i-arrow-down');
    }
});