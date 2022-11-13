using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWINADVENTURE
{
    
        public class Player : GameObject, IHaveInventory
    {
           // private Inventory _inventory;
            Inventory _inventory = new Inventory();
        public Player(string name, string description) :base(name, description, new[] { "me", "inventory" })
            {
           
            }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public override string FullDescription
        {
            get
            {
                string desc = "You are carrying: ";
                desc += _inventory.ItemList;
                return desc;
         
            }
        }
        //finding users object Eg. Sword, Showel
        public GameObject Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            return _inventory.Fetch(id);
        }  
        }
    
}
