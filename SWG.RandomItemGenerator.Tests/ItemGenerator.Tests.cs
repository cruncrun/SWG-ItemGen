using System;
using Xunit;

namespace SWG.RandomItemGenerator.Tests
{
    public class ItemGeneratorTests
    {
        [Fact]
        public void ItemGenerator_GetItem_Positive()
        {
            // Arrange
            Item testItem = new Item();
            ItemGenerator itemGenerator = new ItemGenerator();

            // Act
            Item generatedItem = itemGenerator.GetItem();

            // Assert
            //Assert.Equal(testItem.BaseItemData, generatedItem.BaseItemData);
            //Assert.Equal(testItem.ItemName.BaseItemName, generatedItem.ItemName.BaseItemName);
        }
    }
}
