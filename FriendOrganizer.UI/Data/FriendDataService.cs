using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Buddhika", LastName = "Gunasekera", Email = "buddhika@gmail.com" };
            yield return new Friend { FirstName = "Sheldon", LastName = "Cooper", Email = "sheldon@gmail.com" };
            yield return new Friend { FirstName = "Lenerd", LastName = "Hofstater", Email = "lenerd@gmail.com" };
            yield return new Friend { FirstName = "Howard", LastName = "Wollawitz", Email = "howard@gmail.com" };
            yield return new Friend { FirstName = "Rajesh", LastName = "Kuthrapalli", Email = "rajesh@gmail.com" };
            yield return new Friend { FirstName = "Penny", LastName = "Hofstater", Email = "penny@gmail.com" };
        }
    }
}
