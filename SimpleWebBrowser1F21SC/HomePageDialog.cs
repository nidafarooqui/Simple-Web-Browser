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
    public partial class HomePageDialog : Form
    {
        string homepageURLFileName = "homepage.txt";
        public HomePageDialog()
        {
            InitializeComponent();
        }

        private void HomePageDialog_Load(object sender, EventArgs e)
        {
            try
            {
                //read the url from the home page text file and display it in the text box
                StreamReader rdr = new StreamReader(homepageURLFileName);
                this.homePageUrltextBox.Text = rdr.ReadLine();
                rdr.Close();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
            }
        }

        //when the 'set as home page' button is clicked 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //save the url into a string and trim any spaces
                string hpurl = this.homePageUrltextBox.Text.Trim();
                //if there is something written in the text box the write that url to the home page text file
                if (hpurl.Length > 0)
                {
                    StreamWriter rtr = new StreamWriter(homepageURLFileName,false);
                    rtr.Write(hpurl);
                    rtr.Close();
                }
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message);
            }

            this.Close();
        }

        private void homepgdialogLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
