using System.Collections.Generic;
using SWG.RandomDataGenerator.Components;
using SWG.RandomDataGenerator.ItemData.BaseItemData;
using SWG.RandomDataGenerator.ItemData.ItemAffixes;

namespace SWG.RandomDataGenerator.ItemData.ItemTypes
{
    public abstract class Item : IItem
    {
        public ItemName ItemName { get; set; }
        public string FlavorText { get; set; }
        public Affixes Affixes { get; set; }
        public List<IItemTypeSpecificData> ItemTypeSpecificData { get; set; }
        public List<IBonusAttribute> Attributes { get; set; }
        public List<IRequirement> Requirements { get; set; }
        public List<Dictionary<Currency, int>> ItemValue { get; set; }
    }
}
