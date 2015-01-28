/// <reference path="typings/angularjs/angular.d.ts" />
var movieDb;
(function (movieDb) {
    var app = angular.module('movieDb', ['ngRoute', 'ngResource']);
    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/try', {
            controller: 'SampleController',
            templateUrl: 'PartialViews/List.html'
        }).when('/register', {
            controller: 'AccountController',
            templateUrl: 'PartialViews/Account/Signup.html'
        });
    }]);
})(movieDb || (movieDb = {}));
//# sourceMappingURL=app.js.map