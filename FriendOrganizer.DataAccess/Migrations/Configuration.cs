using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend {FirstName = "Buddhika", LastName = "Gunasekera", Email = "buddhika@gmail.com"},
                new Friend {FirstName = "Sheldon", LastName = "Cooper", Email = "sheldon@gmail.com"},
                new Friend {FirstName = "Lenerd", LastName = "Hofstater", Email = "lenerd@gmail.com"},
                new Friend {FirstName = "Howard", LastName = "Wollawitz", Email = "howard@gmail.com"},
                new Friend {FirstName = "Rajesh", LastName = "Kuthrapalli", Email = "rajesh@gmail.com"},
                new Friend {FirstName = "Penny", LastName = "Hofstater", Email = "penny@gmail.com"}
            );
        }
    }
}
