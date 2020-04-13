using SWG.RandomDataGenerator.LootTableData;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SWG.RandomDataGenerator.Tests.LootGeneration
{
    public class LootTableParserTests
    {
        private readonly List<ILootItem> _possibleLootItemsBase = PopulateLootItems();
        private readonly LootTableParser _lootTableParser = new LootTableParser();

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeNone()
        {
            // Arrange
            var expectedLootList = _possibleLootItemsBase;

            // Act
            var modifiedLootList =
                _lootTableParser.CheckLootItemsForExclusion(new List<int> { 3 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeSingleItem()
        {
            // Arrange
            var expectedLootList = _possibleLootItemsBase.Select(c => c).Where(v => v.Id != 1).ToList();

            // Act
            var modifiedLootList =
                _lootTableParser.CheckLootItemsForExclusion(new List<int> { 1 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        [Fact]
        public void CheckLootItemsForExclusion_ExcludeManyItems()
        {
            var expectedLootList = new List<ILootItem>();

            // Act
            var modifiedLootList =
                _lootTableParser.CheckLootItemsForExclusion(new List<int> { 1, 2 }, _possibleLootItemsBase);

            // Assert
            Assert.Equal(expectedLootList, modifiedLootList);
        }

        [Fact]
        public void GetPossibleLootItems_Positive()
        {
            var lootGroup = new LootGroup { LootItems = _possibleLootItemsBase };
            var expectedLootItems = lootGroup.LootItems.Where(c => c.Id == 1).ToList();

            var modifiedLootList = _lootTableParser.GetPossibleLootItems(lootGroup);

            Assert.Equal(expectedLootItems, modifiedLootList);
        }

        [Fact]
        public void GetGuaranteedLootItems_Positive()
        {
            var lootGroup = new LootGroup { LootItems = _possibleLootItemsBase };
            var expectedLootItems = lootGroup.LootItems.Where(c => c.Id == 1).ToList();

            var modifiedLootList = _lootTableParser.GetGuaranteedItems(lootGroup);

            Assert.Equal(expectedLootItems, modifiedLootList);
        }

        [Fact]
        public void CheckForHit_Hit()
        {
            Assert.True(_lootTableParser.CheckForHit(10000));
        }

        [Fact]
        public void CheckForHit_Miss()
        {
            Assert.False(_lootTableParser.CheckForHit(0));
        }

        private static List<ILootItem> PopulateLootItems()
        {
            var list = new List<ILootItem>
            {
                new LootItem
                {
                    GenerationParameters = null,
                    Id = 1,
                    IsGuaranteed = true,
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
                    IsPossible = false,
                    Probability = 100
                }
            };
            return list;
        }
    }
}
