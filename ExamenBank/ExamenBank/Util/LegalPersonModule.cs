using Bank.BLL.Interfaces;
using Bank.BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenBank.Util
{
    public class LegalPersonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IControlLegalPersonService>.To<ControlLegalPersonService>();
        }
    }
}