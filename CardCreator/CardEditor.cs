using MongoCRUD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using CardCreator.Enum;
using FactionEditor;
using MongoCRUD.Interfaces;

namespace CardCreator
{
    public partial class CardEditor : Form
    {
        private List<Keyword> _currentCardKeywordList = new List<Keyword>();

        private readonly Crud<Keyword> _keywordCrud;
        private readonly Crud<Card> _cardCrud;
        private readonly Crud<FactionEditor.Faction> _crudFaction;

        private readonly string[] _attributes = { "HP", "AP", "STR", "Turn(s)" };
        private readonly CardInfoPage _cardInfoPage;

        public CardEditor()
        {
            InitializeComponent();


            const string ConnectionString = "mongodb://ohm:741895623ohm@test-shard-00-00-imtir.mongodb.net:27017,test-shard-00-01-imtir.mongodb.net:27017,test-shard-00-02-imtir.mongodb.net:27017/test?ssl=true&replicaSet=test-shard-0&authSource=admin&retryWrites=true";
            MongoDbConnection.InitializeAndStartConnection(ConnectionString, databaseName: "MilitaryTCG");

            _keywordCrud = new Crud<Keyword>();
            _cardCrud = new Crud<Card>();
            _crudFaction = new Crud<FactionEditor.Faction>();

            _cardInfoPage = new CardInfoPage(FillFactionComboBox());

            FillRarityComboBox();
            FillCombobox();
            FillListBox();
        }

        private List<Faction> FillFactionComboBox()
        {
            cBFactions.Items.Clear();
            var factions = _crudFaction.GetAll();
            cBFactions.Items.AddRange(factions.ToArray());
            if (cBFactions.Items.Count > 0)
            {
                var merc = factions.FirstOrDefault(x => x.Name == "Mercenary");
                cBFactions.SelectedItem = merc ?? factions[0];
            }

            return factions;
        }

        private void FillRarityComboBox()
        {
            cBRarities.Items.Clear();
            cBRarities.DataSource = System.Enum.GetValues(typeof(Rarity));
            if (cBRarities.Items.Count > 0)
            {
                cBRarities.SelectedIndex = 0;
            }
        }

        private void ClearCardDetailControls()
        {
            foreach (Control control in gBCardDetails.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
                else if (control.Name == cBFactions.Name)
                {
                    for (int i = 0; i < cBFactions.Items.Count; i++)
                    {
                        if (((Faction)cBFactions.Items[i]).Name == "Mercenary")
                        {
                            cBFactions.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }
            }

            TbName.Focus();
        }
        private void BtnAddKeyword_Click(object sender, EventArgs e)
        {
            var currentKeyword = (Keyword)CbKeywords.SelectedItem;
            _currentCardKeywordList.Add(currentKeyword);
            var keywordDescription = CreateDescriptionNew();
            FlwKeywords.Controls.Clear();
            var keywordFullText = currentKeyword.Name + ":" + keywordDescription;
            LbCurrentKeywords.Items.Add(keywordFullText);
            TbCardDescription.Text += keywordFullText + "\n";
            FillCombobox();
        }
        private string CreateDescription()
        {
            var description = TbKeywordDescription.Text;
            foreach (Control control in FlwKeywords.Controls)
            {
                if (control is TextBox)
                {
                    var index = int.Parse(control.Name);
                    description = description.Remove(index, 1);
                    description = description.Insert(index, control.Text);
                }
            }
            return description;
        }
        private string CreateDescriptionNew()
        {
            var description = new System.Text.StringBuilder();
            foreach (Control control in FlwKeywords.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (control.Name.StartsWith("DS:"))
                        description.Append("= ");

                    description.Append(control.Text + " ");
                }
            }
            return description.ToString();
        }

        private void CbKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyword = (Keyword)CbKeywords.SelectedItem;
            FlwKeywords.Controls.Clear();
            TbKeywordDescription.Text = keyword.Description;
            if (keyword.Description.Contains("$") == true)
            {
                var lastIndex = -1;
                do
                {
                    lastIndex = keyword.Description.IndexOf("$", (lastIndex + 1), StringComparison.Ordinal);
                    var textBox = new TextBox
                    {
                        Name = lastIndex.ToString()
                    };
                    textBox.Size = new System.Drawing.Size(FlwKeywords.Size.Width - 120, textBox.Size.Height);
                    var combobox = new ComboBox();
                    combobox.Items.AddRange(_attributes);
                    combobox.Size = new System.Drawing.Size(100, combobox.Size.Height);
                    combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    FlwKeywords.Controls.Add(textBox);
                    FlwKeywords.Controls.Add(combobox);

                } while (lastIndex < keyword.Description.LastIndexOf("$", StringComparison.Ordinal));
            }

            var dsCount = keyword.Description.Count(x => x == '€');
            if (dsCount > 0)
            {
                for (int i = 0; i < dsCount; i++)
                {
                    var label = new Label
                    {
                        Text = (i + 1) + ". Do Something ",
                        Margin = new Padding(3, 5, 3, 3)
                    };
                    var textBox = new TextBox
                    {
                        Name = "DS:" + i
                    };
                    textBox.Size = new System.Drawing.Size(FlwKeywords.Size.Width - 120, textBox.Size.Height);
                    FlwKeywords.Controls.Add(label);
                    FlwKeywords.Controls.Add(textBox);
                }
            }
        }
        private void BtnDeleteKeyword_Click(object sender, EventArgs e)
        {
            var selectedIndex = LbCurrentKeywords.SelectedIndex;
            if (selectedIndex > -1)
            {
                var text = LbCurrentKeywords.SelectedItem.ToString();
                LbCurrentKeywords.Items.RemoveAt(selectedIndex);
                var oldKeyword = _currentCardKeywordList[selectedIndex] + ":" + text + "\n";// \n çünkü chichi
                TbCardDescription.Text = TbCardDescription.Text.Replace(oldKeyword, string.Empty);
                _currentCardKeywordList.RemoveAt(selectedIndex);
                FillCombobox();
            }
        }
        private void BtnEditKeyword_Click(object sender, EventArgs e)
        {
            var selectedIndex = LbCurrentKeywords.SelectedIndex;
            if (selectedIndex > -1)
            {
                var text = LbCurrentKeywords.SelectedItem.ToString();
                LbCurrentKeywords.Items.RemoveAt(selectedIndex);
                var oldKeyword = _currentCardKeywordList[selectedIndex] + ":" + text + "\n"; // \n çünkü chichi
                TbCardDescription.Text = TbCardDescription.Text.Replace(oldKeyword, string.Empty);
                CbKeywords.SelectedItem = _currentCardKeywordList[selectedIndex];
                _currentCardKeywordList.RemoveAt(selectedIndex);
                FillCombobox();
            }
        }

