var FollowService = function () {
    var createFollow = function (followeeId, done, fail) {
        $.post("/api/following", { followeeId: followeeId })
            .done(done)
            .fail(fail);
    };

    var deleteFollow = function (followeeId, done, fail) {
        $.ajax({
            url: "/api/following/" + followeeId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        createFollow: createFollow,
        deleteFollow: deleteFollow
    };

}();