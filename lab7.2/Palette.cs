using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7._2
{
    public partial class Palette : Form
    {
        public Palette()
        {
            InitializeComponent();
            NewColor();
        }
        private void NewColor()
        {
            ColorPanel.BackColor = Color.FromArgb(tb_red.Value, tb_green.Value, tb_blue.Value);
            Clipboard.Clear();
            Clipboard.SetText("#" + hex(tb_red.Value) +
                                    hex(tb_green.Value) +
                                    hex(tb_blue.Value));
            toolTip.SetToolTip(ColorPanel, Clipboard.GetText());
        }

        private string hex(int value)
        {
            string hex = Convert.ToString(value,16);
            if (hex.Length < 2)
            {
                hex = 0 + hex;
            }

            if (hex[0] >= 97 && hex[0] <= 122){
                hex = Convert.ToString(hex[0]).ToUpper() + hex[1];
            }

            if (hex[1] >= 97 && hex[1] <= 122)
            {
                hex = hex[0]+ Convert.ToString(hex[1]).ToUpper();
            }
            return hex;
        }

        private void color_scroll(object sender, EventArgs e)
        {
            NewColor();
        }

        private void ColorPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
