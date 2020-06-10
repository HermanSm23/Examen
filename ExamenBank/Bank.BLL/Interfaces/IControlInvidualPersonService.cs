using Bank.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BLL.Interfaces
{
    public interface IControlInvidualPersonService
    {
        void AddInvPerson(InvidualPersonDTO invidualPersonDTO);
        void DeleteInvPerson(int? id);
        void UpdateInvPerson(InvidualPersonDTO invidualPersonDTO);
        InvidualPersonDTO GetInvidualPerson(int? id);
        IEnumerable<InvidualPersonDTO> GetInvidualPesons();
        void Dispose();
    }
}
