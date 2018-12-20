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
            // DescriptionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lKeywordName);
            this.Name = "DescriptionLine";
            this.Size = new System.Drawing.Size(269, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lKeywordName;
    }
}
