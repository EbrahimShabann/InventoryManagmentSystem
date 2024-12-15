﻿using Inventory.Repositories.Paging;
using Inventory.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repositories.CustomerType
{
    public class CustomerTypeRepo : ICustomerTypeRepo
    {
        public Task<PaginatedList<CustomerTypeListViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
