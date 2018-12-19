using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCreator
{
    public partial class Description : UserControl
    {
        private readonly List<Control> _controls;
        public Description()
        {
            _controls = new List<Control>();
            InitializeComponent();
        }

        public void CreateKeywordFields(string descriptionText)
        {
            fLPDescriptionContainer.Controls.Clear();
            var variants = KeywordAnalyzer.GetVariantFields(descriptionText);
            foreach (var variantField in variants)
            {
                var keyword = new Keyword(Enum.GetName(typeof(Variant), variantField.VariantType), descriptionText);
                var dL = new DescriptionLine(keyword);
                _controls.Add(dL);
                fLPDescriptionContainer.Controls.Add(dL);
            }
        }
    }
}
