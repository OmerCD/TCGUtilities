namespace CardCreator
{
    partial class CardInfoPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBFactions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBRarities = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbCardDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudHP = new System.Windows.Forms.NumericUpDown();
            this.NudSTR = new System.Windows.Forms.NumericUpDown();
            this.NudCost = new System.Windows.Forms.NumericUpDown();
            this.NudAP = new System.Windows.Forms.NumericUpDown();
            this.bClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // cBFactions
            // 
            this.cBFactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFactions.Enabled = false;
            this.cBFactions.FormattingEnabled = true;
            this.cBFactions.Location = new System.Drawing.Point(54, 189);
            this.cBFactions.Name = "cBFactions";
            this.cBFactions.Size = new System.Drawing.Size(171, 21);
            this.cBFactions.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "STR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Faction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cost";
            // 
            // cBRarities
            // 
            this.cBRarities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBRarities.Enabled = false;
            this.cBRarities.FormattingEnabled = true;
            this.cBRarities.Location = new System.Drawing.Point(54, 162);
            this.cBRarities.Name = "cBRarities";
            this.cBRarities.Size = new System.Drawing.Size(171, 21);
            this.cBRarities.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "AP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Rarity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "HP";
            // 
            // TbName
            // 
            this.TbName.Enabled = false;
            this.TbName.Location = new System.Drawing.Point(54, 35);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(169, 20);
            this.TbName.TabIndex = 10;
            // 
            // TbCardDescription
            // 
            this.TbCardDescription.Enabled = false;
            this.TbCardDescription.Location = new System.Drawing.Point(15, 254);
            this.TbCardDescription.Multiline = true;
            this.TbCardDescription.Name = "TbCardDescription";
            this.TbCardDescription.Size = new System.Drawing.Size(242, 174);
            this.TbCardDescription.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Card Description";
            // 
            // NudHP
            // 
            this.NudHP.Enabled = false;
            this.NudHP.Location = new System.Drawing.Point(54, 60);
            this.NudHP.Name = "NudHP";
            this.NudHP.Size = new System.Drawing.Size(169, 20);
            this.NudHP.TabIndex = 17;
            // 
            // NudSTR
            // 
            this.NudSTR.Enabled = false;
            this.NudSTR.Location = new System.Drawing.Point(54, 85);
            this.NudSTR.Name = "NudSTR";
            this.NudSTR.Size = new System.Drawing.Size(169, 20);
            this.NudSTR.TabIndex = 18;
            // 
            // NudCost
            // 
            this.NudCost.Enabled = false;
            this.NudCost.Location = new System.Drawing.Point(54, 110);
            this.NudCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NudCost.Name = "NudCost";
            this.NudCost.Size = new System.Drawing.Size(169, 20);
            this.NudCost.TabIndex = 19;
            // 
            // NudAP
            // 
            this.NudAP.Enabled = false;
            this.NudAP.Location = new System.Drawing.Point(54, 136);
            this.NudAP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NudAP.Name = "NudAP";
            this.NudAP.Size = new System.Drawing.Size(169, 20);
            this.NudAP.TabIndex = 20;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Tomato;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(227, 7);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(32, 25);
            this.bClose.TabIndex = 26;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(188, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CardInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(268, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBFactions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBRarities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.TbCardDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudHP);
            this.Controls.Add(this.NudSTR);
            this.Controls.Add(this.NudCost);
            this.Controls.Add(this.NudAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardInfoPage";
            this.Text = "CardInfoPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardInfoPage_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.NudHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBFactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBRarities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbCardDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudHP;
        private System.Windows.Forms.NumericUpDown NudSTR;
        private System.Windows.Forms.NumericUpDown NudCost;
        private System.Windows.Forms.NumericUpDown NudAP;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button button1;
    }
}