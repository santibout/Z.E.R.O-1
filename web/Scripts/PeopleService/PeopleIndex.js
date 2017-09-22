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
    }
})();