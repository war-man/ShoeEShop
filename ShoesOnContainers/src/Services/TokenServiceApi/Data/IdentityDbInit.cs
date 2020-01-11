using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenServiceApi.Models;

namespace TokenServiceApi.Data
{
    public class IdentityDbInit
    {
        //This example just creates an Administrator role and one Admin users
        public static async Task<IdentityResult> Initialize(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            //create database schema if none exists
            // _context.Database.EnsureCreated();
            context.Database.Migrate();
            //If there is already an Administrator role, abort
            //  if (context.Roles.Any(r => r.Name == "Administrator")) return;

            //Create the Administartor Role
            // await roleManager.CreateAsync(new IdentityRole("Administrator"));
            if (context.Users.Any(r => r.UserName == "me@myemail.com")) return null;
            //Create the default Admin account and apply the Administrator role
            string userEmail = "me@myemail.com";
            //string user = "SampleUser";
            string password = "P@ssword1";
            //TODO: Burası kaldırılacak bir şekilde user policy'e uymayan bir durum gerçekleştiği için insert yapılmıyor.
            userManager.UserValidators.Remove(userManager.UserValidators.FirstOrDefault());
            return await userManager.CreateAsync(new ApplicationUser { UserName = userEmail, Email = userEmail, EmailConfirmed = true }, password);
            //   await userManager.AddToRoleAsync(await userManager.FindByNameAsync(user), "Administrator");
        }

    }
}
