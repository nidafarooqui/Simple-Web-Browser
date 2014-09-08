namespace SimpleWebBrowser1F21SC
{
    partial class AddToFavourites
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
            this.namefavTextBox = new System.Windows.Forms.TextBox();
            this.favNamelabel = new System.Windows.Forms.Label();
            this.favURLlabel = new System.Windows.Forms.Label();
            this.urlfavTextBox = new System.Windows.Forms.TextBox();
            this.addtofavbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namefavTextBox
            // 
            this.namefavTextBox.Location = new System.Drawing.Point(12, 38);
            this.namefavTextBox.Name = "namefavTextBox";
            this.namefavTextBox.Size = new System.Drawing.Size(362, 20);
            this.namefavTextBox.TabIndex = 0;
            // 
            // favNamelabel
            // 
            this.favNamelabel.AutoSize = true;
            this.favNamelabel.Location = new System.Drawing.Point(13, 19);
            this.favNamelabel.Name = "favNamelabel";
            this.favNamelabel.Size = new System.Drawing.Size(38, 13);
            this.favNamelabel.TabIndex = 1;
            this.favNamelabel.Text = "Name:";
            // 
            // favURLlabel
            // 
            this.favURLlabel.AutoSize = true;
            this.favURLlabel.Location = new System.Drawing.Point(13, 79);
            this.favURLlabel.Name = "favURLlabel";
            this.favURLlabel.Size = new System.Drawing.Size(32, 13);
            this.favURLlabel.TabIndex = 3;
            this.favURLlabel.Text = "URL:";
            // 
            // urlfavTextBox
            // 
            this.urlfavTextBox.Location = new System.Drawing.Point(12, 98);
            this.urlfavTextBox.Name = "urlfavTextBox";
            this.urlfavTextBox.ReadOnly = true;
            this.urlfavTextBox.Size = new System.Drawing.Size(362, 20);
            this.urlfavTextBox.TabIndex = 2;
            // 
            // addtofavbtn
            // 
            this.addtofavbtn.Location = new System.Drawing.Point(264, 144);
            this.addtofavbtn.Name = "addtofavbtn";
            this.addtofavbtn.Size = new System.Drawing.Size(110, 23);
            this.addtofavbtn.TabIndex = 4;
            this.addtofavbtn.Text = "Add to Favourites";
            this.addtofavbtn.UseVisualStyleBackColor = true;
            this.addtofavbtn.Click += new System.EventHandler(this.on_addtofav_button_Click);
            // 
            // AddToFavourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 181);
            this.Controls.Add(this.addtofavbtn);
            this.Controls.Add(this.favURLlabel);
            this.Controls.Add(this.urlfavTextBox);
            this.Controls.Add(this.favNamelabel);
            this.Controls.Add(this.namefavTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToFavourites";
            this.ShowInTaskbar = false;
            this.Text = "Add To Favourites";
            this.Load += new System.EventHandler(this.AddToFavourites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namefavTextBox;
        private System.Windows.Forms.Label favNamelabel;
        private System.Windows.Forms.Label favURLlabel;
        private System.Windows.Forms.TextBox urlfavTextBox;
        private System.Windows.Forms.Button addtofavbtn;
    }
}