using SWG.RandomItemGenerator.ItemData;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomItemGenerator
{    
    public class Item
    {
        public BaseItemData BaseItemData { get; set; }
        public ItemName ItemName { get; set; } 

        public Item()
        {
            BaseItemData = new BaseItemData();
            ItemName = new ItemName();
        }
    }

    
}
