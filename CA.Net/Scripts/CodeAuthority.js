


$("#CAContactForm").validate({
    submitHandler: function (form) {
        $(form).ajaxSubmit();
    }
});

$('.error').on('change', function (e) {
    alert('removing error');
        $(this).removeClass("error");
        $(this).next('.messagearea').remove();

});

function isValid(element) {
    if (isBlank($(element).val())) {
        DisplayError($(element),null);
        return false;
    } else {
        return true;
    }

}

function isBlank(val) {
    if (val === '') {
        return true;
    } else {
        return false;
    }

}

function DisplayError(obj, msg) {
    if (!msg) msg = 'Field Cannot be Blank';
    $(obj).addClass('error');
    $(obj).next('.messagearea').remove();
    $(obj).after('<span class="messagearea">'+msg+'</span>');

}

function ClearForm() {

    $(".messagearea").remove();
}

$('#datetimepicker1').datetimepicker({
    daysOfWeekDisabled: [0, 6],
    stepping: 15
});