using Bank.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Repositories
{
    public class InvidualPersonRepository
    {
        private DatabaseContext db;
        public InvidualPersonRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<InvidualPerson> GetAll() => db.InvidualPersons;

        public InvidualPerson Get(int id) => db.InvidualPersons.Find(id);

        public void Create(InvidualPerson invidual)
        {
            db.InvidualPersons.Add(invidual);
        }

        public void Update(InvidualPerson invidual)
        {
            db.Entry(invidual).State = EntityState.Modified;
        }

        public IEnumerable<InvidualPerson> Find(Func<InvidualPerson, bool> predicate)
        {
            return db.InvidualPersons.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            InvidualPerson invidual = db.InvidualPersons.Find(id);
            if (invidual != null)
                db.InvidualPersons.Remove(invidual);
        }
    }
}
