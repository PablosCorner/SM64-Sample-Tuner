using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64SampleTuner
{
    public partial class CalculateKey : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font mario64Font;

        public CalculateKey()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Mario64Internal;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Mario64Internal.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Mario64Internal.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            mario64Font = new Font(fonts.Families[0], 18.0F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLinks();
            setFont();
        }

        private protected void setFont()
        {
            lblBitRate.Font = mario64Font;
            lblTargetKey.Font = mario64Font;
            txtTargetBitrate.Font = mario64Font;
            txtTargetRootKey.Font = mario64Font;
            btnMain.Font = mario64Font;
            Result.Font = mario64Font;
        }

        private protected void SetLinks()
        {
            string[] keywords;


            // Set the LinkBehavior property to show underline when mouse
            // hovers over the links.
            linkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;

            // Set the color of the links to black, unless the mouse
            // is hovering over a link.
            linkGithub.LinkColor = System.Drawing.Color.Red;
            linkGithub.ActiveLinkColor = System.Drawing.Color.DarkRed;

            // Add links to the LinkCollection using starting index and
            // length of keywords.
            keywords = new string[] { "PablosCorner", "ThisMight" };
            foreach (string keyword in keywords)
            {
                this.linkGithub.Links.Add(linkGithub.Text.IndexOf(keyword), keyword.Length);
            }

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            try
            {
                // The base sample rate and target sample rate
                const double baseSampleRate = 32000;
                double targetSampleRate = double.Parse(txtTargetBitrate.Text);

                // The base key and target key
                const double keyC4 = 60;
                double targetKey = double.Parse(txtTargetRootKey.Text);

                double Finalizer = 0;
                Finalizer = (targetSampleRate / baseSampleRate) * (Math.Pow(2, ((keyC4 - targetKey) / 12)));

                Result.Text = Finalizer.ToString("0.000000");
            }
            catch (Exception exp)
            {
                MessageBox.Show("An error has occured:\n" + exp.Message);
            }
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "";

            // Determine which link was clicked and set the appropriate url.
            switch (linkGithub.Links.IndexOf(e.Link))
            {
                // PablosCorner GitHub Link
                case 0:
                    url = "https://github.com/pabloscorner";

                    break;
                // ThisMight GitHub Link
                case 1:
                    url = "https://github.com/thismight";
                    break;
            }

            // Set the visited property to True. This will change
            // the color of the link.
            e.Link.Visited = true;

            // Open Browser to the correct url.
            System.Diagnostics.Process.Start(url);
        }

        private void txtTargetBitrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTargetRootKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTargetKey_Click(object sender, EventArgs e)
        {

        }

        private void ghRepoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo gitHubRepoLink = new ProcessStartInfo("https://github.com/PablosCorner/SM64-Sample-Tuner");
            Process.Start(gitHubRepoLink);
        }
    }
}
