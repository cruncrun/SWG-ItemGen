using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.LootTableData
{
    public class LootGroup : ILootGroup
    {
        public IEnumerable<ILootItem> LootItems { get; set; }
        public bool IsPossible { get; set; }
        public int LootGroupRollProbability { get; set; }
    }
}
