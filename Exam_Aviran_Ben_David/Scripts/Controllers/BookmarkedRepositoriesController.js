angular.module('exam')
.controller('BookmarkedRepositoriesController', function ($scope, BookmarkedRepositoriesService) {
    $scope.repositories = [];

    $scope.GetRepositories = function () {
        BookmarkedRepositoriesService.GetRepositories($scope.query).then(function (d) { $scope.repositories = d.data });
    }

    $scope.GetRepositories();
}).factory('BookmarkedRepositoriesService', function ($http) {
    return {
        GetRepositories: function (query) {
            return $http.get('/Repository/GetBookmarkedRepositories');
        }
    }
})