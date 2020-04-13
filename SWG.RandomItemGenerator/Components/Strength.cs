using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    public class Strength : ICharacterAttribute
    {

        public Strength()
        {
            Name = nameof(Strength);
        }

        public string Name { get; set; }
    }
}
