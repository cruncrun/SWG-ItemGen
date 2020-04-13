using System;
using System.Collections.Generic;
using System.Text;
using SWG.RandomDataGenerator.Components;

namespace SWG.RandomDataGenerator.ItemData.BaseItemData
{
    public interface IRequirement
    {
        ICharacterAttribute CharacterAttribute { get; set; }
        int Value { get; set; }
    }
}
