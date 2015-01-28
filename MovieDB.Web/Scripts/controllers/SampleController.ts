/// <reference path="../typings/angularjs/angular.d.ts" />
module movieDb.controllers {
    export class SampleController {
        private students: Object[];
        private student: Object;
        private fruit: string;

        constructor() {
            this.initiliaze();
        }

        public initiliaze() {
            this.fruit = 'tomotoe';
        }

        public AddStudent() {
            this.students.push(this.student);
        }
    }

    angular.module('movieDb')
        .controller('SampleController', SampleController);
} 