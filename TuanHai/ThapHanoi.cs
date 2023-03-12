using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuanHai
{
    public partial class ThapHanoi : Form
    {
        PictureBox[] disks;
        int moveCount;
        Stack<PictureBox> disksA, disksB, disksC;
        public ThapHanoi()
        {
            InitializeComponent();
            disks = new PictureBox[] {pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 };
            disksA = new Stack<PictureBox>();
            disksB = new Stack<PictureBox>();
            disksC = new Stack<PictureBox>();
        }

        private void ThapHanoi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picTreeA_Click(object sender, EventArgs e)
        {

        }

        private void lblStep_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(PictureBox disk in disks)
            {
                disk.Visible = false;

                moveCount = 0;
                lblStep.Text = "So buoc: 0";
                disksA.Clear(); disksB.Clear(); disksC.Clear();
                picTreeA.BorderStyle = picTreeB.BorderStyle = picTreeC.BorderStyle = BorderStyle.None;

                nudLevel.Enabled = false;
                btnRun.Text = "Try again";
                for(int i = (int)nudLevel.Value - 1; i >= 0; --i)
                {
                    disks[i].Location = new Point();
                    disks[i].Visible = true;
                }
        }
    }
}
