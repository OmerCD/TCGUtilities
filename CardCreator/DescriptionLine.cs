using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCreator
{
    public partial class DescriptionLine : UserControl
    {
        private readonly Control _valueControl;
        private readonly Point _location = new Point(85, 7);
        private readonly string _variantName;

        public string VariantName => _variantName;

        public string KeywordText
        {
            get
            {
                switch (_valueControl)
                {
                    case NumericUpDown nud:
                        return nud.Value + " " + _variantName;
                    case TextBox tB:
                        return tB.Text;
                    default:
                        throw new NotImplementedException();
                }
            }
        }


        public DescriptionLine(Variant variant)
        {
            InitializeComponent();
            switch (variant)
            {
                case Variant.AP:
                case Variant.HP:
                case Variant.STR:
                    _valueControl = new NumericUpDown();
                    break;
                case Variant.Keyword:
                    _valueControl = new TextBox
                    {
                        Multiline = true,
                        Size = new Size(130, 40),
                    };
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(variant), variant, "How did you do that?");
            }
            _valueControl.Location = _location;
            Controls.Add(_valueControl);
            _variantName = System.Enum.GetName(typeof(Variant), variant);;
            lKeywordName.Text = _variantName;
        }

    }
}
