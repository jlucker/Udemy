using GraniteHouse.Models;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async void Initialize()
        {
            if(_db.Database.GetPendingMigrations().Count() > 0)
            {
                // Creates database schema if it does not exist
                _db.Database.Migrate();
            }
           
            // If the roles exist it doesn't do anything
            if (_db.Roles.Any(r => r.Name == StaticDetails.SuperAdminEndUser))
            {
                return;
            }

            // If the roles do not exist, then the role and user are created
            _roleManager.CreateAsync(new IdentityRole(StaticDetails.AdminEndUser)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(StaticDetails.SuperAdminEndUser)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@GraniteHouse.com",
                Email = "admin@GraniteHouse.com",
                Name = "Tony Stark",
                EmailConfirmed = true
            }, "Admin123*").GetAwaiter().GetResult();

            IdentityUser user = await _db.Users.Where(u => u.Email == "admin@GraniteHouse.com").FirstOrDefaultAsync();

            await _userManager.AddToRoleAsync(user, StaticDetails.SuperAdminEndUser);
        }
    }
}
