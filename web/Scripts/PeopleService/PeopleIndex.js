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
        vm.submitBtn = _submitBtn;
        vm.create = _create;
        vm.submitBtn2 = _submit2;
        vm.storeUser1;
        vm.deleteBtn = _deleteBtn;
        vm.currentIndex;


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
            $("#editBtn").addClass('hidden');
            vm.genericService.getById('/api/person/', Id)
                .then(_getUserByIdSuccess, _getUserByIdError);
        }
        function _getUserByIdSuccess(r) {
            vm.storeUser = r.data.Item;
            console.log('vm.storeUser', vm.storeUser);
        }
        function _getUserByIdError(r) {
            console.log(r, ":(");
        }
        function _submitBtn() {
            $("#editBtn").removeClass('hidden');
            console.log('vm.storeUser.Id: ', vm.storeUser.Id);
            vm.genericService.put('/api/person/', vm.storeUser.Id, vm.storeUser)
                .then(_updateSuccess, _updateError);
        }
        function _updateSuccess() {
            console.log('Update Success');
            vm.genericService.get('/api/person')
                .then(_getComplete);
            $("#modal").addClass('hidden');
        }
        function _updateError() {
            console.log(vm.storeUser);
            console.log('Update Error');
        }
        function _create() {
            console.log('Create Btn Clicked');
            $("#modal1").modal('show');
        }
        function _submit2() {
            console.log('SubmitBtn2 Clicked');
            vm.genericService.post('/api/person/manage', vm.storeUser1)
                .then(_postSuccess, _postError);
        }
        function _postSuccess() {
            console.log('success');
            vm.genericService.get('/api/person')
                .then(_getComplete);
            $("#modal1").modal('hide');
        }
        function _postError() {
            console.log(vm.storeUser1);
        }
        function _deleteBtn(Id, currentIndex) {
            console.log('DeleteBtn Clicked', Id);
             vm.currentIndex = currentIndex;
            return vm.genericService.delete('/api/person/', Id)
                .then(_deleteSuccess, _deleteError);
        }
        function _deleteSuccess(r) {
            console.log(r);
            vm.otherUserProfiles.splice(vm.currentIndex, 1);
            return;
        }
        function _deleteError(r) {
            console.log(r, ":(");
        }
    }
})();