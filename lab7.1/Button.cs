using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7._1
{
    public partial class Running_Button : Form
    {
        public Running_Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы смогли догнать кнопку");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= button.Left - 10 && e.X <= button.Right + 10)
            {
                if (e.X >= (button.Left + (button.Width / 2)))
                    button.Left -= 1;
                else
                    button.Left += 1;
            }

            if (e.Y >= button.Top - 10 && e.Y <= button.Bottom + 10)
            {
                if (e.Y >= (button.Top + (button.Height / 2)))
                    button.Top -= 1;
                else
                    button.Top += 1;
            }
            if (button.Left < 0)
                button.Left = 0;
            if ((button.Right) > this.ClientSize.Width)
                button.Left = this.ClientSize.Width - button.Width;
            if (button.Top < 0)
                button.Top = 0;
            if ((button.Bottom) > this.ClientSize.Height)
                button.Top = this.ClientSize.Height - button.Height;
        }
    }
}
