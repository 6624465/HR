app.module('companApp').contoller('companyController', ['$scope', '$http'], function ($scope, $http) {
    debugger
    $scope.init = function () {
        $scope.CompanyCode='',
        $scope.CompanyName='',
        $scope.RegNo='',
        $scope.Address = {
            Address1: '',
            Address2: '',
            CityName: '',
            StateName: '',
            ZipCode: '',
            MobileNo: '',
            FaxNo: '',
            Email:''
        }
        $scope.getCountries = function () {
            debugger
            $http.get("/Company/Master").then(function (response) {
                if (response.countryViewModelList != null) {
                    return response.countryViewModelList;
                }
            });
        }
    }


})