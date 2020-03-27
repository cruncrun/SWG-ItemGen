using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootGroup
    {
        IEnumerable<ILootItem> LootItems { get; set; }
        bool IsPossible { get; set; }
        int LootGroupRollProbability { get; set; }
    }
}
