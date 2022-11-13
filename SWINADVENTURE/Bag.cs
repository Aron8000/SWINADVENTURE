using System;
using SWINADVENTURE;
using System.Collections.Generic;
using System.Text;

namespace SWINADVENTURE
{

    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;
        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id) == true)
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                return Name + _inventory.ItemList;
            }
        }

        public Inventory inventory
        {
            get
            {
                return _inventory;
            }
        }






    }
}
