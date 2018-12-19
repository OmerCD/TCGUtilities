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
    public partial class DescriptionLine : UserControl
    {
        private Keyword _keyword;
        private readonly TextBox _tBKeywordAction;

        public DescriptionLine(Keyword keyword)
        {
            InitializeComponent();
            _keyword = keyword;
            lKeywordName.Text = keyword.Name;
        }

        private void CheckVariants()
        {

        }
        public string Description => _tBKeywordAction != null ? _tBKeywordAction.Text : "";
    }
}
