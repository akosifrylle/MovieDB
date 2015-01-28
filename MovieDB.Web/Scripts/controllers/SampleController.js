/// <reference path="../typings/angularjs/angular.d.ts" />
var movieDb;
(function (movieDb) {
    var controllers;
    (function (controllers) {
        var SampleController = (function () {
            function SampleController() {
                this.initiliaze();
            }
            SampleController.prototype.initiliaze = function () {
                this.fruit = 'tomotoe';
            };
            SampleController.prototype.AddStudent = function () {
                this.students.push(this.student);
            };
            return SampleController;
        })();
        controllers.SampleController = SampleController;
        angular.module('movieDb').controller('SampleController', SampleController);
    })(controllers = movieDb.controllers || (movieDb.controllers = {}));
})(movieDb || (movieDb = {}));
//# sourceMappingURL=SampleController.js.map