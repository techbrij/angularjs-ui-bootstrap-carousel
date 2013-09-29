//Created by: http://techbrij.com

angular.module('myModule', ['ui.bootstrap']);
function myController($scope,$http) {
    $scope.myInterval = 5000;
    $scope.slides = [];
    $http({
        method: 'Get',
        url: '/Home/GetData'
    }).success(function (data, status, headers, config) {
        $scope.slides = data;
    }).error(function (data, status, headers, config) {
        $scope.message = 'Unexpected Error';
    });
}