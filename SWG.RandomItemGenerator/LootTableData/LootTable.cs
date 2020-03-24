using System;
using System.Collections;
using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public class LootTable : ILootTable
    {
        public ILootTableGenerationParameters ItemGenerationParameters { get; set; }
        public IEnumerable<ILootGroup> LootGroups { get; set; }
    }
}
