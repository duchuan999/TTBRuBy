
function chonttb(_ttb) {
    var curV = $(_ttb).val();
    var curT=$(_ttb).text();
        $.post('/find_ttb',{ id: $("#nhapct_dmttb_id").val()}, function (json) {
            string = "";
            for (i = 0; i < json.length; i++) {
                string += json[i].ma;
            }

        });
    $("#nhapct_dongia").value=curV;
}
