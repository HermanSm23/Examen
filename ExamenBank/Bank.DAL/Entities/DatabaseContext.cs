using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<InvidualPerson> InvidualPersons { get; set; }
        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Deposit> Deposits { get; set; }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new StoreDBInit());
        }

        public DatabaseContext(string connectionString) : base(connectionString) { }
    }

    public class StoreDBInit : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {

        }
    }
}
