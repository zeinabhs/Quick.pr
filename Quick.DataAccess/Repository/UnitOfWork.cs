//using Quick.DataAccess.Repository;
//using Quick.DataAccess.Repository.IRepository;
//using Quick.DataAccess.Data;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Quick.DataAccess.Repository
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private ApplicationDbContext _db;
//        public ICategoryRepository Category { get; private set; }
//        public IProductRepository Product { get; private set; }


//        public UnitOfWork(ApplicationDbContext db) 
//        {
//            _db = db;
//            Category = new CategoryRepository(_db);
//            Product = new ProductRepository(_db);


//        }



//        public void save()
//        {
//            _db.SaveChanges();
//        }
//    }
//}
using Microsoft.AspNetCore.Identity;
using Quick.DataAccess.Data;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;
using System.Threading.Tasks;
using Quick.Models.QuickBites.Models;

namespace Quick.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        // Add other repositories as needed

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            // Initialize other repositories
        }

        //public async Task<bool> IsUserInRoleAsync(string userId, string roleName)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user == null)
        //        return false;

        //    return await _userManager.IsInRoleAsync(user, roleName);
        //}

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
