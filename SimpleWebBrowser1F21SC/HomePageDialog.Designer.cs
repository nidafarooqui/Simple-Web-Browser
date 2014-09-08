namespace SimpleWebBrowser1F21SC
{
    partial class HomePageDialog
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
            this.homePageUrltextBox = new System.Windows.Forms.TextBox();
            this.setAsHomePageBtn = new System.Windows.Forms.Button();
            this.homepgdialogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homePageUrltextBox
            // 
            this.homePageUrltextBox.Location = new System.Drawing.Point(12, 56);
            this.homePageUrltextBox.Name = "homePageUrltextBox";
            this.homePageUrltextBox.Size = new System.Drawing.Size(349, 20);
            this.homePageUrltextBox.TabIndex = 0;
            // 
            // setAsHomePageBtn
            // 
            this.setAsHomePageBtn.Location = new System.Drawing.Point(237, 89);
            this.setAsHomePageBtn.Name = "setAsHomePageBtn";
            this.setAsHomePageBtn.Size = new System.Drawing.Size(124, 24);
            this.setAsHomePageBtn.TabIndex = 1;
            this.setAsHomePageBtn.Text = "Set as Home Page";
            this.setAsHomePageBtn.UseVisualStyleBackColor = true;
            this.setAsHomePageBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // homepgdialogLabel
            // 
            this.homepgdialogLabel.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepgdialogLabel.Location = new System.Drawing.Point(12, 19);
            this.homepgdialogLabel.Name = "homepgdialogLabel";
            this.homepgdialogLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.homepgdialogLabel.Size = new System.Drawing.Size(339, 20);
            this.homepgdialogLabel.TabIndex = 2;
            this.homepgdialogLabel.Text = "Type the Home Page URL below to set as Home Page";
            this.homepgdialogLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.homepgdialogLabel.Click += new System.EventHandler(this.homepgdialogLabel_Click);
            // 
            // HomePageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 133);
            this.Controls.Add(this.homepgdialogLabel);
            this.Controls.Add(this.setAsHomePageBtn);
            this.Controls.Add(this.homePageUrltextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePageDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomePageDialog";
            this.Load += new System.EventHandler(this.HomePageDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homePageUrltextBox;
        private System.Windows.Forms.Button setAsHomePageBtn;
        private System.Windows.Forms.Label homepgdialogLabel;
    }
}