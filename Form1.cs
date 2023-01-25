using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lottoprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static private List<int> lottoRadNummer = new List<int>();
        static private int[] dragningList = new int[7];
        string listString = "";
        int correct = 0;

        private void postion1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos1 = int.Parse(postion1.Text);
                lottoRadNummer.Add(pos1);
            }
            catch (Exception)
            {
                MessageBox.Show("pos1");

            }

        }

        private void postion2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos2 = int.Parse(position2.Text);
                lottoRadNummer.Add(pos2);
            }
            catch (Exception)
            {
                MessageBox.Show("pos2");

            }

        }

        private void postion3_TextChanged(object sender, EventArgs e)
        {
            int pos3 = int.Parse(position3.Text);
            lottoRadNummer.Add(pos3);
        }

        private void postion4_TextChanged(object sender, EventArgs e)
        {
            int pos4 = int.Parse(position4.Text);
            lottoRadNummer.Add(pos4);
        }

        private void postion5_TextChanged(object sender, EventArgs e)
        {
            int pos5 = int.Parse(position5.Text);
            lottoRadNummer.Add(pos5);
        }

        private void postion6_TextChanged(object sender, EventArgs e)
        {
            int pos6 = int.Parse(position6.Text);
            lottoRadNummer.Add(pos6);
        }

        private void postion7_TextChanged(object sender, EventArgs e)
        {

            int pos7 = int.Parse(position7.Text);
            lottoRadNummer.Add(pos7);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            foreach (int pos in lottoRadNummer)
            {
                listString += pos ;

            }
            //infoLabel.Text = listString;
            SlumpDragningsNummer();
            
        }

        private void SlumpDragningsNummer()
        {

            int fem = 0; int sex = 0; int sju= 0;

            List<List<int>> allLists = new List<List<int>>();
            Random rand = new Random();
            for (int j = 0; j < 999999; j++)
            {
                //List<int> dragningList = new List<int>();
                for (int i = 0; i < dragningList.Length; i++)
                {
                    int positionNum = rand.Next(1, 36);
                    while (dragningList.Contains(positionNum))
                    {
                        positionNum = rand.Next(1, 36);
                                            }
                    dragningList[i] = positionNum;
                }
                allLists.Add(dragningList.ToList());
                //count.Text = j.ToString();

                    //count.Text= ( $"  fiveRight = {fiveRight.ToString()}, sixRight = {sixRight.ToString()}, sevenRight = {sevenRight.ToString()}");

                }
            foreach (List<int> lotteryNumbers in allLists)
            {
                correct = 0;
                foreach (int num in lotteryNumbers)
                {
                   // listBox1.Items.Add(num);
                    if (lottoRadNummer.Contains(num))
                    {
                        correct++;
                    }   
                }

                if (correct == 7) sju++;
                else if (correct == 6) sex++;
                else if (correct == 5) fem++;
                //listBox1.Items.Add("-----------------");
            }
            resultLabel5.Text = fem.ToString();
            resultLabel6.Text = sex.ToString();
            resultLabel7.Text = sju.ToString();
        }
    }

}
