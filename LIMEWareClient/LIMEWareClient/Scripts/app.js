(function () {
    var app = angular.module('limeware', []);

    app.controller('ParametersController', ['$scope', '$http', function ($scope, $http) {
        $scope.parameters = {};
        $scope.databalance = {};
        $scope.activeBalanceList = {};

        $scope.add = function () {

            $http.get('api/Parameter').success(function (response) {
                $scope.databalance = response;
            });
        };
    }]);

})();