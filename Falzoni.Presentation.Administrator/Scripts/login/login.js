falzoni.login = {
    registerComponents: function () {
        //$(".form-signin").submit(falzoni.login.personalizarBotao);
        $(".form-signin").submit(falzoni.core.configurations.showLoading);

        falzoni.core.configurations.autoLoad();
    },

    //personalizarBotao: function () {
    //    $(".btn-primary").attr("disabled", "disabled").html("<i class='fa fa-spinner fa-pulse' ></i> Entrando...");
    //    return true;
    //}
}

$(document).ready(falzoni.login.registerComponents());