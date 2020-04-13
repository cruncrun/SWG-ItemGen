using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomDataGenerator.Components
{
    public class Agility : ICharacterAttribute
    {
        public string Name { get; set; }

        public Agility()
        {
            Name = nameof(Agility);
        }
    }
}
