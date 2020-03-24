using System.Collections.Generic;
using System.Linq;
using SWG.RandomDataGenerator.LootTableData;
using Xunit;

namespace SWG.RandomDataGenerator.Tests.LootGeneration
{
    public class LootTableParserTests
    {
        private readonly List<ILootItem> _possibleLootItemsBase = PopulateLootItems();

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeNone()
        {
            // Arrange
            var lootTableParser = new LootTableParser();
            var expectedLootList = _possibleLootItemsBase;

            // Act
            var modifiedLootList =
                lootTableParser.CheckLootItemsForExclusion(new List<int> { 3 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeSingleItem()
        {
            // Arrange
            var lootTableParser = new LootTableParser();
            var expectedLootList = _possibleLootItemsBase.Select(c => c).Where(v => v.Id != 1).ToList();

            // Act
            var modifiedLootList =
                lootTableParser.CheckLootItemsForExclusion(new List<int> { 1 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeManyItems()
        {
            var lootTableParser = new LootTableParser();
            var expectedLootList = new List<ILootItem>();

            // Act
            var modifiedLootList =
                lootTableParser.CheckLootItemsForExclusion(new List<int> { 1, 2 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        private static List<ILootItem> PopulateLootItems()
        {
            var list = new List<ILootItem>
            {
                new LootItem
                {
                    GenerationParameters = null,
                    Id = 1,
                    IsGuaranteed = false,
                    IsPredefined = false,
                    IsUnique = false,
                    ItemsExcludedIfDropped = null,
                    IsPossible = true,
                    Probability = 100
                },
                new LootItem
                {
                    GenerationParameters = null,
                    Id = 2,
                    IsGuaranteed = false,
                    IsPredefined = false,
                    IsUnique = false,
                    ItemsExcludedIfDropped = null,
                    IsPossible = true,
                    Probability = 100
                }
            };
            return list;
        }
    }
}
