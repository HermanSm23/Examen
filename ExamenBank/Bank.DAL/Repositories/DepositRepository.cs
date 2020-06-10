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
    public class DepositRepository : IRepository<Deposit>
    {
        private DatabaseContext db;
        public DepositRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Deposit> GetAll() => db.Deposits;

        public Deposit Get(int id) => db.Deposits.Find(id);

        public void Create(Deposit deposit)
        {
            db.Deposits.Add(deposit);
        }

        public void Update(Deposit deposit)
        {
            db.Entry(deposit).State = EntityState.Modified;
        }

        public IEnumerable<Deposit> Find(Func<Deposit, bool> predicate)
        {
            return db.Deposits.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Deposit deposit = db.Deposits.Find(id);
            if (deposit != null)
                db.Deposits.Remove(deposit);
        }
    }
}
