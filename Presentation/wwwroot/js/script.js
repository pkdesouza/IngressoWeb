var app = new Vue({
	el:'#app',
    data: {
        zipCode: $('.zipCode').val(),
        city: $('.city').val(),
        state: $('.state').val(),
        street: $('.street').val(),
        urlCep: 'https://viacep.com.br/ws/{0}/json/',
        zipCodeAlert: '',
        response: {}
	},
	filters : {
		
	},
	computed:{
		
	},
	watch: {

	},
	methods:{
		Init : function() {
            console.log("Vue JS");
		},
        zipCodeEvent: function () {
            if (/^[0-9]{8}$/.test(this.zipCode)) {
                url = this.urlCep.replace("{0}", this.zipCode);
                $.get(url, function (data, status) {
                    app.response = data;
                    app.ReloadValues();
                });
            }
            else
                this.zipCodeAlert = "Cep deve ter 8 dígitos";
        },
        ReloadValues: function () {
            this.street = this.response.logradouro;
            this.city = this.response.localidade;
            this.state = this.response.uf;
            this.zipCodeAlert = "";
		}
	}
});

app.Init();
