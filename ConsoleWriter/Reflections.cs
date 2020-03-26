using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriter
{
    class Reflections
    {
        public List<IWeaponType> GetNewInstance(List<ItemType> possibleItemList)
        {
            var itemList = new List<IWeaponType>();
            foreach (var item in possibleItemList)
            {
                var typeName = item.ToString();
                var type = Type.GetType($"ConsoleWriter.{typeName}");
                itemList.Add((IWeaponType)Activator.CreateInstance(type ?? throw new InvalidOperationException()));
            }
            return itemList;
        }
    }

    class OneHand : IWeaponType
    {
        public string Name { get; set; }

        public OneHand()
        {
            Name = "One Handed Weapon";
        }
    }

    class TwoHand : IWeaponType
    {
        public string Name { get; set; }

        public TwoHand()
        {
            Name = "Two Handed Weapon";
        }
    }

    interface IWeaponType
    {
        string Name { get; set; }
    }
}
