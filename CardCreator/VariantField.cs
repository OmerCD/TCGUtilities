using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator
{
    internal interface IVariantField
    {
        T GetValue<T>();
    }
    public class VariantField : IVariantField
    {
        public VariantField(Variant name)
        {
            VariantType = name;
        }

        public Variant VariantType { get; }
        public object Value { get; set; }
        public T GetValue<T>()
        {
            return (T)Value;
        }
    }

    public enum Variant
    {
        HP, STR, AP, Keyword
    }
}
