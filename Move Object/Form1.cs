using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Object
{
    public partial class Form1 : Form
    {

        bool goUp, goDown, goLeft, goRight;
        int speed = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimer(object sender, EventArgs e)
        {
            if (goLeft == true && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= speed;
            }
            if (goRight == true && pictureBox1.Left < 642)
            {
                pictureBox1.Left += speed;
            }
            if (goUp == true && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= speed;
            }
            if (goDown == true && pictureBox1.Top < 510)
            {
                pictureBox1.Top += speed;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }
    }
}
