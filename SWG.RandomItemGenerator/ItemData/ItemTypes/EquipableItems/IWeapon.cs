namespace SWG.RandomDataGenerator.ItemData.ItemTypes.EquipableItems
{
    public interface IWeapon : IEquipableItem
    {
        int SlotsTaken { get; set; }
    }
}