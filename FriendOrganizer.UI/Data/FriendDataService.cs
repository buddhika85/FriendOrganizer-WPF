using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Friend> GetFriendByIdAsync(int friendId)
        {
            try
            {
                //yield return new Friend { FirstName = "Buddhika", LastName = "Gunasekera", Email = "buddhika@gmail.com" };
                //yield return new Friend { FirstName = "Sheldon", LastName = "Cooper", Email = "sheldon@gmail.com" };
                //yield return new Friend { FirstName = "Lenerd", LastName = "Hofstater", Email = "lenerd@gmail.com" };
                //yield return new Friend { FirstName = "Howard", LastName = "Wollawitz", Email = "howard@gmail.com" };
                //yield return new Friend { FirstName = "Rajesh", LastName = "Kuthrapalli", Email = "rajesh@gmail.com" };
                //yield return new Friend { FirstName = "Penny", LastName = "Hofstater", Email = "penny@gmail.com" };

                using (var ctx = _contextCreator())
                {
                    var friend = await ctx.Friends.AsNoTracking().SingleAsync(x => x.Id == friendId);
                    return friend;
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
