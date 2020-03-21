using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootItem
    {
        int Id { get; set; }
        int DropProbability { get; set; }
        bool UniqueDrop { get; set; }
        bool GuaranteedDrop { get; set; }
        bool PossibleDrop { get; set; }
        List<int> ItemsExcludedIfDropped { get; set; }
    }
}
