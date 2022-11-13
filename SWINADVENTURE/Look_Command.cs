using System;
using System.Collections.Generic;
using System.Text;
using SWINADVENTURE;

namespace SWINADVENTURE
{

     public  class Look_Command : Command
     {

        public Look_Command() : base(new string[] { "look" })
        {
           
        }


        public  override string Execute(Player p, string[] text)
        {
            /* if (text.Length != 3 && text.Length != 5)
             {
                 return "I don't know how to look like that";
             }*/

            if (text[0].ToLower() == "inventory")
            {
                return p.FullDescription;
            }
            if (text[0].ToLower() != "look")
            {
                return "Error in look input";
            }
            
            if (text[1].ToLower() != "at")
            {
                return "What do you want to look at?";
            }
            if (text.Length == 5)
            {
                if (text[3].ToLower() != "in")
                {
                    return "What do you want to look in?";
                }
            }
            IHaveInventory container;

            if (text.Length == 3)
            {
                container = p as IHaveInventory;
            }
            else if (text.Length == 5)
            {
                container = FetchContainer(p, text[4]);
            }
            else
            {
                container = null;
            }

            //string itemsid = text[2];

            if (container == null)
            {
                return "I could not find "; //+ text[4] + ".";
            }

            return LookAtIn(text[2], container);
        }



        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            if (container.Locate(thingId) != null)
            {
                return container.Locate(thingId).FullDescription;
            }
            return "I can't find " + thingId ;

        }


    }
}
