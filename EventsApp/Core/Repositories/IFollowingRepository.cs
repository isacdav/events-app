﻿using EventsApp.Core.Models;

namespace EventsApp.Core.Repositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string userId, string artistId);
        void Add(Following following);
        void Remove(Following following);
    }
}