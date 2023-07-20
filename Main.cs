using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//*************************
using NAudio;
using NAudio.Wave;
//*************************

namespace FFT_SPECTRUM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }




        private void Do_On_Load(object sender, EventArgs e)
        {
            //******************************
            //******************************

            //******************************
            //******************************

        }





        private void button1_Click(object sender, EventArgs e)
        {
            //*********************************
            Graphics graphic = this.DrawBox.CreateGraphics();
            Pen selPen = new Pen(Color.Red);
            Point coord1 = new Point(1, 1);
            Point coord2 = new Point(100, 100);
            graphic.DrawLine(selPen, coord1, coord2);
            //*********************************
            

        }
    }
}
