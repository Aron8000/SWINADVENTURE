using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWINADVENTURE;

namespace SWINADVENTURE
{
   public class Item :GameObject
    {
            public Item(string[] idents, string name, string desc) : base(name , desc,idents)
            {
            //Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
            }
        
    }
}
