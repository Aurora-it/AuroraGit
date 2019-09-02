function dtActive(x) {
    return x ? "<i class='fa fa-check success'></i>" : "<i class='fa fa-times danger'></i>";
}

function dtActive2(x) {
    var a = '';
    if (x) {
        a = "<i class='fa fa-check success'></i>";
    }
    return a;
}

function nvl(value) {
    return (value == null || value == 'null') ? '' : value;
}

function nvl2(value, value2) {
    return nvl(value) == '' ? (value2 == undefined ? "" : value2) : value;
}

function toDateTimeDb(dt) {
    var sp = dt.split('/');
    if (sp.length > 2) {
        var date = '';
        var time = '';
        var sp2 = sp[2].split(' ');
        if (sp2.length > 1) {
            date = sp2[0] + "-" + sp[1] + "-" + sp[0];
            time = " " + sp2[1];
        }
        else {
            date = sp[2] + "-" + sp[1] + "-" + sp[0];
        }

        return date + time;
    }
    return dt;
}

function splDash2(x) {
    var spl = x.split('-');
    var o = {
        a: $.trim(spl[0]),
        b: $.trim(spl[1]),
    };
    return o;
}

function getTimeKey(x) {
    return x.replace(/:/g, '_').replace(/' '/g, '');
}

function initFromToDate(from, to) {
    var from_$input = $('#' + from).pickadate({
        format: 'dd/mm/yyyy'
    }),
        from_picker = from_$input.pickadate('picker');

    var to_$input = $('#' + to).pickadate({
        format: 'dd/mm/yyyy'
    }),
        to_picker = to_$input.pickadate('picker');


    // Check if there’s a “from” or “to” date to start with.
    if (from_picker.get('value')) {
        to_picker.set('min', from_picker.get('select'));
    }
    if (to_picker.get('value')) {
        from_picker.set('max', to_picker.get('select'));
    }

    // When something is selected, update the “from” and “to” limits.
    from_picker.on('set', function (event) {
        if (event.select) {
            to_picker.set('min', from_picker.get('select'));
        }
        else if ('clear' in event) {
            to_picker.set('min', false);
        }
    });
    to_picker.on('set', function (event) {
        if (event.select) {
            from_picker.set('max', to_picker.get('select'));
        }
        else if ('clear' in event) {
            from_picker.set('max', false);
        }
    });
}