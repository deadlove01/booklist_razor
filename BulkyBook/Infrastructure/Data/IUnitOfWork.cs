using Book.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book.Infrastructure.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepo Category { get; }

        Task<int> SaveChangesAsync();
    }
}
