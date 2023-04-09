using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PReviewRepo : IRepository<PReview, int>
    {

        finalproEntities1 db;
        public PReviewRepo(finalproEntities1 db)
        {
            this.db = db;
        }

        public void ADD(PReview e)
        {
            db.PReviews.Add(e);
            db.SaveChanges();
        }

        public List<PReview> GetAll()
        {
            return db.PReviews.ToList();
        }

        public PReview Get(int id)
        {
            return db.PReviews.FirstOrDefault(e => e.PRId == id);
        }

        public void Edit(PReview e)
        {
            var emp = db.PReviews.FirstOrDefault(em => em.PRId == e.PRId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.PReviews.FirstOrDefault(e => e.PRId == id);
            db.PReviews.Remove(emp);
            db.SaveChanges();
        }

        public List<PReview> Gets(int id)
        {
            throw new NotImplementedException();
        }

        public List<PReview> Getorder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
