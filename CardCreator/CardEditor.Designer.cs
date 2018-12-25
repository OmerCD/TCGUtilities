namespace CardCreator
{
    partial class CardEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbCurrentKeywords = new System.Windows.Forms.ListBox();
            this.TbKeywordDescription = new System.Windows.Forms.TextBox();
            this.BtnEditKeyword = new System.Windows.Forms.Button();
            this.BtnDeleteKeyword = new System.Windows.Forms.Button();
            this.BtnAddKeyword = new System.Windows.Forms.Button();
            this.FlwKeywords = new System.Windows.Forms.FlowLayoutPanel();
            this.CbKeywords = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.NudHP = new System.Windows.Forms.NumericUpDown();
            this.NudSTR = new System.Windows.Forms.NumericUpDown();
            this.NudCost = new System.Windows.Forms.NumericUpDown();
            this.TbCardDescription = new System.Windows.Forms.TextBox();
            this.BtnCreateCard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbCardList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEditCard = new System.Windows.Forms.Button();
            this.BtnDeleteCard = new System.Windows.Forms.Button();
            this.TbSearchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NudAP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cBRarities = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBFactions = new System.Windows.Forms.ComboBox();
            this.gBCardDetails = new System.Windows.Forms.GroupBox();
            this.bClearCardDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAP)).BeginInit();
            this.gBCardDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbCurrentKeywords);
            this.groupBox1.Controls.Add(this.TbKeywordDescription);
            this.groupBox1.Controls.Add(this.BtnEditKeyword);
            this.groupBox1.Controls.Add(this.BtnDeleteKeyword);
            this.groupBox1.Controls.Add(this.BtnAddKeyword);
            this.groupBox1.Controls.Add(this.FlwKeywords);
            this.groupBox1.Controls.Add(this.CbKeywords);
            this.groupBox1.Location = new System.Drawing.Point(505, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Keywords";
            // 
            // LbCurrentKeywords
            // 
            this.LbCurrentKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCurrentKeywords.FormattingEnabled = true;
            this.LbCurrentKeywords.HorizontalScrollbar = true;
            this.LbCurrentKeywords.Location = new System.Drawing.Point(7, 208);
            this.LbCurrentKeywords.Name = "LbCurrentKeywords";
            this.LbCurrentKeywords.Size = new System.Drawing.Size(266, 186);
            this.LbCurrentKeywords.TabIndex = 4;
            // 
            // TbKeywordDescription
            // 
            this.TbKeywordDescription.Enabled = false;
            this.TbKeywordDescription.Location = new System.Drawing.Point(7, 47);
            this.TbKeywordDescription.Multiline = true;
            this.TbKeywordDescription.Name = "TbKeywordDescription";
            this.TbKeywordDescription.Size = new System.Drawing.Size(266, 147);
            this.TbKeywordDescription.TabIndex = 3;
            // 
            // BtnEditKeyword
            // 
            this.BtnEditKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditKeyword.Location = new System.Drawing.Point(147, 398);
            this.BtnEditKeyword.Name = "BtnEditKeyword";
            this.BtnEditKeyword.Size = new System.Drawing.Size(126, 23);
            this.BtnEditKeyword.TabIndex = 2;
            this.BtnEditKeyword.Text = "Edit Keyword";
            this.BtnEditKeyword.UseVisualStyleBackColor = true;
            this.BtnEditKeyword.Click += new System.EventHandler(this.BtnEditKeyword_Click);
            // 
            // BtnDeleteKeyword
            // 
            this.BtnDeleteKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeleteKeyword.Location = new System.Drawing.Point(77, 427);
            this.BtnDeleteKeyword.Name = "BtnDeleteKeyword";
            this.BtnDeleteKeyword.Size = new System.Drawing.Size(126, 23);
            this.BtnDeleteKeyword.TabIndex = 2;
            this.BtnDeleteKeyword.Text = "Delete Keyword";
            this.BtnDeleteKeyword.UseVisualStyleBackColor = true;
            this.BtnDeleteKeyword.Click += new System.EventHandler(this.BtnDeleteKeyword_Click);
            // 
            // BtnAddKeyword
            // 
            this.BtnAddKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddKeyword.Location = new System.Drawing.Point(6, 398);
            this.BtnAddKeyword.Name = "BtnAddKeyword";
            this.BtnAddKeyword.Size = new System.Drawing.Size(126, 23);
            this.BtnAddKeyword.TabIndex = 2;
            this.BtnAddKeyword.Text = "Add Keyword";
            this.BtnAddKeyword.UseVisualStyleBackColor = true;
            this.BtnAddKeyword.Click += new System.EventHandler(this.BtnAddKeyword_Click);
            // 
            // FlwKeywords
            // 
            this.FlwKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwKeywords.Location = new System.Drawing.Point(283, 19);
            this.FlwKeywords.Name = "FlwKeywords";
            this.FlwKeywords.Size = new System.Drawing.Size(266, 438);
            this.FlwKeywords.TabIndex = 1;
            // 
            // CbKeywords
            // 
            this.CbKeywords.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbKeywords.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbKeywords.FormattingEnabled = true;
            this.CbKeywords.Location = new System.Drawing.Point(7, 20);
            this.CbKeywords.Name = "CbKeywords";
            this.CbKeywords.Size = new System.Drawing.Size(266, 21);
            this.CbKeywords.TabIndex = 0;
            this.CbKeywords.SelectedIndexChanged += new System.EventHandler(this.CbKeywords_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "STR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Card Description";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(65, 25);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(169, 20);
            this.TbName.TabIndex = 0;
            // 
            // NudHP
            // 
            this.NudHP.Location = new System.Drawing.Point(65, 50);
            this.NudHP.Name = "NudHP";
            this.NudHP.Size = new System.Drawing.Size(169, 20);
            this.NudHP.TabIndex = 1;
            // 
            // NudSTR
            // 
            this.NudSTR.Location = new System.Drawing.Point(65, 75);
            this.NudSTR.Name = "NudSTR";
            this.NudSTR.Size = new System.Drawing.Size(169, 20);
            this.NudSTR.TabIndex = 2;
            // 
            // NudCost
            // 
            this.NudCost.Location = new System.Drawing.Point(65, 100);
            this.NudCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NudCost.Name = "NudCost";
            this.NudCost.Size = new System.Drawing.Size(169, 20);
            this.NudCost.TabIndex = 3;
            // 
            // TbCardDescription
            // 
            this.TbCardDescription.Location = new System.Drawing.Point(26, 244);
            this.TbCardDescription.Multiline = true;
            this.TbCardDescription.Name = "TbCardDescription";
            this.TbCardDescription.Size = new System.Drawing.Size(242, 174);
            this.TbCardDescription.TabIndex = 5;
            // 
            // BtnCreateCard
            // 
            this.BtnCreateCard.Location = new System.Drawing.Point(285, 409);
            this.BtnCreateCard.Name = "BtnCreateCard";
            this.BtnCreateCard.Size = new System.Drawing.Size(201, 30);
            this.BtnCreateCard.TabIndex = 6;
            this.BtnCreateCard.Text = "Create Card";
            this.BtnCreateCard.UseVisualStyleBackColor = true;
            this.BtnCreateCard.Click += new System.EventHandler(this.BtnCreateCard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cost";
            // 
            // LbCardList
            // 
            this.LbCardList.FormattingEnabled = true;
            this.LbCardList.Location = new System.Drawing.Point(288, 25);
            this.LbCardList.Name = "LbCardList";
            this.LbCardList.Size = new System.Drawing.Size(198, 316);
            this.LbCardList.TabIndex = 5;
            this.LbCardList.SelectedIndexChanged += new System.EventHandler(this.LbCardList_SelectedIndexChanged);
            this.LbCardList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardList_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CardList";
            // 
            // BtnEditCard
            // 
            this.BtnEditCard.Location = new System.Drawing.Point(285, 445);
            this.BtnEditCard.Name = "BtnEditCard";
            this.BtnEditCard.Size = new System.Drawing.Size(201, 30);
            this.BtnEditCard.TabIndex = 7;
            this.BtnEditCard.Text = "Edit Card";
            this.BtnEditCard.UseVisualStyleBackColor = true;
            this.BtnEditCard.Click += new System.EventHandler(this.BtnEditCard_Click);
            // 
            // BtnDeleteCard
            // 
            this.BtnDeleteCard.Location = new System.Drawing.Point(285, 373);
            this.BtnDeleteCard.Name = "BtnDeleteCard";
            this.BtnDeleteCard.Size = new System.Drawing.Size(201, 30);
            this.BtnDeleteCard.TabIndex = 4;
            this.BtnDeleteCard.Text = "Delete Card";
            this.BtnDeleteCard.UseVisualStyleBackColor = true;
            this.BtnDeleteCard.Click += new System.EventHandler(this.BtnDeleteCard_Click);
            // 
            // TbSearchText
            // 
            this.TbSearchText.Location = new System.Drawing.Point(288, 347);
            this.TbSearchText.Name = "TbSearchText";
            this.TbSearchText.Size = new System.Drawing.Size(198, 20);
            this.TbSearchText.TabIndex = 7;
            this.TbSearchText.TextChanged += new System.EventHandler(this.TbSearchText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "AP";
            // 
            // NudAP
            // 
            this.NudAP.Location = new System.Drawing.Point(65, 126);
            this.NudAP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NudAP.Name = "NudAP";
            this.NudAP.Size = new System.Drawing.Size(169, 20);
            this.NudAP.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rarity";
            // 
            // cBRarities
            // 
            this.cBRarities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRarities.FormattingEnabled = true;
            this.cBRarities.Location = new System.Drawing.Point(65, 152);
            this.cBRarities.Name = "cBRarities";
            this.cBRarities.Size = new System.Drawing.Size(171, 21);
            this.cBRarities.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Faction";
            // 
            // cBFactions
            // 
            this.cBFactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFactions.FormattingEnabled = true;
            this.cBFactions.Location = new System.Drawing.Point(65, 179);
            this.cBFactions.Name = "cBFactions";
            this.cBFactions.Size = new System.Drawing.Size(171, 21);
            this.cBFactions.TabIndex = 9;
            // 
            // gBCardDetails
            // 
            this.gBCardDetails.Controls.Add(this.bClearCardDetails);
            this.gBCardDetails.Controls.Add(this.label1);
            this.gBCardDetails.Controls.Add(this.cBFactions);
            this.gBCardDetails.Controls.Add(this.label3);
            this.gBCardDetails.Controls.Add(this.label9);
            this.gBCardDetails.Controls.Add(this.label5);
            this.gBCardDetails.Controls.Add(this.cBRarities);
            this.gBCardDetails.Controls.Add(this.label7);
            this.gBCardDetails.Controls.Add(this.label8);
            this.gBCardDetails.Controls.Add(this.label2);
            this.gBCardDetails.Controls.Add(this.TbName);
            this.gBCardDetails.Controls.Add(this.TbCardDescription);
            this.gBCardDetails.Controls.Add(this.label4);
            this.gBCardDetails.Controls.Add(this.NudHP);
            this.gBCardDetails.Controls.Add(this.NudSTR);
            this.gBCardDetails.Controls.Add(this.NudCost);
            this.gBCardDetails.Controls.Add(this.NudAP);
            this.gBCardDetails.Location = new System.Drawing.Point(5, 7);
            this.gBCardDetails.Name = "gBCardDetails";
            this.gBCardDetails.Size = new System.Drawing.Size(274, 482);
            this.gBCardDetails.TabIndex = 10;
            this.gBCardDetails.TabStop = false;
            this.gBCardDetails.Text = "Card Properties";
            // 
            // bClearCardDetails
            // 
            this.bClearCardDetails.Location = new System.Drawing.Point(61, 433);
            this.bClearCardDetails.Name = "bClearCardDetails";
            this.bClearCardDetails.Size = new System.Drawing.Size(173, 23);
            this.bClearCardDetails.TabIndex = 11;
            this.bClearCardDetails.Text = "Clear Card Properties";
            this.bClearCardDetails.UseVisualStyleBackColor = true;
            this.bClearCardDetails.Click += new System.EventHandler(this.ClearCardDetails_Click);
            // 
            // CardEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 501);
            this.Controls.Add(this.gBCardDetails);
            this.Controls.Add(this.TbSearchText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbCardList);
            this.Controls.Add(this.BtnDeleteCard);
            this.Controls.Add(this.BtnEditCard);
            this.Controls.Add(this.BtnCreateCard);
            this.Controls.Add(this.groupBox1);
            this.Name = "CardEditor";
            this.Text = "Create Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAP)).EndInit();
            this.gBCardDetails.ResumeLayout(false);
            this.gBCardDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddKeyword;
        private System.Windows.Forms.FlowLayoutPanel FlwKeywords;
        private System.Windows.Forms.ComboBox CbKeywords;
        private System.Windows.Forms.TextBox TbKeywordDescription;
        private System.Windows.Forms.ListBox LbCurrentKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.NumericUpDown NudHP;
        private System.Windows.Forms.NumericUpDown NudSTR;
        private System.Windows.Forms.NumericUpDown NudCost;
        private System.Windows.Forms.TextBox TbCardDescription;
        private System.Windows.Forms.Button BtnEditKeyword;
        private System.Windows.Forms.Button BtnDeleteKeyword;
        private System.Windows.Forms.Button BtnCreateCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbCardList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEditCard;
        private System.Windows.Forms.Button BtnDeleteCard;
        private System.Windows.Forms.TextBox TbSearchText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudAP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBRarities;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBFactions;
        private System.Windows.Forms.GroupBox gBCardDetails;
        private System.Windows.Forms.Button bClearCardDetails;
    }
}

