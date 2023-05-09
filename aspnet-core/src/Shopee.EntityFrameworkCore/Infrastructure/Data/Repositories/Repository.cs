using Ardalis.Specification.EntityFrameworkCore;
using Shopee.EntityFrameworkCore;
using Shopee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Infrastructure.Data.Repositories
{
    public class Repository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public Repository(ApplicationDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
