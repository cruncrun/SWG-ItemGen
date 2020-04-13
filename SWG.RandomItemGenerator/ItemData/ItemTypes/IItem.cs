using System.Collections.Generic;
using SWG.RandomDataGenerator.Components;
using SWG.RandomDataGenerator.ItemData.BaseItemData;
using SWG.RandomDataGenerator.ItemData.ItemAffixes;

namespace SWG.RandomDataGenerator.ItemData.ItemTypes
{
    public interface IItem
    {
        ItemName ItemName { get; set; }
        string FlavorText { get; set; }
        Affixes Affixes { get; set; }
        List<IItemTypeSpecificData> ItemTypeSpecificData { get; set; }
        List<IBonusAttribute> Attributes { get; set; }
        List<IRequirement> Requirements { get; set; }
        List<Dictionary<Currency, int>> ItemValue { get; set; }
    }
}
