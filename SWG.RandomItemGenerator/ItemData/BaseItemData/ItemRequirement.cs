using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.Components;

namespace SWG.RandomDataGenerator.ItemData.BaseItemData
{
    public class ItemRequirement : IRequirement
    {
        public ICharacterAttribute CharacterAttribute { get; set; }
        public int Value { get; set; }
    }
}
