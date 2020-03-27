using SWG.RandomDataGenerator.ItemData;
using SWG.RandomDataGenerator.ItemData.ItemAffixes;
using Xunit;

namespace SWG.RandomDataGenerator.Tests.ItemData
{
    public class ItemNameTests
    {
        [Fact]
        public void GenerateFullItemName_AllNameElements()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                FirstPrefix = new FirstPrefix { AffixName = "Soldier's" },
                SecondaryPrefix = new SecondaryPrefix { AffixName = "Steel" },
                Suffix = new Suffix { AffixName = "of Brotherhood" }
            };

            string testName = "Soldier's Steel Dagger of Brotherhood";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_TwoPrefixesAndBaseName()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                FirstPrefix = new FirstPrefix { AffixName = "Soldier's" },
                SecondaryPrefix = new SecondaryPrefix { AffixName = "Steel" }
            };

            string testName = "Soldier's Steel Dagger";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_FirstPrefixBaseNameAndSuffix()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                FirstPrefix = new FirstPrefix { AffixName = "Soldier's" },
                Suffix = new Suffix { AffixName = "of Brotherhood" }
            };

            string testName = "Soldier's Dagger of Brotherhood";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_SecondaryPrefixBaseNameAndSuffix()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                SecondaryPrefix = new SecondaryPrefix { AffixName = "Steel" },
                Suffix = new Suffix { AffixName = "of Brotherhood" }
            };

            string testName = "Steel Dagger of Brotherhood";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_FirstPrefixAndBaseName()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                FirstPrefix = new FirstPrefix { AffixName = "Soldier's" }
            };

            string testName = "Soldier's Dagger";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_SecondaryPrefixAndBaseName()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                SecondaryPrefix = new SecondaryPrefix { AffixName = "Steel" }
            };

            string testName = "Steel Dagger";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_BaseNameAndSuffix()
        {
            // Arrange
            Affixes affixes = new Affixes
            {
                Suffix = new Suffix { AffixName = "of Brotherhood" }
            };

            string testName = "Dagger of Brotherhood";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }

        [Fact]
        public void GenerateFullItemName_BaseNameOnly()
        {
            // Arrange  
            Affixes affixes = new Affixes();
            string testName = "Dagger";

            // Act
            ItemName itemName = new ItemName("Dagger", affixes);

            // Assert
            Assert.Equal(testName, itemName.FullItemName);
        }
    }
}
