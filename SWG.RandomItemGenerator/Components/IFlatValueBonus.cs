using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    interface IFlatValueBonus : IBonusAttribute
    {
        int Value { get; set; }
    }
}
