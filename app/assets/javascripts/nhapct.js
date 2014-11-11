
function chonttb() {
    var curV = $("#nhapct_dmttb_id").val();
        $.post("/find_ttb",{id: curV}, function (json) {
            string = "aaa";
            for (i = 0; i < json.length; i++) {
                string += json[i].ma;
            }

        });
    $("#nhapct_dongia").value=curV;
}
