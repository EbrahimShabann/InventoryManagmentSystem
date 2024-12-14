using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utilities
{
    public interface IRoleInventory
    {
        Task CreateNewRoleAsync();
        Task AddRoleAsync(string ApplicationUserId);
    }
}
