using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SplashForm : Form
    {
        private DateTime m_startTime = DateTime.UtcNow;
        public SplashForm()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((DateTime.UtcNow - m_startTime).TotalMilliseconds > 3000)
            {
                this.Close();
            }
        }
    }
}
