using SWG.RandomDataGenerator;
using SWG.RandomDataGenerator.LootTableData;
using System;
using System.Collections.Generic;
using SWG.RandomDataGenerator.Components;
using SWG.RandomDataGenerator.ItemData;
using SWG.RandomDataGenerator.ItemData.BaseItemData;
using SWG.RandomDataGenerator.ItemData.BaseItemData.WeaponSpecificData;
using SWG.RandomDataGenerator.ItemData.ItemAffixes;
using SWG.RandomDataGenerator.ItemData.ItemAttributes;
using SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems.Armors;

namespace ConsoleWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lootTableGenerator = new LootTableGenerator();
            //var calculator = new LootChanceCalculator();
            //var reflections = new Reflections();

            //var possibleItemList = new List<ItemType> { ItemType.OneHand, ItemType.TwoHand };

            //var testClass = reflections.GetNewInstance(possibleItemList);
            //foreach (var c in testClass)
            //{
            //    Console.WriteLine(c.Name);
            //}

            var itemek = new ChestArmor
            {
                FlavorText = "Broń przedwiecznych kuców",
                ItemName = new ItemName {BaseItemName = "Sztylet"},
                Affixes = new Affixes
                {
                    FirstPrefix = new FirstPrefix {AffixRarity = AffixRarity.Rare, AffixName = "Złoty"},
                    SecondaryPrefix = new SecondaryPrefix {AffixName = "Piekielny", AffixRarity = AffixRarity.Uncommon},
                    Suffix = new Suffix {AffixName = "Gladiatora", AffixRarity = AffixRarity.Common}
                },
                ItemTypeSpecificData = new List<IItemTypeSpecificData>
                {
                    new ArmorValue{ Value = 3},
                    new WeaponDamageRange {MinimumDamage = 4, MaximumDamage = 6}
                },
                Attributes = new List<IBonusAttribute>
                {
                    new FlatValueBonus {Attribute = new Agility(), Value = 5},
                    new PercentageValueBonus {Attribute = new Strength(), Value = 10}
                },
                Requirements = new List<IRequirement>
                {
                    new ItemRequirement {CharacterAttribute = new Strength(), Value = 4},
                    new ItemRequirement {CharacterAttribute = new Agility(), Value = 6}
                }
            };

            var printer = new ItemDataPrinter();
            printer.Print(itemek);

            //calculator.Calculate(lootTableGenerator.GetLootTable());
            Console.ReadKey();
        }
    }

    enum ItemType
    {
        OneHand,
        TwoHand
    }

    class LootTableGenerator
    {
        public LootTable GetLootTable()
        {
            return new LootTable
            {
                ItemGenerationParameters = null,
                LootGroups = GetLootGroups()
            };
        }

        private IEnumerable<ILootGroup> GetLootGroups()
        {
            var lootGroups = new List<ILootGroup>();

            for (int i = 0; i < RandomGenerationHelper.RandomNumber(1, 5); i++)
            {
                lootGroups.Add(new LootGroup
                {
                    IsPossible = true,
                    LootGroupRollProbability = RandomGenerationHelper.RandomNumber(1, 100),
                    LootItems = GetLootItems()
                }
                );
            }

            return lootGroups;
        }

        private IEnumerable<ILootItem> GetLootItems()
        {
            var lootItems = new List<ILootItem>();

            for (var i = 0; i < RandomGenerationHelper.RandomNumber(1, 5); i++)
            {
                lootItems.Add(new LootItem
                {
                    GenerationParameters = null,
                    Id = RandomGenerationHelper.RandomNumber(100),
                    IsGuaranteed = false,
                    IsPossible = true,
                    IsUnique = false,
                    ItemsExcludedIfDropped = null,
                    Probability = RandomGenerationHelper.RandomNumber(1, 100)
                });
            }
            return lootItems;
        }
    }
}
