/// <reference path="typings/angularjs/angular.d.ts" />
module  movieDb {
    var app = angular.module('movieDb', ['ngRoute', 'ngResource']);

    app.config(['$routeProvider',($routeProvider: ng.route.IRouteProvider)=> {
        $routeProvider
            .when('/try', {
                controller: 'SampleController',
                templateUrl: 'PartialViews/List.html'
            })
            .when('/register', {
                controller: 'AccountController',
                templateUrl: 'PartialViews/Account/Signup.html'
            });
    }]);

    //app.controller('SampleController',  ($scope)=> {
    //    $scope.students = [{ name: "Frylle", course: "BIT" }, { name: "Jasper", course: "BCS" }];
    //    $scope.fruit = "Apple";
    //    $scope.addStudent =  () => {
    //        $scope.students.push({
    //            name: $scope.newStudent.name,
    //            course: $scope.newStudent.course
    //        });
    //    };
    //});
} 