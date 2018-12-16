namespace TestField
{
    partial class ControlCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCard));
            this.lHP = new System.Windows.Forms.Label();
            this.lSTR = new System.Windows.Forms.Label();
            this.lCost = new System.Windows.Forms.Label();
            this.lAP = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lHP
            // 
            this.lHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lHP.AutoSize = true;
            this.lHP.Location = new System.Drawing.Point(207, 10);
            this.lHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHP.Name = "lHP";
            this.lHP.Size = new System.Drawing.Size(22, 16);
            this.lHP.TabIndex = 0;
            this.lHP.Text = "00";
            // 
            // lSTR
            // 
            this.lSTR.AutoSize = true;
            this.lSTR.Location = new System.Drawing.Point(16, 10);
            this.lSTR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSTR.Name = "lSTR";
            this.lSTR.Size = new System.Drawing.Size(22, 16);
            this.lSTR.TabIndex = 1;
            this.lSTR.Text = "00";
            // 
            // lCost
            // 
            this.lCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(101, 409);
            this.lCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(36, 16);
            this.lCost.TabIndex = 2;
            this.lCost.Text = "0000";
            // 
            // lAP
            // 
            this.lAP.AutoSize = true;
            this.lAP.Location = new System.Drawing.Point(16, 53);
            this.lAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAP.Name = "lAP";
            this.lAP.Size = new System.Drawing.Size(22, 16);
            this.lAP.TabIndex = 3;
            this.lAP.Text = "00";
            // 
            // lDescription
            // 
            this.lDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDescription.Location = new System.Drawing.Point(16, 185);
            this.lDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(217, 219);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = resources.GetString("lDescription.Text");
            // 
            // ControlCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lAP);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.lSTR);
            this.Controls.Add(this.lHP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlCard";
            this.Size = new System.Drawing.Size(248, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHP;
        private System.Windows.Forms.Label lSTR;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Label lAP;
        private System.Windows.Forms.Label lDescription;
    }
}
