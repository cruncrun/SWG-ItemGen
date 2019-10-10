using System;
using System.Collections.Generic;
using System.Text;

namespace SWG.RandomItemGenerator
{
    interface IItemAttribute
    {
        ItemAttributeType ItemAttributeType { get; set; }
    }
}
