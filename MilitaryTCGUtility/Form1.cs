using MongoCRUD;
using MongoCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MilitaryTCGUtility
{

    public partial class Form1 : Form
    {
        private Crud<Keyword> _crudKeyword;
        private Control _errorControl;
        public Form1()
        {
            InitializeComponent();
            const string CONNECTIONSTRING = "mongodb://ohm:741895623ohm@test-shard-00-00-imtir.mongodb.net:27017,test-shard-00-01-imtir.mongodb.net:27017,test-shard-00-02-imtir.mongodb.net:27017/test?ssl=true&replicaSet=test-shard-0&authSource=admin&retryWrites=true";
            MongoDbConnection.InitializeAndStartConnection(CONNECTIONSTRING, databaseName: "MilitaryTCG");
            _crudKeyword = new Crud<Keyword>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListBox();
          
        }

        public void FillListBox(IEnumerable<Keyword> keywords = null)
        {
            lBKeywords.Items.Clear();
            var resKeywords = keywords ?? _crudKeyword.GetAll();

            var items = resKeywords.ToArray();
            lBKeywords.Items.AddRange(items);

            Text = "Number of Keywords : " + items.Length;
        }

        private void ClearKeywordInfoTextboxes()
        {
            tBName.Text = tBDescription.Text = string.Empty;
            tBName.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            CheckValidation(() =>
            {
                var keyword = new Keyword(tBName.Text, tBDescription.Text);
                _crudKeyword.Insert(keyword);
                FillListBox();
                ClearKeywordInfoTextboxes();
            });

        }

        private void CheckValidation(Action action)
        {
            var notValidatedControl = IsValid;
            if (notValidatedControl == null)
            {

                if (_errorControl?.BackColor == Color.Red)
                {
                    _errorControl.BackColor = Color.White;
                }

                action();
            }
            else
            {
                if (_errorControl != null && _errorControl != notValidatedControl)
                {
                    _errorControl.BackColor = Color.White;
                }
                _errorControl = notValidatedControl;
                notValidatedControl.BackColor = Color.Red;
            }
        }

        private Control IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(tBName.Text))
                {
                    return tBName;
                }
                else if (string.IsNullOrWhiteSpace(tBDescription.Text))
                {
                    return tBDescription;
                }

                return null;
            }
        }

        private void Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBKeywords.SelectedIndex != -1)
            {
                var keyword = (Keyword)lBKeywords.SelectedItem;
                tBName.Text = keyword.Name;
                tBDescription.Text = keyword.Description;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            CheckValidation(() =>
            {
                if (lBKeywords.SelectedIndex != -1)
                {
                    var keyword = (Keyword)lBKeywords.SelectedItem;
                    keyword.Name = tBName.Text;
                    keyword.Description = tBDescription.Text;
                    _crudKeyword.Update(keyword._id, keyword);
                    FillListBox();
                    ClearKeywordInfoTextboxes();
                }
            });


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (lBKeywords.SelectedIndex != -1)
            {
                var keyword = (Keyword)lBKeywords.SelectedItem;
                _crudKeyword.Delete(keyword._id);
                lBKeywords.SelectedIndex = -1;
                FillListBox();
                ClearKeywordInfoTextboxes();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.TextLength > 2)
            {
                var result = _crudKeyword.MultipleFieldSearch(tBSearch.Text, "Name", "Description");
                FillListBox(result);
            }
            else
            {
                FillListBox();
            }
        }
    }
    public class Keyword : DbObject
    {
        public Keyword()
        {
        }

        public Keyword(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
