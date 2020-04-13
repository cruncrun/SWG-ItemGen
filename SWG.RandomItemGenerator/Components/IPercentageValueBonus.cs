using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    interface IPercentageValueBonus : IBonusAttribute
    {
        int Value { get; set; }
    }
}
