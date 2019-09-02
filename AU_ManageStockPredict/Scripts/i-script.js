function validateEmail(email) {
    var rex = /^(((([a-zA-Z0-9\_\-]{1,50})+(([\.]{1,50}[a-zA-Z0-9\_\-]{1,50}){0,50})){1,95})+@([\w-]+\.)+[\w-]{2,4})?$/;

    if (email.substr(0, 2) == "-@" || email.substr(0, 2) == "_@")
        return false;

    if (rex.test(email))
        return true;
    else
        return false;
}

function redirect(url) {
    window.location.href = url;
}
