using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.ItemData.BaseItemData;

namespace SWG.RandomDataGenerator.ItemData.ItemAttributes
{
    public class ArmorValue : IItemTypeSpecificData
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public ArmorValue()
        {
            Name = "Pancerz";
        }
    }
}
