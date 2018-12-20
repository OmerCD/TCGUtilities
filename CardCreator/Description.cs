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
        private string _descriptionText;

        public Description()
        {
            _controls = new List<Control>();
            InitializeComponent();
        }
        private string ReplaceText(string sourceText, string toReplace, string replacingText, ref int lastIndex)
        {
            lastIndex = sourceText.IndexOf(toReplace, lastIndex, StringComparison.Ordinal);
            var result = sourceText.Remove(lastIndex, toReplace.Length).Insert(lastIndex, replacingText);
            return result;
        }
        public void CreateKeywordFields(string descriptionText)
        {
            _descriptionText = descriptionText;
            fLPDescriptionContainer.Controls.Clear();
            var variants = KeywordAnalyzer.GetVariantFields(descriptionText);
            foreach (var variantField in variants)
            {
                var dL = new DescriptionLine(variantField.VariantType);
                _controls.Add(dL);
                fLPDescriptionContainer.Controls.Add(dL);
            }
        }

        public string GetDescriptionText()
        {
            var newDescription = string.Copy(_descriptionText);
            var lastIndex = 0;
            foreach (DescriptionLine control in _controls)
            {
                newDescription = (ReplaceText(newDescription, "{$:" + control.VariantName + "}", control.KeywordText, ref lastIndex));
            }

            return newDescription;
        }
    }
}
