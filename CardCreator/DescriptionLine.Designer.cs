namespace CardCreator
{
    partial class DescriptionLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lKeywordName = new System.Windows.Forms.Label();
            this.tBKeywordAction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lKeywordName
            // 
            this.lKeywordName.AutoSize = true;
            this.lKeywordName.Location = new System.Drawing.Point(3, 10);
            this.lKeywordName.Name = "lKeywordName";
            this.lKeywordName.Size = new System.Drawing.Size(76, 13);
            this.lKeywordName.TabIndex = 0;
            this.lKeywordName.Text = "KeywordName";
            // 
            // tBKeywordAction
            // 
            this.tBKeywordAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBKeywordAction.Location = new System.Drawing.Point(85, 7);
            this.tBKeywordAction.Multiline = true;
            this.tBKeywordAction.Name = "tBKeywordAction";
            this.tBKeywordAction.Size = new System.Drawing.Size(181, 89);
            this.tBKeywordAction.TabIndex = 1;
            // 
            // DescriptionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tBKeywordAction);
            this.Controls.Add(this.lKeywordName);
            this.Name = "DescriptionLine";
            this.Size = new System.Drawing.Size(269, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lKeywordName;
        private System.Windows.Forms.TextBox tBKeywordAction;
    }
}
