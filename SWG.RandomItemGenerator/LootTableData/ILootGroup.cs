using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootGroup
    {
        IEnumerable<ILootItem> LootItems { get; set; }
        bool IsPossible { get; set; }
        int LootGroupRollProbability { get; set; }
    }
}
