﻿using dasho.DataAccess.Data;
using dasho.DataAccess.Repository.IRepository;
using dasho.Models;

namespace dasho.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}