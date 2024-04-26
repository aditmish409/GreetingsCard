using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GreetingsCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();//declaring everything such as pens, brushes and fonts
            Pen whitePen = new Pen(Color.White, 10);
            Pen orangePen = new Pen(Color.Orange, 10);
            Pen greyPen = new Pen(Color.Gray, 10);
            Pen blackPen = new Pen(Color.Black, 5);
            Pen whitePen2 = new Pen(Color.White, 5);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            g.Clear(Color.Black);//background

            g.DrawLine(whitePen, 0, 375, 1000, 375);//line 1
            g.DrawEllipse(whitePen, 150, -200, 500, 500);//line 2
            g.DrawRectangle(whitePen, 375, 50, 50, 50);//backboard square
            g.DrawRectangle(greyPen, 325, -50, 150, 150);//backboard
            g.DrawRectangle(orangePen, 385, 95, 30, 30);//rim
            g.FillRectangle(orangeBrush, 385, 95, 30, 30);//fill rim
            g.DrawEllipse(orangePen, 375, 125, 50, 50);//rim
            g.DrawEllipse(orangePen, 380, 317, 40, 40);//basketball
            g.FillEllipse(orangeBrush, 380, 317, 40, 40);//fill basketball
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 190)
            {
                i++;

                Graphics g = this.CreateGraphics();
                Pen whitePen = new Pen(Color.White, 10);
                Pen orangePen = new Pen(Color.Orange, 10);
                Pen greyPen = new Pen(Color.Gray, 10);
                Pen blackPen = new Pen(Color.Black, 5);
                Pen whitePen2 = new Pen(Color.White, 5);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush orangeBrush = new SolidBrush(Color.Orange);
                SolidBrush whiteBrush = new SolidBrush(Color.White);

                g.Clear(Color.Black);

                g.DrawLine(whitePen, 0, 375, 1000, 375);
                g.DrawEllipse(whitePen, 150, -200, 500, 500);
                g.DrawRectangle(whitePen, 375, 50, 50, 50);
                g.DrawRectangle(greyPen, 325, -50, 150, 150);
                g.DrawRectangle(orangePen, 385, 95, 30, 30);
                g.FillRectangle(orangeBrush, 385, 95, 30, 30);
                g.DrawEllipse(orangePen, 375, 125, 50, 50);
                g.DrawEllipse(orangePen, 380, 317 - i, 40, 40);
                g.FillEllipse(orangeBrush, 380, 317 - i, 40, 40);
            }

            Graphics g2 = this.CreateGraphics();
            Font drawFont = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush orangeBrush2 = new SolidBrush(Color.Orange);
            SolidBrush whiteBrush2 = new SolidBrush(Color.White);

            g2.DrawString("Happy Bday!", drawFont, whiteBrush2, 300, 400);
            g2.DrawString("Happy Bday!", drawFont, orangeBrush2, 297, 400);

            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.crowdCheering);
            soundPlayer.Play();
        }
    }
}
