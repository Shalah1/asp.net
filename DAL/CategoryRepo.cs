using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo : IRepository<Category, int>
    {
        finalproEntities1 db;

        public CategoryRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(Category e)
        {
            db.Categories.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Categories.FirstOrDefault(e => e.CategoryId == id);
            db.Categories.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Category e)
        {
            var emp = db.Categories.FirstOrDefault(em => em.CategoryId == e.CategoryId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(e => e.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> Getorder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Gets(int id)
        {
            throw new NotImplementedException();
        }
    }
}
