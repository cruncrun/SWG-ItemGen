using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    public interface IBonusAttribute
    {
        ICharacterAttribute Attribute { get; set; }
    }
}
