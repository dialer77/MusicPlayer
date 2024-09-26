using MetroFramework.Forms;
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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonRecentList_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) 
            {
                return;
            }

            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add($"{button.Text}_{i+1}");
            }
            listBox1.EndUpdate();
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string title =  listBox1.SelectedItem.ToString();
            ucMusicPlayer1.SetMusic(title);

            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
            tableLayoutPanel1.ColumnStyles[2].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[0].Width = 200;
            tableLayoutPanel1.ColumnStyles[1].Width = 100;
        }
    }
}
