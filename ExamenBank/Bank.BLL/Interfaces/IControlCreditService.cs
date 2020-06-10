using Bank.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BLL.Interfaces
{
    public interface IControlCreditService
    {
        void AddCredit(CreditDTO creditDTO);
        void DeleteCredit(int? id);
        void UpdateCredit(CreditDTO creditDTO);
        CreditDTO GetCredit(int? id);
        IEnumerable<CreditDTO> GetCredit();
        void Dispose();
    }
}
