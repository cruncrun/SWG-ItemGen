using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public class LootItem : ILootItem
    {
        public ILootItemGenerationParameters GenerationParameters { get; set; }
        public int Id { get; set; }
        public int Probability { get; set; }
        public bool IsUnique { get; set; }
        public bool IsGuaranteed { get; set; }
        public bool IsPossible { get; set; }
        public bool IsPredefined { get; set; }
        public List<int> ItemsExcludedIfDropped { get; set; }
    }
}