        private void FillListBox()
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

                var card = new Card
                {
                    Name = TbName.Text,
                    HP = (int)NudHP.Value,
                    Cost = (int)NudCost.Value,
                    STR = (int)NudSTR.Value,
                    Keywords = _currentCardKeywordList,
                    Description = TbCardDescription.Text,
                    AP = (int)NudAP.Value,
                    Rarity = (Rarity)cBRarities.SelectedItem,
                    Faction = (FactionEditor.Faction)cBFactions.SelectedItem
                };
                ClearFormControls();
                var isInserted = _cardCrud.Insert(card);
                if (isInserted == true)
                {
                    MessageBox.Show($"Card: {card} is inserted");
                    FillListBox();
                    ClearCardDetailControls();
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
            int GetFactionIndex(DbObject faction)
            {
                if (faction == null) return 0;
                for (int i = 0; i < cBFactions.Items.Count; i++)
                {
                    if (((FactionEditor.Faction)cBFactions.Items[i])._id == faction._id)
                    {
                        return i;
                    }
                }
                return -1;
            }
            var selectedIndex = LbCardList.SelectedIndex;
            if (selectedIndex > -1)
            {
                var currentCard = (Card)LbCardList.SelectedItem;
                TbName.Text = currentCard.Name;
                TbCardDescription.Text = currentCard.Description;
                NudCost.Value = currentCard.Cost;
                NudHP.Value = currentCard.HP;
                NudSTR.Value = currentCard.STR;
                NudAP.Value = currentCard.AP;
                cBRarities.SelectedIndex = (int)currentCard.Rarity;
                cBFactions.SelectedIndex = GetFactionIndex(currentCard.Faction);
                _currentCardKeywordList = currentCard.Keywords;
                LbCurrentKeywords.Items.Clear();
                LbCurrentKeywords.Items.AddRange(TbCardDescription.Text.Split('\n').Where(x => string.IsNullOrWhiteSpace(x) == false).ToArray());// \n çünkü chichi 
            }
        }
        private void BtnEditCard_Click(object sender, EventArgs e)
        {
            var oldID = ((Card)(LbCardList.SelectedItem))._id;
            var card = new Card
            {
                Name = TbName.Text,
                HP = (int)NudHP.Value,
                Cost = (int)NudCost.Value,
                STR = (int)NudSTR.Value,
                AP = (int)NudAP.Value,
                Keywords = _currentCardKeywordList,
                Description = TbCardDescription.Text,
                _id = oldID,
                Rarity = (Rarity)cBRarities.SelectedItem,
                Faction = (FactionEditor.Faction)cBFactions.SelectedItem
            };
            if (_cardCrud.Update(oldID, card) == true)
            {
                MessageBox.Show($"Card: {card} is updated");
                ClearCardDetailControls();
                FillListBox();
            }
            else
            {
                MessageBox.Show("Chichi ile konuşuyor olur öyle");
            }
        }
        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            var selectedIndex = LbCardList.SelectedIndex;
            if (selectedIndex > -1)
            {
                var card = (Card)LbCardList.SelectedItem;
                var isDeleted = _cardCrud.Delete(card._id);
                if (isDeleted == true)
                {
                    MessageBox.Show($"Card: {card} is delete");
                    FillListBox();
                    
                }
                else
                {
                    MessageBox.Show("Chichi ile konuşuyor olur öyle");
                }
            }
        }

        private void FillCombobox()
        {
            CbKeywords.Items.Clear();
            var allKeywords = _keywordCrud.GetAll()
                .Where(x => IsKeywordAdded(x.Name) == false).ToArray();
            CbKeywords.Items.AddRange(allKeywords);
            CbKeywords.Text = string.Empty;
            TbKeywordDescription.Text = string.Empty;
        }
        private void TbSearchText_TextChanged(object sender, EventArgs e)
        {
            if (TbSearchText.TextLength > 2)
            {
                var cardsInListbox = new List<Card>();
                foreach (Card item in LbCardList.Items)
                {
                    var searchTextAsLower = TbSearchText.Text.ToLower();
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

        private void ClearCardDetails_Click(object sender, EventArgs e)
        {
            ClearCardDetailControls();
        }

        private void CardList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var selectedCard = (Card) LbCardList.Items[LbCardList.IndexFromPoint(e.X, e.Y)];
                _cardInfoPage.Card = selectedCard;
                if (_cardInfoPage.Visible == false)
                {
                    _cardInfoPage.Show();
                }
                else
                {
                    _cardInfoPage.Activate();
                }
            }
        }
    }

}
