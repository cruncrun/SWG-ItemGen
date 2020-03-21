using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public class LootItem : ILootItem
    {
        public int Id { get; set; }
        public int DropProbability { get; set; }
        public bool UniqueDrop { get; set; }
        public bool GuaranteedDrop { get; set; }
        public bool PossibleDrop { get; set; }
        public List<int> ItemsExcludedIfDropped { get; set; }
    }
}
