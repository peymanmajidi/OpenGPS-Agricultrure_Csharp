using System;
using System.Globalization;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class Form_First : Form
    {
        public Form_First()
        {
            InitializeComponent();
        }

        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.adaptiveagrotech.com/contact.html");
        }

        private void linkLabelCombineForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.adaptiveagrotech.com/");
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Application.ProductVersion.ToString(CultureInfo.InvariantCulture);

            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link { LinkData = "https://github.com/farmerbriantee/AgOpenGPS" };
            linkLabelGit.Links.Add(link);

            // Add a link to the LinkLabel.
            LinkLabel.Link linkCf = new LinkLabel.Link
            {
                LinkData = "https://agopengps.discourse.group/"
            };
            linkLabelCombineForum.Links.Add(linkCf);

            cboxStart.Checked = Properties.Settings.Default.setDisplay_isTermsOn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsOn = cboxStart.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsOn = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}