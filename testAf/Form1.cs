using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace testAf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Install_Click(object sender, EventArgs e)
        {




            Thread.Sleep(1100);

            label2.Text = "WinForm32.dll";
            Thread.Sleep(873);
            progressBar1.Increment(12);

            label2.Text = "VS.exe";
            Thread.Sleep(873);
            progressBar1.Increment(30);

            label2.Text = "VS64x.exe";
            Thread.Sleep(873);
            progressBar1.Increment(9);

            label2.Text = "winvs.dll";
            Thread.Sleep(873);
            progressBar1.Increment(10); 

            label2.Text = "w64.dll";
            Thread.Sleep(873);
            progressBar1.Increment(14);

            label2.Text = "WinDev.dll";
            Thread.Sleep(873);
            progressBar1.Increment(10);

            label2.Text = "WinForm64.dll";
            Thread.Sleep(873);
            progressBar1.Increment(10);

            label2.Text = "MS32.dll";
            Thread.Sleep(873);
            progressBar1.Increment(10);

            label2.Text = "svchost.exe";
            Thread.Sleep(873);
            progressBar1.Increment(4);


            MessageBox.Show("Update install complete. You may need to restart your system for changes to take effect.");
            Close();


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            info settingsForm = new info();

            // Show the settings form
            settingsForm.Show();
            Thread.Sleep(1000);
            Hide();
        }
    }
}
