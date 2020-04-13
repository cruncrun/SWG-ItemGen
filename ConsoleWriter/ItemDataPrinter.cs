using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Colorful;
using SWG.RandomDataGenerator.Components;
using Console = Colorful.Console;
using SWG.RandomDataGenerator.ItemData;
using SWG.RandomDataGenerator.ItemData.BaseItemData;
using SWG.RandomDataGenerator.ItemData.ItemAffixes;
using SWG.RandomDataGenerator.ItemData.ItemAttributes;
using SWG.RandomDataGenerator.ItemData.ItemTypes;
using static System.String;

namespace ConsoleWriter
{
    class ItemDataPrinter
    {
        private static Color color_BaseColor;
        private static Color color_AffixCommonName;
        private static Color color_AffixUncommonName;
        private static Color color_AffixRareName;
        private static Color color_FlavorText;
        private static Color color_UniqueItemName;
        private static Color color_LegendaryItemName;

        public ItemDataPrinter()
        {
            color_BaseColor = Color.White;
            color_AffixCommonName = Color.LightGray;
            color_AffixUncommonName = Color.Yellow;
            color_AffixRareName = Color.Gold;
            color_FlavorText = Color.DarkGoldenrod;
            color_UniqueItemName = Color.DeepSkyBlue;
            color_LegendaryItemName = Color.BlueViolet;
        }
        public void Print(Item item)
        {
            PrintItemName(item);
            PrintFlavorText(item.FlavorText);
            PrintItemSpecificData(item.ItemTypeSpecificData);
            PrintItemBonuses(item.Attributes);
            PrintRequirements(item.Requirements);
        }

        private void PrintItemBonuses(List<IBonusAttribute> itemAttributes)
        {
            itemAttributes.OrderByDescending(c => c.Attribute);
        }

        private void PrintItemSpecificData(List<IItemTypeSpecificData> itemTypeSpecificData)
        {
            if (itemTypeSpecificData != null)
            {
                foreach (var item in itemTypeSpecificData)
                {
                    System.Console.WriteLine($"{item.Name}", color_BaseColor);
                }
            }
        }

        private void PrintRequirements(List<IRequirement> itemRequirements)
        {
            if (itemRequirements.Any())
            {
                System.Console.WriteLine("Requirements:");
                foreach (var itemRequirement in itemRequirements)
                {
                    System.Console.WriteLine($"{itemRequirement.Value} {itemRequirement.CharacterAttribute.Name}", color_BaseColor);
                }
            }
        }

        private void PrintFlavorText(string itemFlavorText)
        {
            if (!IsNullOrEmpty(itemFlavorText))
                Console.WriteLine($"\"{itemFlavorText}\"", color_FlavorText);
        }

        private void PrintItemName(IItem item)
        {
            var itemName = "{0} {1} {2} {3}";
            var nameFormatter = new Formatter[]
            {
                new Formatter(item.Affixes?.FirstPrefix?.AffixName ?? "",
                    item.Affixes?.FirstPrefix?.AffixName != null ? GetAffixColorName(item.Affixes.FirstPrefix.AffixRarity) : Color.White),
                new Formatter(item.Affixes?.SecondaryPrefix?.AffixName ?? "",
                    item.Affixes?.SecondaryPrefix?.AffixName != null ? GetAffixColorName(item.Affixes.SecondaryPrefix.AffixRarity) : Color.White),
                new Formatter(item.ItemName?.BaseItemName ?? "", Color.White), 
                new Formatter(item.Affixes?.Suffix?.AffixName ?? "",
                    item.Affixes?.Suffix?.AffixName != null ? GetAffixColorName(item.Affixes.Suffix.AffixRarity) : Color.White)
            };

            Console.WriteLineFormatted(itemName.Trim(), Color.White, nameFormatter);
        }

        private Color GetAffixColorName(AffixRarity firstPrefixAffixRarity)
        {
            switch (firstPrefixAffixRarity)
            {
                case AffixRarity.Common: return color_AffixCommonName;
                case AffixRarity.Uncommon: return color_AffixUncommonName;
                case AffixRarity.Rare: return color_AffixRareName;
                default: throw new ArgumentOutOfRangeException(nameof(firstPrefixAffixRarity), firstPrefixAffixRarity, null);
            }
        }
    }
}
