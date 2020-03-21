using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.ItemData;
using SWG.RandomDataGenerator.ItemData.BaseItemData;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Weapons;
using SWG.RandomDataGenerator.ItemData.ItemTypes.Currencies;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Weapons.OneHandedWeapons;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Weapons.RangedWeapons;
using SWG.RandomDataGenerator.ItemData.ItemTypes.QuestItems;

namespace SWG.RandomDataGenerator
{
    public class Item
    {
        public BaseItemData BaseItemData { get; set; }
        public ItemName ItemName { get; set; } 
        public IItem DowolnyItem { get; set; }
        public IEquipableItem DowolnyEkwipunek { get; set; }
        public ICurrency DowolnaWaluta { get; set; }
        public IWeapon DowolnaBron { get; set; }
        public IArmor DowolnyPancesz { get; set; }
        public IOneHandedWeapon DowolnaBron1h { get; set; }
        public IQuestItem QuestItem { get; set; }

        public Item()
        {
            BaseItemData = new BaseItemData();
            ItemName = new ItemName();
        }
    }

    
}
