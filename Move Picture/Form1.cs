using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X - 25 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
            }
          

        }
        private void left_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
            }
           
        } 
        private void down_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 25 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 25);
            }

        }

        private void up_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 25);
            }

        }

        private async void fullleft_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X - 1 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
                   await Task.Delay(10);
            }
        }
    }
}
