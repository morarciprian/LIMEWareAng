(function () {
    var app = angular.module('limeware', []);

    app.controller('ParametersController', ['$scope', '$http', function ($scope, $http) {
        $scope.parameters = {};
        $scope.databalance = {};
        $scope.activeBalanceList = {};
        $scope.tempParameters = {};
        $scope.sendParameters = {};

        $scope.add = function () {
            $http.get('api/Parameter').success(function (response) {
                $scope.databalance = response;
            });
        };

        $scope.send = function () {
            $http.post('api/Parameter', $scope.sendParameters).success(function (response) {
                $scope.databalance = response;
            });
        };
    }]);

})();