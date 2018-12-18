using MongoCRUD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace CardCreator
{
    public partial class Form1 : Form
    {
        private readonly Crud<Keyword> _keywordCrud;
        private readonly Crud<Card> _cardCrud;
        public Form1()
        {
            InitializeComponent();
            const string ConnectionString = "mongodb://ohm:741895623ohm@test-shard-00-00-imtir.mongodb.net:27017,test-shard-00-01-imtir.mongodb.net:27017,test-shard-00-02-imtir.mongodb.net:27017/test?ssl=true&replicaSet=test-shard-0&authSource=admin&retryWrites=true";
            MongoDbConnection.InitializeAndStartConnection(ConnectionString, databaseName: "MilitaryTCG");
            _keywordCrud = new Crud<Keyword>();
            _cardCrud = new Crud<Card>();
            FillCombobox();
            FillListBox();
        }
        List<Keyword> _currentCardKeywordList = new List<Keyword>();
        private void BtnAddKeyword_Click(object sender, EventArgs e)
        {
            Keyword currentKeyword = (Keyword)CbKeywords.SelectedItem;
            _currentCardKeywordList.Add(currentKeyword);
            string keywordDescription = CreateDescriptonNew();
            FlwKeywords.Controls.Clear();
            string keywordFullText = currentKeyword.Name + ":" + keywordDescription;
            LbCurrentKeywords.Items.Add(keywordFullText);
            TbCardDescription.Text += keywordFullText + "\n";
            FillCombobox();
        }
        private string CreateDescripton()
        {
            string description = TbKeywordDescription.Text;
            foreach (var control in FlwKeywords.Controls)
            {
                if (control is TextBox textbox)
                {
                    int index = int.Parse(textbox.Name);
                    description = description.Remove(index, 1);
                    description = description.Insert(index, textbox.Text);
                }
            }
            return description;
        }
        private string CreateDescriptonNew()
        {
            string description = "";
            foreach (var control in FlwKeywords.Controls)
            {
                if (control is TextBox textbox)
                {
                    description += textbox.Text + " ";
                }
                if (control is ComboBox comboBox)
                {
                    description += comboBox.Text + " ";
                }
            }
            return description;
        }
        private readonly string[] _attributes = { "HP", "AP", "STR", "Turns" };
        private void CbKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyword = (Keyword)CbKeywords.SelectedItem;
            FlwKeywords.Controls.Clear();
            TbKeywordDescription.Text = keyword.Description;
            if (keyword.Description.Contains("$") == true)
            {
                int lastIndex = -1;
                do
                {
                    lastIndex = keyword.Description.IndexOf("$", (lastIndex + 1));
                    TextBox textBox = new TextBox();
                    textBox.Name = lastIndex.ToString();
                    textBox.Size = new System.Drawing.Size(FlwKeywords.Size.Width - 120, textBox.Size.Height);
                    var combobox = new ComboBox();
                    combobox.Items.AddRange(_attributes);
                    combobox.Size = new System.Drawing.Size(100, combobox.Size.Height);
                    combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    FlwKeywords.Controls.Add(textBox);
                    FlwKeywords.Controls.Add(combobox);

                } while (lastIndex < keyword.Description.LastIndexOf("$"));
            }
        }
        private void BtnDeleteKeyword_Click(object sender, EventArgs e)
        {
            int selectedIndex = LbCurrentKeywords.SelectedIndex;
            if (selectedIndex > -1)
            {
                var text = LbCurrentKeywords.SelectedItem.ToString();
                LbCurrentKeywords.Items.RemoveAt(selectedIndex);
                string oldKeyword = _currentCardKeywordList[selectedIndex] + ":" + text + "\n";// \n çünkü chichi
                TbCardDescription.Text = TbCardDescription.Text.Replace(oldKeyword, string.Empty);
                _currentCardKeywordList.RemoveAt(selectedIndex);
                FillCombobox();
            }
        }
        private void BtnEditKeyword_Click(object sender, EventArgs e)
        {
            int selectedIndex = LbCurrentKeywords.SelectedIndex;
            if (selectedIndex > -1)
            {
                var text = LbCurrentKeywords.SelectedItem.ToString();
                LbCurrentKeywords.Items.RemoveAt(selectedIndex);
                string oldKeyword = _currentCardKeywordList[selectedIndex] + ":" + text + "\n"; // \n çünkü chichi
                TbCardDescription.Text = TbCardDescription.Text.Replace(oldKeyword, string.Empty);
                CbKeywords.SelectedItem = _currentCardKeywordList[selectedIndex];
                _currentCardKeywordList.RemoveAt(selectedIndex);
                FillCombobox();
            }
        }
        void FillListBox()
        {
            LbCardList.Items.Clear();
            var allCards = _cardCrud.GetAll().ToArray();
            LbCardList.Items.AddRange(allCards);
        }
        private void BtnCreateCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbName.Text) == true)
            {
                MessageBox.Show("Please Enter A card Name");

            }
            else if (IsCardNameUnique(TbName.Text) == false)
            {
                MessageBox.Show("CardName must be unique");
            }
            else
            {

                Card card = new Card
                {
                    Name = TbName.Text,
                    HP = (int)NudHP.Value,
                    Cost = (int)NudCost.Value,
                    STR = (int)NudSTR.Value,
                    Keywords = _currentCardKeywordList,
                    Description = TbCardDescription.Text,
                    AP = (int)NudAP.Value
                };
                ClearFormControls();
                bool isInserted = _cardCrud.Insert(card);
                if (isInserted == true)
                {
                    MessageBox.Show($"Card: {card} is inserted");
                    FillListBox();
                }
                else
                {
                    MessageBox.Show("Chichi ile konuşuyor olur öyle");
                }
            }

        }
        bool IsKeywordAdded(string keywordName)
        {
            return _currentCardKeywordList.Any(x => x.Name == keywordName);
        }
        private bool IsCardNameUnique(string cardName)
        {
            var cardList = _cardCrud.Search("Name", cardName);
            if (cardList.Count <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ClearFormControls()
        {
            TbName.Text = string.Empty;
            TbCardDescription.Text = string.Empty;
            NudHP.Value = 1;
            NudSTR.Value = 1;
            NudCost.Value = 1;
            NudAP.Value = 1;
            LbCurrentKeywords.Items.Clear();
            _currentCardKeywordList.Clear();
        }
        private void LbCardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = LbCardList.SelectedIndex;
            if (selectedIndex > -1)
            {
                Card currentCard = (Card)LbCardList.SelectedItem;
                TbName.Text = currentCard.Name;
                TbCardDescription.Text = currentCard.Description;
                NudCost.Value = currentCard.Cost;
                NudHP.Value = currentCard.HP;
                NudSTR.Value = currentCard.STR;
                NudAP.Value = currentCard.AP;
                _currentCardKeywordList = currentCard.Keywords;
                LbCurrentKeywords.Items.Clear();
                LbCurrentKeywords.Items.AddRange(TbCardDescription.Text.Split('\n'));// \n çünkü chichi 
            }
        }
        private void BtnEditCard_Click(object sender, EventArgs e)
        {
            var oldID = ((Card)(LbCardList.SelectedItem))._id;
            Card card = new Card
            {
                Name = TbName.Text,
                HP = (int)NudHP.Value,
                Cost = (int)NudCost.Value,
                STR = (int)NudSTR.Value,
                AP = (int)NudAP.Value,
                Keywords = _currentCardKeywordList,
                Description = TbCardDescription.Text,
                _id = oldID
            };
            bool isUpdated = _cardCrud.Update(oldID, card);
            if (isUpdated == true)
            {
                MessageBox.Show($"Card: {card} is updated");
                ClearFormControls();
                FillListBox();
            }
            else
            {
                MessageBox.Show("Chichi ile konuşuyor olur öyle");
            }
        }
        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            int selectedIndex = LbCardList.SelectedIndex;
            if (selectedIndex > -1)
            {
                Card card = (Card)LbCardList.SelectedItem;
                bool isDeleted = _cardCrud.Delete(card._id);
                if (isDeleted == true)
                {
                    MessageBox.Show($"Card: {card} is delete");
                    FillListBox();
                    ClearFormControls();
                }
                else
                {
                    MessageBox.Show("Chichi ile konuşuyor olur öyle");
                }
            }
        }
        void FillCombobox()
        {
            CbKeywords.Items.Clear();
            var allKeywords = _keywordCrud.GetAll()
                .Where(x=> IsKeywordAdded(x.Name) == false).ToArray();
            CbKeywords.Items.AddRange(allKeywords);
            CbKeywords.Text = string.Empty;
            TbKeywordDescription.Text = string.Empty;
        }
        private void TbSearchText_TextChanged(object sender, EventArgs e)
        {
            if (TbSearchText.TextLength > 2)
            {
                List<Card> cardsInListbox = new List<Card>();
                foreach (Card item in LbCardList.Items)
                {
                    string searchTextAsLower = TbSearchText.Text.ToLower();
                    if (item.Name.ToLower().Contains(searchTextAsLower) == true ||
                        item.Description.ToLower().Contains(searchTextAsLower))
                    {
                        cardsInListbox.Add(item);
                    }
                }
                LbCardList.Items.Clear();
                LbCardList.Items.AddRange(cardsInListbox.ToArray());
            }
            else
            {
                FillListBox();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
