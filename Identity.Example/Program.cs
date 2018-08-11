using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateUserStore();

            //VerifyPassword();

            //CreateClaimsForUser();

            CreateRole();

            AssignRoleToUser();

            Console.ReadLine();
        }

        private static void AssignRoleToUser()
        {
            var uid = "k.lagan@gmail.com";
            var pwd = "password";

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var user = userManager.FindByName(uid);


            var roleStore = new RoleStore<IdentityRole>();
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var role = roleManager.FindByName("Administrator");

            var result = userManager.AddToRole(user.Id, role.Name);

            Console.WriteLine($"Role Assignment Status: {result.Succeeded}");
        }

        private static void CreateRole()
        {
            var roleStore = new RoleStore<IdentityRole>();
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var role = new IdentityRole { Name = "Administrator" };
            var result = roleManager.Create(role);

            Console.WriteLine($"Role Creation Status: {result.Succeeded}");
        }


        private static void CreateClaimsForUser()
        {
            var uid = "k.lagan@gmail.com";
            var pwd = "password";

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var result = userManager.FindByName(uid);

            var claimResult = userManager.AddClaim(result.Id, new Claim("Owner", "Microsoft"));

            Console.WriteLine($"Claim Creation Status: {claimResult.Succeeded}");
        }

        private static void VerifyPassword()
        {
            var uid = "k.lagan@gmail.com";
            var pwd = "password";

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var result = userManager.FindByName(uid);

            var passwordVerificationStatus = userManager.CheckPassword(result, pwd);

            Console.WriteLine($"Password Verification Status: {passwordVerificationStatus}");
        }

        private static void CreateUserStore()
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var newIdentityUser = new IdentityUser("k.lagan@gmail.com");

            var result = userManager.Create(newIdentityUser, "password");

            Console.WriteLine($"User creation status: {result.Succeeded}");
        }
    }
}
