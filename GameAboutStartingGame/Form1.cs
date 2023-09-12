using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace GameAboutStartingGame
{
    public partial class gameScreen1 : Form
    {
        public gameScreen1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer blip = new SoundPlayer(Properties.Resources.blip);
            SoundPlayer begin = new SoundPlayer(Properties.Resources.begin);

            startButton.Text = "3";
            blip.Play();
            Refresh();
            Thread.Sleep(1000);

            startButton.Text = "2";
            blip.Play();
            Refresh();
            Thread.Sleep(1000);

            startButton.Text = "1";
            blip.Play();
            Refresh();
            Thread.Sleep(1000);

            startButton.Text = "";
            startButton.BackColor = Color.Blue;
            whiteEdgeLabel.BackColor = Color.Blue; 
            this.BackColor = Color.Blue;
            invisibleGoLabel.Text = "GO!";
            begin.Play();

        }

    }
}
