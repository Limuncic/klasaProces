using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace klasaProces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("Word.exe");
        }

        private void buttonInternet_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void buttonStartINFO_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo("Chrome.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            // početna web adresa

            startInfo.Arguments = "www.sser.hr";

            // pokretanje Internet Explorer-a

            Process.Start(startInfo);
        }
    }
}
