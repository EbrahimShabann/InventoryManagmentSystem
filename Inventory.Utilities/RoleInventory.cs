using Inventory.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utilities
{
    public class RoleInventory : IRoleInventory
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleInventory(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task AddRoleAsync(string ApplicationUserId)
        {
            var user = await _userManager.FindByIdAsync(ApplicationUserId);
            var roles = _roleManager.Roles;
            List<string> StringRoles = new List<String>();
            if (user != null) 
            {
                foreach (var role in roles) 
                {
                    StringRoles.Add(role.Name);
                }
               await _userManager.AddToRolesAsync(user, StringRoles);
            }
        }

        public async Task CreateNewRoleAsync()
        {
           Type t = typeof(TopMenu);
            foreach (Type classObj in t.GetNestedTypes())
            {
                foreach (var objField in classObj.GetFields())
                {
                    if (objField.Name.Contains("RoleName"))
                    {
                        var roleName = (string)objField.GetValue(objField);
                        if (!await _roleManager.RoleExistsAsync(roleName))
                            await _roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

            }
        }
    }
}
