using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shavrina
{
    public partial class Pole : UserControl
    {
        public Pole()
        {
            InitializeComponent();
        }

        private void Pole_Load(object sender, EventArgs e)
        {

        }

        private void DrawPole(object sender, PaintEventArgs e)
        {
            float intervaly = Size.Width / 20;
            float intervalx = Size.Height / 20;
            float x = 0;
            float y = 0;
            for (int i = 0; i < 30; i++)
            {

                e.Graphics.DrawLine(Pens.White, 0, y, Size.Width, y);
                y += intervaly;
            }
            e.Graphics.DrawLine(Pens.White, 0, y + intervaly, Size.Width, y + intervaly);
            for (int i = 0; i < 30; i++)
            {

                e.Graphics.DrawLine(Pens.White, x, 0, x, Size.Height);
                x += intervalx;
            }
            e.Graphics.DrawLine(Pens.White, x + intervalx, 0, x + intervalx, Size.Height);
        }

        private void DrawIm(object sender, PaintEventArgs e)
        {
            float intervaly = Size.Width / 20;
            float intervalx = Size.Height / 20;
            float x = 0;
            float y = 0;
            for (int i = 0; i < 30; i++)
            {

                e.Graphics.DrawLine(Pens.White, 0, y, Size.Width, y);
                y += intervaly;
            }
            e.Graphics.DrawLine(Pens.White, 0, y + intervaly, Size.Width, y + intervaly);
            for (int i = 0; i < 30; i++)
            {

                e.Graphics.DrawLine(Pens.White, x, 0, x, Size.Height);
                x += intervalx;
            }
            e.Graphics.DrawLine(Pens.White, x + intervalx, 0, x + intervalx, Size.Height);
        }
    }
}
