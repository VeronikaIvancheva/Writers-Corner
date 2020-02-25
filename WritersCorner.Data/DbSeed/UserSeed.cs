using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using WritersCorner.Data.Entities;

namespace WritersCorner.Data.DbSeed
{
    public static class UserSeed
    {
        public static void UpdateUsers(this ModelBuilder modelBuilder)
        {
            #region Role seed
            modelBuilder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "Admin", Id = "1", NormalizedName = "admin".ToUpper() });

            modelBuilder.Entity<IdentityRole>()
                .HasData(new IdentityRole { Name = "User", Id = "2", NormalizedName = "user".ToUpper() });
            #endregion

            var admin = SeedAdmin();
            var user = SeedUser();
            var user1 = SeedUser1();

            modelBuilder.Entity<User>()
                .HasData(admin);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = admin.Id
                });

            modelBuilder.Entity<User>()
                .HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = user.Id
                });

            modelBuilder.Entity<User>()
                .HasData(user1);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = user1.Id
                });
        }

        private static User SeedAdmin()
        {
            var adminUser = new User
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@abv.bg",
                NormalizedEmail = "admin@abv.bg".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "+111111111",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                Role = "Admin",
                RegisterOn = DateTime.Now
            };

            var hashePass = new PasswordHasher<User>().HashPassword(adminUser, "admin1");
            adminUser.PasswordHash = hashePass;

            return adminUser;
        }

        private static User SeedUser()
        {
            var user = new User
            {
                Id = "2",
                UserName = "testuser",
                NormalizedUserName = "testuser".ToUpper(),
                Email = "testuser@abv.bg",
                NormalizedEmail = "testuser@abv.bg".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "+0895674532",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                Role = "User",
                RegisterOn = DateTime.Now
            };

            var hashePass = new PasswordHasher<User>().HashPassword(user, "testuser");
            user.PasswordHash = hashePass;

            return user;
        }

        private static User SeedUser1()
        {
            var user = new User
            {
                Id = "3",
                UserName = "testuser1",
                NormalizedUserName = "testuser1".ToUpper(),
                Email = "testuser1@abv.bg",
                NormalizedEmail = "testuser1@abv.bg".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "+0895674532",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                Role = "User",
                RegisterOn = DateTime.Now
            };

            var hashePass = new PasswordHasher<User>().HashPassword(user, "testuser1");
            user.PasswordHash = hashePass;

            return user;
        }
    }
}
