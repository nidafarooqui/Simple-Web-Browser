using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimpleWebBrowser1F21SC
{
    public partial class AddToFavourites : Form
    {
        private string myURL;
        private string myName;
        private int myIndex;
        
        public AddToFavourites()
        {
            this.myIndex = -1;
            InitializeComponent();
        }

        public int getmyIndex()
        {
            return myIndex;
        }

        public void setmyIndex(int index)
        {

            this.myIndex = index;
        }

        public string getMyURL()
        {
            return myURL;
        }

        public void setMyURL(string url)
        {

            this.myURL = url;
        }

        public string getMyName()
        {
            return myName;
        }

        public void setmyName(string name)
        {

            this.myName = name;
        }
        //
        private void AddToFavourites_Load(object sender, EventArgs e)
        {
            if (this.myIndex > -1)
            {
                //read the entries into a string
                StreamReader rdr = new StreamReader("favourites.txt");
                string allEntries = rdr.ReadToEnd();
                rdr.Close();

                //split the string into each line
                string[] splits = allEntries.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                //split each line into two parts
                string[] splits2 = splits[myIndex].Split(new string[] { "!#!" }, StringSplitOptions.RemoveEmptyEntries);
                
                //the first part is the \Name of the favourites
                this.namefavTextBox.Text = splits2[0];

                //the second part on the right side is the url of the favourites
                this.urlfavTextBox.Text = splits2[1];

            }
            else
            {
                //display the text box with the current url that is set as a favourite
                this.urlfavTextBox.Text = myURL;
            }
        }

        private void on_addtofav_button_Click(object sender, EventArgs e)
        {
            if (this.myIndex > -1)
            {
                //Update entry
                StreamReader rdr = new StreamReader("favourites.txt");
                string[] splits = rdr.ReadToEnd().Split(new string[]{"\r\n"},StringSplitOptions.RemoveEmptyEntries);
                rdr.Close();
                //write the name and url to the favourites file separated by a delimiter
                StreamWriter rtr = new StreamWriter("favourites.txt",false);

                for (int i = 0; i < splits.Length; i++)
                {
                    //find the index of the line to be added
                    if (i == myIndex)
                    {
                        //write the favourite that needs to be added to the text file
                        rtr.WriteLine(this.namefavTextBox.Text.Trim() + "!#!" + this.urlfavTextBox.Text.Trim());
                    }
                    else
                    {
                        //write the favourites to the text file
                        rtr.WriteLine(splits[i]);
                    }
                }

                rtr.Close();

                this.Close();

                return;

            }
            try
            {
                StreamWriter rtr = new StreamWriter("favourites.txt",true);
                string toaddtofavourites = this.namefavTextBox.Text.Trim() + "!#!" + this.urlfavTextBox.Text.Trim();
                rtr.WriteLine(toaddtofavourites);
                rtr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            this.Close();
        }
    }
}
