using Examensarbete.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace Examensarbete.Data
{
    public class alsDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectCollaborator> ProjectCollaborators { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<Language> Languages { get; set; }
        public alsDbContext(DbContextOptions<alsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().HasData(new User()
            //{
            //    Id = 1,
            //    PublicId = Guid.Parse("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"),
            //    Username = "Clockvice",
            //    Email = "Clockvice@gmail.com",
            //    Password = "TestPassword"
            //});
            //modelBuilder.Entity<User>().HasData(new User()
            //{
            //    Id = 2,
            //    PublicId = Guid.Parse("B95E3ECF-A882-4662-B4B1-6D1CD8259F9C"),
            //    Username = "Vorso",
            //    Email = "testcollaborator@email.com",
            //    Password = "TestPassword"
            //});
            //modelBuilder.Entity<Project>().HasData(new Project() { Id = 1, PublicId = Guid.Parse("E1AED9E5-15BF-4831-A00F-68459C2DBD55"), OwnerPublicId = Guid.Parse("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), CreatedDate = DateTime.Today, DriveItemId = "FFAE75F410E7D5E9!116", FileSize = 28778828, LastEditedDate = DateTime.Now, ProjectFileName = "Dubstep Heater v12" });
            //modelBuilder.Entity<Project>().HasData(new Project() { Id = 2, PublicId = Guid.Parse("8818E9C4-F3DE-47D5-A927-4A7C6E1F4DC3"), OwnerPublicId = Guid.Parse("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), CreatedDate = DateTime.Today, DriveItemId = "FFAE75F410E7D5E9!113", FileSize = 11942208, LastEditedDate = DateTime.Now, ProjectFileName = "Shitty Beat" });
            //modelBuilder.Entity<Project>().HasData(new Project() { Id = 3, PublicId = Guid.Parse("F02D8399-790D-47D2-9478-8C22958E3692"), OwnerPublicId = Guid.Parse("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"), CreatedDate = DateTime.Today, DriveItemId = "FFAE75F410E7D5E9!111", FileSize = 27545588, LastEditedDate = DateTime.Now, ProjectFileName = "We Ain't Makin It Out The Hood" });
        }
    }
}
