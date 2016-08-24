using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NAIADIDE
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitFaceBookLink();
        }
        private void VisitFaceBookLink()
        { 
            try 
            {
                linkLabel2.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.facebook.com/NaiadAUV");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        { 
            try 
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("http://naiad.se/");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VisitLink();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
