using MetroFramework.Controls;
using MusicPlayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class UCMusicPlayer : UserControl
    {
        public UCMusicPlayer()
        {
            InitializeComponent();
        }

        private bool isPlay = false;
        private void button2_Click(object sender, EventArgs e)
        {
            isPlay = !isPlay;

            if (isPlay)
            {
                button2.BackgroundImage = Resources.stop;
            }
            else
            {
                button2.BackgroundImage = Resources.play;
            }
        }

        public void SetMusic(string title)
        {
            metroLabelTitle.Text = title;
        }
    }
}
