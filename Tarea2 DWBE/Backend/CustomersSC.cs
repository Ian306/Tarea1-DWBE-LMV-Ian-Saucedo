using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea2_DWBE.DataAccess;

namespace Tarea2_DWBE.Backend
{
    class CustomersSC : BaseSC
    {
        public IQueryable<Customer> GetCustomers()
        {
            return DBContext.Customers.AsQueryable();
        }

        public IQueryable<Customer> GetCustomersByCity(String Ciudad)
        {
            return GetCustomers().Where(c => c.City == Ciudad);
        }
    }
}
