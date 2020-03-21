using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootTable
    {
        IItemGenerationParameters ItemGenerationParameters { get; set; }
        IEnumerable<ILootGroup> LootGroups { get; set; }
    }
}
