using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    public class FlatValueBonus : IFlatValueBonus
    {
        public ICharacterAttribute Attribute { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
