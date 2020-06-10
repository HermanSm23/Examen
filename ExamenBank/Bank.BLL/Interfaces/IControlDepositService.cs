using Bank.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BLL.Interfaces
{
    public interface IControlDepositService
    {
        void AddDeposit(DepositDTO depositDTO);
        void DeleteDeposit(int? id);
        void UpdateDeposit(DepositDTO depositDTO);
        DepositDTO GetDeposit(int? id);
        IEnumerable<DepositDTO> GetDeposit();
        void Dispose();
    }
}
