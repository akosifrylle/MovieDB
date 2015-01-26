var app = angular.module('movieDB', ['ngRoute']);

app.config(function ($routeProvider) {

    $routeProvider.when('/try', {
        controller: 'customersController',
        templateUrl: 'PartialViews/List.html'
});

});