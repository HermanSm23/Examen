using Bank.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BLL.Interfaces
{
    public interface IControlLegalPersonService
    {
        void AddLegPerson(LegalPersonDTO legalPersonDTO);
        void DeleteLegPerson(int? id);
        void UpdateLegPerson(LegalPersonDTO legalPersonDTO);
        LegalPersonDTO GetLegalPerson(int? id);
        IEnumerable<LegalPersonDTO> GetLegalPesons();
        void Dispose();
    }
}
