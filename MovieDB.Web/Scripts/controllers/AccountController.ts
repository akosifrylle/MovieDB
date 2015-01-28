module movieDb.controllers {
    export class AccountController {
        private user: movieDb.models.User;

        constructor() {
            this.Initialize();
        }

        public Initialize() {
            this.user = new models.User();
            this.user.username = "username";
        }


    }

    angular.module('movieDb')
        .controller('AccountController', AccountController);
} 