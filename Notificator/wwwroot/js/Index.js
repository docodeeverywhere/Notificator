
function BeforeSend(e) {

    var token = $("#inpAppToken")[0];
    if (token.value.length == 0) {
        alert('The app token field is empty!');
        return;
    }

    var userKey = $("#inpUserKey")[0];
    if (userKey.value.length == 0) {
        alert('The user key field is empty!');
        return;
    }

    var message = $("#inpMessage")[0];
    if (message.value.length == 0) {
        alert('The message field is empty!');
        return;
    
    }
    
    var form = $("#MainForm")[0];
    form.submit();
}