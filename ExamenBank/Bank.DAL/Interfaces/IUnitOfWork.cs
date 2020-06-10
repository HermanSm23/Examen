using Bank.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<InvidualPerson> InvidualPersons { get; }
        IRepository<LegalPerson> LegalPersons { get; }
        IRepository<Credit> Credits { get; }
        IRepository<Deposit> Deposit { get; }
        void Save();
    }
}
