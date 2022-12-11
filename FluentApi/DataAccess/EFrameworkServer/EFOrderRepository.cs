using FluentApi.Domain.Abstractions;
using FluentApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.DataAccess.EFrameworkServer
{
    public class EFOrderRepository : IOrderRepository
    {
        public void AddData(Order data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Order data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Order data)
        {
            throw new NotImplementedException();
        }
    }
}
