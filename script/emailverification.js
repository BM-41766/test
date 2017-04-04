function validateForm() {
    var x = document.forms["email"].value;
    var atsym = x.indexOf("@");
    var dotsym = x.lastIndexOf(".");
    if (atsym < 1 || dotsym < atpos + 2 || dotsym + 2 >= x.length) {
        alert("Not a valid e-mail address");
        return false;
    }
}