using System;
using System.Windows.Forms;

namespace Lottoprogram
{
    public partial class Form1 : Form
    {
         int[] lottoRadNummer = {2, 4, 6, 8, 9, 1, 3 };

        public Form1()
        {
            InitializeComponent();
        }

       

        private void postion1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos1 = int.Parse(postion1.Text);
                lottoRadNummer[0] = pos1;
            }
            catch (Exception)
            {
                MessageBox.Show("ggg");
                
            }
            
        }

        private void postion2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos2 = int.Parse(position2.Text);
                lottoRadNummer[1] = pos2;
            }
            catch (Exception)
            {
                MessageBox.Show("333");

            }
           
        }

        private void postion3_TextChanged(object sender, EventArgs e)
        {
            int pos3 = int.Parse(position3.Text);
            lottoRadNummer[2] = pos3;
        }

        private void postion4_TextChanged(object sender, EventArgs e)
        {
            int pos4 = int.Parse(position4.Text);
            lottoRadNummer[3] = pos4;
        }

        private void postion5_TextChanged(object sender, EventArgs e)
        {
            int pos5 = int.Parse(position5.Text);
            lottoRadNummer[4] = pos5;
        }

        private void postion6_TextChanged(object sender, EventArgs e)
        {
            int pos6 = int.Parse(position6.Text);
            lottoRadNummer[5] = pos6;
        }

        private void postion7_TextChanged(object sender, EventArgs e)
        {
            int pos7 = int.Parse(position7.Text);
            lottoRadNummer[6] = pos7;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lottoRadNummer.Length; i++)
            {
                MessageBox.Show(lottoRadNummer[i].ToString());
            }

        }

    }

}
