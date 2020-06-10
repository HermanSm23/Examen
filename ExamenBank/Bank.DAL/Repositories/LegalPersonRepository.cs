using Bank.DAL.Entities;
using Bank.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Repositories
{
    public class LegalPersonRepository : IRepository<LegalPerson>
    {
        private DatabaseContext db;
        public LegalPersonRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<LegalPerson> GetAll() => db.LegalPersons;

        public LegalPerson Get(int id) => db.LegalPersons.Find(id);

        public void Create(LegalPerson legal)
        {
            db.LegalPersons.Add(legal);
        }

        public void Update(LegalPerson legal)
        {
            db.Entry(legal).State = EntityState.Modified;
        }

        public IEnumerable<LegalPerson> Find(Func<LegalPerson, bool> predicate)
        {
            return db.LegalPersons.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            LegalPerson legal = db.LegalPersons.Find(id);
            if (legal != null)
                db.LegalPersons.Remove(legal);
        }
    }
}
