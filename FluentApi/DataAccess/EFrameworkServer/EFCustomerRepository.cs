using FluentApi.Domain.Abstractions;
using FluentApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.DataAccess.EFrameworkServer
{
    public class EFCustomerRepository : ICustomerRepository
    {
        public void AddData(Customer data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Customer data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
