using Book.Infrastructure.Data;
using Book.Infrastructure.Repository.Interface;
using Book.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.Infrastructure.Repository.Implement
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
