using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator
{
    public static class KeywordAnalyzer
    {
        public static ICollection<VariantField> GetVariantFields(string keywordDescription) // {$:AP} - {$:Keyword}
        {

            var endingTagIndex = keywordDescription.LastIndexOf("{$:", StringComparison.Ordinal);

            var variants = new List<VariantField>();
            int lastIndex = 0;

            do
            {
                lastIndex = keywordDescription.IndexOf("{$:", lastIndex, StringComparison.Ordinal);
                var variantName = GetVariantName(keywordDescription, ref lastIndex);
                if (Enum.TryParse<Variant>(variantName, out var res))
                {
                    variants.Add(new VariantField(res));
                }

            } while (lastIndex < endingTagIndex);

            return variants;
        }

        private static string GetVariantName(string keywordDescription, ref int lastIndex)
        {
            lastIndex += 3;
            var sBuilder = new StringBuilder();
            do
            {
                sBuilder.Append(keywordDescription[lastIndex++]);
            } while (keywordDescription[lastIndex] != '}');
            return sBuilder.ToString();
        }
    }
}
