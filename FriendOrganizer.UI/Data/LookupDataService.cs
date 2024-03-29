﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class LookupDataService : IFriendLookupDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public LookupDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendsLookupAsync()
        {
            try
            {
                using (var ctx = _contextCreator())
                {
                    return await ctx.Friends.AsNoTracking()
                        .Select(f => new LookupItem
                            {
                                Id = f.Id,
                                DisplayMember = f.FirstName + " " + f.LastName
                        }
                        ).ToListAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
