﻿using MongoCRUD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

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
            var allKeywords = _keywordCrud.GetAll().ToArray();
            CbKeywords.Items.AddRange(allKeywords);
            FillListBox();
        }
        List<Keyword> _currentCardKeywordList = new List<Keyword>();
        private void BtnAddKeyword_Click(object sender, EventArgs e)
        {
            Keyword currentKeyword = (Keyword)CbKeywords.SelectedItem;
            _currentCardKeywordList.Add(currentKeyword);
            string keywordDescription = CreateDescripton();
            LbCurrentKeywords.Items.Add(keywordDescription);
            FlwKeywords.Controls.Clear();
            TbCardDescription.Text = currentKeyword.Name + ":" + keywordDescription + "\n";
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
                    FlwKeywords.Controls.Add(textBox);

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
            Card card = new Card
            {
                Name = TbName.Text,
                HP = (int)NudHP.Value,
                Cost = (int)NudCost.Value,
                STR = (int)NudSTR.Value,
                Keywords = _currentCardKeywordList,
                Description = TbCardDescription.Text
            };
            ClearFormControls();
            bool isInserted = _cardCrud.Insert(card);
            if (isInserted == true)
            {
                MessageBox.Show($"Card: {card} is inserted");
                LbCardList.Items.Add(card);
            }
            else
            {
                MessageBox.Show("Chichi ile konuşuyor olur öyle");
            }
        }

        private void ClearFormControls()
        {
            TbName.Text = string.Empty;
            TbCardDescription.Text = string.Empty;
            NudHP.Value = 0;
            NudSTR.Value = 0;
            NudCost.Value = 0;
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
                _currentCardKeywordList = currentCard.Keywords;
                LbCurrentKeywords.Items.Clear();
                LbCurrentKeywords.Items.AddRange(TbCardDescription.Text.Split('\n'));// \n çünkü chichi 
            }
        }

        private void BtnEditCard_Click(object sender, EventArgs e)
        {
            Card card = new Card
            {
                Name = TbName.Text,
                HP = (int)NudHP.Value,
                Cost = (int)NudCost.Value,
                STR = (int)NudSTR.Value,
                Keywords = _currentCardKeywordList,
                Description = TbCardDescription.Text
            };
            bool isUpdated = _cardCrud.Update(card._id, card);
            if (isUpdated == true)
            {
                MessageBox.Show($"Card: {card} is updated");
                ClearFormControls();
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
                    MessageBox.Show($"Card: {card} is updated");
                    LbCardList.Items.Remove(card);
                    ClearFormControls();
                }
                else
                {
                    MessageBox.Show("Chichi ile konuşuyor olur öyle");
                }
            }
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
    }
}
