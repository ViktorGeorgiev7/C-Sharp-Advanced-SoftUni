using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    interface ILieutenantGeneral:IPrivate
    {
        public List<Private> Privates { get;}
    }
}
