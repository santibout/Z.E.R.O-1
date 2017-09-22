(function () {

    angular.module('mainApp')
        .controller('PeopleController', PeopleController);
    PeopleController.$inject = ['$scope', 'genericService', '$window'];

    function PeopleController($scope, genericService, $window) {
        var vm = this;
        vm.$scope = $scope;
        vm.genericService = genericService;
        vm.$onInit = _init;
        vm.myUserProple;
        vm.otherUserProfiles = [];
        vm.editBtn = _editButton;
        vm.storeUser = [];


        function _init() {
            console.log('Angular Starting Up!');
            vm.genericService.get('/api/person')
                .then(_getComplete);
        }
        function _getComplete(r) {
            vm.otherUserProfiles = r.data.Items;
            console.log('Other Users', vm.otherUserProfiles);
            vm.myUserProple = r.data.Items[0].FirstName + ' ' + r.data.Items[0].LastName;
            console.log('This is the Users Name: ' + vm.myUserProple);
        }
        function _editButton(Id) {
            // $window.location.href = '/people/manage/' + Id;
            console.log("Edit Btc Clicked");
            $("#modal").removeClass('hidden');
            vm.genericService.getById('/api/person/', Id)
                .then(_getUserByIdSuccess, _getUserByIdError);
        }
        function _getUserByIdSuccess(r) {
            vm.storeUser = r.data.Item;
            console.log(vm.storeUser);
        }
        function _getUserByIdError(r) {
            console.log(r, ":(");
        }

    }
})();