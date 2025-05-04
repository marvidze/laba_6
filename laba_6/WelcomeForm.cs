using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace laba_6
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 5000; 
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                Close();
            };
            timer.Start();
        }

        private void FormClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
