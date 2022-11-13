using System;
using System.Collections.Generic;
//using System.Text;

namespace SWINADVENTURE
{
   
        public class Inventory
        {
            private List<Item> _items = new List<Item>();

            public Inventory() 
        {
        }

            public bool HasItem(string id)
            {
                foreach (Item item in _items)
                {
                    if (item.AreYou(id))
                    {
                        return true;
                    }
                }

                return false;
            }
        //using put method and put parameters let user input
            public void Put(Item item)
            {
                _items.Add(item);
            }
        //using take method let user take or remove the item
            public Item Take(string id)
            {
                foreach (Item item in _items)
                {
                    if (item.AreYou(id))
                    {
                        _items.Remove(item);
                        return item;
                    }
                }
                return null;
            }

            public Item Fetch(string id)
            {
                foreach (Item item in _items)
                {
                    if (item.AreYou(id))
                    {
                        return item;
                    }
                }
                return null;
            }

            public string ItemList
            {
                get
                {
                    string itemlist = "";
                    foreach (Item i in _items)
                    {
                        itemlist += String.Format("{0}\n", i.ShortDescription);
                    }
                    return itemlist;
                }
            }

        }
    
}
