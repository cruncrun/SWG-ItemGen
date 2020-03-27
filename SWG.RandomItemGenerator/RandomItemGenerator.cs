using System;
using System.Collections.Generic;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Armors;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.JeweleryTypes;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Weapons;
using SWG.RandomDataGenerator.LootTableData;

namespace SWG.RandomDataGenerator
{
    public class RandomItemGenerator
    {
        public IItem GenerateRandomItem(ILootItem lootItem)
        {
            var item = GetItemObject(GetItemType(lootItem.GenerationParameters.PossibleItemSlotTypes));

            return item;
        }

        private IEquipableItem GetItemObject(ItemSlotType itemType)
        {
            switch (itemType)
            {
                case ItemSlotType.OneHandedMeeleWeapon: return new OneHandedMeeleWeapon();
                case ItemSlotType.TwoHandedMeeleWeapon: return new TwoHandedMeeleWeapon();
                case ItemSlotType.RangedWeapon: return new RangedWeapon();
                case ItemSlotType.HeadArmor: return new HeadArmor();
                case ItemSlotType.ChestArmor: return new ChestArmor();
                case ItemSlotType.LegArmor: return new LegArmor();
                case ItemSlotType.Amulet: return new Amulet();
                case ItemSlotType.Ring: return new Ring();
                default: throw new ArgumentOutOfRangeException(nameof(itemType), itemType, null);
            }
        }

        private ItemSlotType GetItemType(List<ItemSlotType> possibleItemSlotTypes)
        {
            return possibleItemSlotTypes[RandomGenerationHelper.RandomNumber(possibleItemSlotTypes.Count)];
        }
    }
}
