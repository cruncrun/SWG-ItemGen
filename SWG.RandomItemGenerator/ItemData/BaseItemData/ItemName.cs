using SWG.RandomDataGenerator.ItemData.ItemAffixes;
using System.Text;

namespace SWG.RandomDataGenerator.ItemData
{
    public class ItemName
    {
        public string BaseItemName { get; set; }
        public Affixes Affixes { get; set; }
        public string FullItemName { get; set; }

        public ItemName()
        {

        }

        public ItemName(Affixes affixes)
        {
            FullItemName = GenerateFullItemName(BaseItemName, affixes);
        }

        public ItemName(string baseItemName, Affixes affixes)
        {
            FullItemName = GenerateFullItemName(baseItemName, affixes);
        }

        private string GenerateFullItemName(string baseItemName, Affixes affixes)
        {
            var separator = " ";
            var sb = new StringBuilder();

            if (affixes.FirstPrefix != null)
            {
                sb.Append(affixes.FirstPrefix.AffixName + separator);
            }
            if (affixes.SecondaryPrefix != null)
            {
                sb.Append(affixes.SecondaryPrefix.AffixName + separator);
            }
            sb.Append(baseItemName);
            if (affixes.Suffix != null)
            {
                sb.Append(separator + affixes.Suffix.AffixName);
            }

            return sb.ToString();
        }
    }

}
