var MyApp = angular.module('MyApp',[])
    .controller('RateController', function ($scope, $http, RateService) {
        RateService.GetAgentLists().then(function (d){
            $scope.AgentList = d.data;
        });
        RateService.GetPlanLists().then(function (d) {
            $scope.PlanList = d.data;
        });
        RateService.GetRoomTypeLists().then(function (d) {
            $scope.RoomTypeList = d.data;
        });
        RateService.GetRateList().then(function (d) {
            $scope.RateList = d.data;
        });
        $scope.UpdateRate = (function (index) {
            var id = $scope.RateList[index].Id;
            var amount = $scope.RateList[index].Amount;
            var expCharge = $scope.RateList[index].ExtraPersonCharge;
            var data = {"id":id,"amount":amount,"expcharge":expCharge};
            
            RateService.UpdateRateValue(JSON.stringify(data)).then(function (d) {
                RateService.GetRateList().then(function (c) {
                    $scope.RateList = c.data;
                });
            });
        });
    })
    .factory('RateService', function ($http) {
        var fac = {};
        fac.GetAgentLists = function () {
            return $http.get('/Rate/GetAgentList');
        };

        fac.GetPlanLists = function () {
            return $http.get('/Rate/GetPlanList');
        }

        fac.GetRoomTypeLists = function () {
            return $http.get('/Rate/GetRoomTypeList');
        }

        fac.GetRateList = function () {
            return $http.get('/Rate/GetRateList');
        }

        fac.UpdateRateValue = function (data) {
            console.log(data);
            return $http.post('/Rate/UpdateRateValue/?data='+ data);
        }
        return fac;
    });