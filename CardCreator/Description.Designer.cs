namespace CardCreator
{
    partial class Description
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
            this.fLPDescriptionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fLPDescriptionContainer
            // 
            this.fLPDescriptionContainer.AutoScroll = true;
            this.fLPDescriptionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPDescriptionContainer.Location = new System.Drawing.Point(0, 0);
            this.fLPDescriptionContainer.Name = "fLPDescriptionContainer";
            this.fLPDescriptionContainer.Size = new System.Drawing.Size(206, 112);
            this.fLPDescriptionContainer.TabIndex = 0;
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fLPDescriptionContainer);
            this.Name = "Description";
            this.Size = new System.Drawing.Size(206, 112);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLPDescriptionContainer;
    }
}
