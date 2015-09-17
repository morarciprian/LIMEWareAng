(function () {
    var app = angular.module('limeware', []);

    app.controller('ParametersController', function () {
        this.parameters = paramTemplates;
    });

    var paramTemplates = [
        {
            msisdn: '0752068078',
            value: '10',
            expiry: '5',
            canShow: true,
            exists: true,
        },
        {
             msisdn: '0752068078',
             value: '20',
             expiry: '5',
             canShow: true,
             exists: true,
        },
        {
              msisdn: '0752068078',
              value: '30',
              expiry: '5',
              canShow: true,
              exists: true,
        }


    ];
})();