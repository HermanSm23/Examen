using Bank.DAL.Entities;
using Bank.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Repositories
{
    public class EFUnitOfWork
    {
        private DatabaseContext db;
        private InvidualPersonRepository InvidualPersonRepository;
        private LegalPersonRepository LegalPersonRepository;
        private CreditRepository CreditRepository;
        private DepositRepository DepositRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }

        public IRepository<InvidualPerson> InvidualPersons
        {
            get
            {
                if (InvidualPersonRepository == null)
                    InvidualPersonRepository = new InvidualPersonRepository(db);
                return InvidualPersonRepository;
            }
        }

        public IRepository<LegalPerson> LegalPersons
        {
            get
            {
                if (LegalPersonRepository == null)
                    LegalPersonRepository = new LegalPersonRepository(db);
                return LegalPersonRepository;
            }
        }

        public IRepository<Credit> Credits
        {
            get
            {
                if (CreditRepository == null)
                    CreditRepository = new CreditRepository(db);
                return CreditRepository;
            }
        }

        public IRepository<Deposit> Deposits
        {
            get
            {
                if (DepositRepository == null)
                    DepositRepository = new DepositRepository(db);
                return DepositRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
