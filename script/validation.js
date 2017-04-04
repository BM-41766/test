function firstnamvalidate() {
    var fn = document.getElementById("fname").value;
    if (fn == "") {
        //document.getElementById("fname").value = "";
        document.getElementById("fname").style.backgroundColor = "#f41122";

    }
    else
    {
        document.getElementById("fname").style.backgroundColor = "#FFFFFF";
    }

}

function emailvalidate() {
    var fn = document.getElementById("eml").value;
    if (fn == "") {
        //document.getElementById("fname").value = "";
        document.getElementById("eml").style.backgroundColor = "#f41122";


    }
    else {
        document.getElementById("eml").style.backgroundColor = "#FFFFFF";
    }
}
function addressvalidate() {
    var fn = document.getElementById("adres").value;
    if (fn == "") {
        //document.getElementById("fname").value = "";
        document.getElementById("adres").style.backgroundColor = "#f41122";


    }
    else {
        document.getElementById("adres").style.backgroundColor = "#FFFFFF";
    }
}

function passwordvalidate() {
    var fn = document.getElementById("paswrd").value;
    if (fn == "") {
        //document.getElementById("fname").value = "";
        document.getElementById("paswrd").style.backgroundColor = "#f41122";


    }
    else {
        document.getElementById("paswrd").style.backgroundColor = "#FFFFFF";
    }
}
