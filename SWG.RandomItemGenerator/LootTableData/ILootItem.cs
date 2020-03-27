using System.Collections.Generic;

namespace SWG.RandomDataGenerator.LootTableData
{
    public interface ILootItem
    {
        ILootItemGenerationParameters GenerationParameters { get; set; } // parametry generowania itemka
        int Id { get; set; }
        int Probability { get; set; } // szansa dropa 1-10000 (0,01%-100%)
        bool IsUnique { get; set; } // może wystąpić tylko raz
        bool IsGuaranteed { get; set; } // gwarantowany drop
        bool IsPossible { get; set; } // możliwy drop
        bool IsPredefined { get; set; }
        List<int> ItemsExcludedIfDropped { get; set; }
    }
}
