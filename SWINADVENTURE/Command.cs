using System;
using System.Collections.Generic;
using System.Text;
using SWINADVENTURE;

namespace SWINADVENTURE
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] ids) : base(ids)
        {
        }
        public abstract string Execute(Player p, string[] text);
    }

}
