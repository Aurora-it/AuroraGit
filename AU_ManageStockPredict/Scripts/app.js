var app = {};
if (!app.validation) {
    var validation = (function () {
        var ctor = function () {
            var that = this;

            this.exec = function (o) {
                var $valid = true;
                $.each(o, function (i, e) {
                    var id = "#" + e.id;
                    var label = e.label;
                    var required = e.required == undefined ? true : e.required;
                    var number = e.number;
                    var digits = e.digits;
                    var min = parseFloat(e.min);
                    var minLength = e.minLength;
                    var email = e.email;

                    var errorId = id + "-error";
                    var val = $.trim($(id).val());
                    var errorMessage = "";

                    var c = true;
                    if (val == "" && required) {
                        if (label == undefined)
                            errorMessage = "• กรุณาระบุข้อมูล";
                        else
                            errorMessage = "• กรุณาระบุ " + label;

                        $valid = c = false;
                    }
                    else if (number && val != "") {
                        c = !isNaN(val);
                        if ($valid) { $valid = c; }

                        if (!c) {
                            errorMessage = "• กรุณากรอกตัวเลขให้ถูกต้อง";
                        }
                        else {
                            if (parseFloat(val) < min && min != undefined) {
                                errorMessage = "• ข้อมูลต้องมีค่าไม่น้อยกว่า " + min;
                                $valid = c = false;
                            }
                        }
                    }
                    else if (digits && val != "") {
                        var regDigits = /^[0-9]+$/;
                        if (val.match(regDigits) == null) {
                            errorMessage = "• กรุณากรอกตัวเลข 0-9";
                            $valid = c = false;
                        } else {
                            if (parseFloat(val) < min && min != undefined) {
                                errorMessage = "• ข้อมูลต้องมีค่าไม่น้อยกว่า " + min;
                                $valid = c = false;
                            }
                        }
                    }
                    else if (email && val != "") {
                        var regEmail = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
                        c = regEmail.test(val.toLowerCase());
                        if ($valid) { $valid = c; }
                        if (!c) {
                            errorMessage = "• กรุณากรอกอีเมลให้ถูกต้อง";
                        }
                    }

                    if (c) {
                        if (minLength) {
                            if (val.length < minLength) {
                                errorMessage = "• ข้อมูลต้องมีจำนวนไม่น้อยกว่า " + minLength + " ตัวอักษร";
                                $valid = c = false;
                            }
                        }
                    }

                    if (!c) {
                        if ($(errorId).length > 0) {
                            $(errorId).remove();
                        }
                     
                        if ($(id)[0].className.indexOf('select2') != -1) {
                            $(id).next().after("<label id='" + e.id + "-error' class='error'>" + errorMessage + "</label>");
                        } else {
                            $(id).after("<label id='" + e.id + "-error' class='error'>" + errorMessage + "</label>");
                        }
                        $(id).parent().removeClass("success").addClass("error");
                        $(id).focus();
                    }
                    else {
                        $(errorId).remove();
                        $(id).parent().removeClass("error").addClass("success");
                    }

                });

                return $valid;
            }

            this.custom = function (o) {
                var $valid = true;
                $.each(o, function (i, e) {
                    var id = "#" + e.id;
                    var errorId = id + "-error";
                    var error = e.error == undefined ? true : e.error;
                    var errorMessage = e.message == undefined ? "• ข้อมูลไม่ถูกต้อง" : e.message;

                    if (error) {
                        if ($(errorId).length > 0) {
                            $(errorId).remove();
                        }
                        $(id).after("<label id='" + e.id + "-error' class='error'>" + errorMessage + "</label>");
                        $(id).parent().removeClass("success").addClass("error");
                        $(id).focus();
                        $valid = false;
                    }
                    else {
                        $(errorId).remove();
                        $(id).parent().removeClass("error").addClass("success");
                    }
                });

                return $valid;
            }

            this.clear = function (o) {
                $.each(o, function (i, e) {
                    var id = "#" + e.id;
                    var errorId = $(id + "-error");
                    $(errorId).remove();
                    $(id).parent().removeClass("error").addClass("success");
                });
            }

            this.resetForm = function (id) {
                $("#" + id + " input").val("");
                $("#" + id + " textarea").val("");
                $("#" + id + " select").val("");
                $("#" + id + " .error").removeClass("error");
                $("#" + id + " .success").removeClass("success");
                $("#" + id + " .error").remove();
                $("#" + id + " [id*=-error]").remove();
            }

            this.resetValidate = function (id) {
                $("#" + id + " .error").removeClass("error");
                $("#" + id + " .success").removeClass("success");
                $("#" + id + " .error").remove();
                $("#" + id + " [id*=-error]").remove();
            }

        }
        return ctor;
    })();
    app.validation = new validation();
}