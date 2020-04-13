namespace SWG.RandomDataGenerator.ItemData.BaseItemData.WeaponSpecificData
{
    public class WeaponDamageRange : IItemTypeSpecificData
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public string Name { get; set; }

        public WeaponDamageRange()
        {
            Name = "Obrażenia";
        }
    }
}
