using Book.Infrastructure.Repository.Implement;
using Book.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            Category = new CategoryRepo(dbContext);
        }

        public ICategoryRepo Category { get; private set; }

        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }



        public async Task<int> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
