namespace TestField
{
    partial class BattleField
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
            this.components = new System.ComponentModel.Container();
            this.fLPField = new System.Windows.Forms.FlowLayoutPanel();
            this.cMSCardAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSTBUnitCost = new System.Windows.Forms.ToolStripTextBox();
            this.removeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEndTurn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBPlayer2 = new System.Windows.Forms.GroupBox();
            this.nUDPlayer2HP = new System.Windows.Forms.NumericUpDown();
            this.nUDPlayer2Gold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gBPlayer1 = new System.Windows.Forms.GroupBox();
            this.nUDPlayer1HP = new System.Windows.Forms.NumericUpDown();
            this.nUDPlayer1Gold = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cMSCardAction.SuspendLayout();
            this.gBPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer2HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer2Gold)).BeginInit();
            this.gBPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer1HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer1Gold)).BeginInit();
            this.SuspendLayout();
            // 
            // fLPField
            // 
            this.fLPField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPField.BackColor = System.Drawing.Color.Bisque;
            this.fLPField.Location = new System.Drawing.Point(198, 12);
            this.fLPField.Name = "fLPField";
            this.fLPField.Size = new System.Drawing.Size(821, 902);
            this.fLPField.TabIndex = 0;
            // 
            // cMSCardAction
            // 
            this.cMSCardAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCardToolStripMenuItem,
            this.removeCardToolStripMenuItem});
            this.cMSCardAction.Name = "cMSCardAction";
            this.cMSCardAction.Size = new System.Drawing.Size(146, 48);
            // 
            // addCardToolStripMenuItem
            // 
            this.addCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSTBUnitCost});
            this.addCardToolStripMenuItem.Name = "addCardToolStripMenuItem";
            this.addCardToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addCardToolStripMenuItem.Text = "Add Card";
            // 
            // tSTBUnitCost
            // 
            this.tSTBUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSTBUnitCost.Name = "tSTBUnitCost";
            this.tSTBUnitCost.Size = new System.Drawing.Size(100, 23);
            this.tSTBUnitCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitCost_KeyDown);
            // 
            // removeCardToolStripMenuItem
            // 
            this.removeCardToolStripMenuItem.Name = "removeCardToolStripMenuItem";
            this.removeCardToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.removeCardToolStripMenuItem.Text = "Remove Card";
            this.removeCardToolStripMenuItem.Click += new System.EventHandler(this.RemoveCardToolStripMenuItem_Click);
            // 
            // bEndTurn
            // 
            this.bEndTurn.Location = new System.Drawing.Point(52, 245);
            this.bEndTurn.Name = "bEndTurn";
            this.bEndTurn.Size = new System.Drawing.Size(75, 23);
            this.bEndTurn.TabIndex = 0;
            this.bEndTurn.Text = "End Turn";
            this.bEndTurn.UseVisualStyleBackColor = true;
            this.bEndTurn.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gold :";
            // 
            // gBPlayer2
            // 
            this.gBPlayer2.Controls.Add(this.nUDPlayer2HP);
            this.gBPlayer2.Controls.Add(this.nUDPlayer2Gold);
            this.gBPlayer2.Controls.Add(this.label2);
            this.gBPlayer2.Controls.Add(this.label1);
            this.gBPlayer2.Location = new System.Drawing.Point(12, 12);
            this.gBPlayer2.Name = "gBPlayer2";
            this.gBPlayer2.Size = new System.Drawing.Size(180, 100);
            this.gBPlayer2.TabIndex = 2;
            this.gBPlayer2.TabStop = false;
            this.gBPlayer2.Text = "Player 2";
            // 
            // nUDPlayer2HP
            // 
            this.nUDPlayer2HP.Location = new System.Drawing.Point(52, 57);
            this.nUDPlayer2HP.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nUDPlayer2HP.Name = "nUDPlayer2HP";
            this.nUDPlayer2HP.Size = new System.Drawing.Size(63, 20);
            this.nUDPlayer2HP.TabIndex = 4;
            // 
            // nUDPlayer2Gold
            // 
            this.nUDPlayer2Gold.Location = new System.Drawing.Point(52, 31);
            this.nUDPlayer2Gold.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nUDPlayer2Gold.Name = "nUDPlayer2Gold";
            this.nUDPlayer2Gold.Size = new System.Drawing.Size(63, 20);
            this.nUDPlayer2Gold.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HP :";
            // 
            // gBPlayer1
            // 
            this.gBPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gBPlayer1.Controls.Add(this.nUDPlayer1HP);
            this.gBPlayer1.Controls.Add(this.nUDPlayer1Gold);
            this.gBPlayer1.Controls.Add(this.label3);
            this.gBPlayer1.Controls.Add(this.label4);
            this.gBPlayer1.Location = new System.Drawing.Point(12, 814);
            this.gBPlayer1.Name = "gBPlayer1";
            this.gBPlayer1.Size = new System.Drawing.Size(180, 100);
            this.gBPlayer1.TabIndex = 5;
            this.gBPlayer1.TabStop = false;
            this.gBPlayer1.Text = "Player 1";
            // 
            // nUDPlayer1HP
            // 
            this.nUDPlayer1HP.Location = new System.Drawing.Point(52, 57);
            this.nUDPlayer1HP.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nUDPlayer1HP.Name = "nUDPlayer1HP";
            this.nUDPlayer1HP.Size = new System.Drawing.Size(63, 20);
            this.nUDPlayer1HP.TabIndex = 4;
            // 
            // nUDPlayer1Gold
            // 
            this.nUDPlayer1Gold.Location = new System.Drawing.Point(52, 31);
            this.nUDPlayer1Gold.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nUDPlayer1Gold.Name = "nUDPlayer1Gold";
            this.nUDPlayer1Gold.Size = new System.Drawing.Size(63, 20);
            this.nUDPlayer1Gold.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gold :";
            // 
            // BattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 926);
            this.Controls.Add(this.gBPlayer1);
            this.Controls.Add(this.gBPlayer2);
            this.Controls.Add(this.bEndTurn);
            this.Controls.Add(this.fLPField);
            this.Name = "BattleField";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BattleField_Load);
            this.cMSCardAction.ResumeLayout(false);
            this.gBPlayer2.ResumeLayout(false);
            this.gBPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer2HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer2Gold)).EndInit();
            this.gBPlayer1.ResumeLayout(false);
            this.gBPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer1HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPlayer1Gold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLPField;
        private System.Windows.Forms.ContextMenuStrip cMSCardAction;
        private System.Windows.Forms.ToolStripMenuItem addCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCardToolStripMenuItem;
        private System.Windows.Forms.Button bEndTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBPlayer2;
        private System.Windows.Forms.NumericUpDown nUDPlayer2HP;
        private System.Windows.Forms.NumericUpDown nUDPlayer2Gold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBPlayer1;
        private System.Windows.Forms.NumericUpDown nUDPlayer1HP;
        private System.Windows.Forms.NumericUpDown nUDPlayer1Gold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripTextBox tSTBUnitCost;
    }
}

