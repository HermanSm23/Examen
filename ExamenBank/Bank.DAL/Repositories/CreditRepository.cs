using Bank.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Repositories
{
    public class CreditRepository
    {
        private DatabaseContext db;
        public CreditRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Credit> GetAll() => db.Credits;

        public Credit Get(int id) => db.Credits.Find(id);

        public void Create(Credit credit)
        {
            db.Credits.Add(credit);
        }

        public void Update(Credit credit)
        {
            db.Entry(credit).State = EntityState.Modified;
        }

        public IEnumerable<Credit> Find(Func<Credit, bool> predicate)
        {
            return db.Credits.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Credit credit = db.Credits.Find(id);
            if (credit != null)
                db.Credits.Remove(credit);
        }
    }
}
