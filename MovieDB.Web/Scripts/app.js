var app = angular.module('movieDB', ['ngRoute']);

app.config(function ($routeProvider) {

    $routeProvider.when('/try', {
        controller: 'SampleController',
        templateUrl: 'PartialViews/List.html'
});

});

app.controller('SampleController', function($scope)
{
    $scope.students = [{ name: "Frylle", course: "BIT" }, { name: "Jasper", course: "BIT" }];
    $scope.fruit = "Apple";
});