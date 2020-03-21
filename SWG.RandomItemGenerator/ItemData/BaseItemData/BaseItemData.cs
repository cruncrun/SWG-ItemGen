using SWG.RandomDataGenerator.ItemData.BaseItemData.Rarity;

namespace SWG.RandomDataGenerator.ItemData.BaseItemData
{
    public class BaseItemData
    {
        public UsageType UsageType { get; set; }
        public IRarity Rarity { get; set; }
    }
}
