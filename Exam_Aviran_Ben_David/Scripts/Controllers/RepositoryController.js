angular.module('exam')
.controller('RepositoryController', function ($scope, RepositoryService) {
    $scope.query = '';
    $scope.repositories = [];

    $scope.GetRepositories = function () {
        $scope.repositories = [];

        if ($scope.query != '') {
            RepositoryService.GetRepositories($scope.query).then(function (d) { $scope.repositories = d.data.items; });
        }
    }

    $scope.Bookmark = function (repository) {
        RepositoryService.Bookmark(repository).then(function (d) { repository.bookmarked = true; })
    }
})
.factory('RepositoryService', function ($http) {
    return {
        GetRepositories: function (query) {
            return $http.get('https://api.github.com/search/repositories?q=' + query);
        },
        Bookmark:function(repository){
            return $http.post('/Repository/Bookmark', repository);
        }
    }
})