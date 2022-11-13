using System;
using System.Collections.Generic;
using System.Text;
using SWINADVENTURE;

namespace SWINADVENTURE
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name
        {
            get;
        }
    }
}

