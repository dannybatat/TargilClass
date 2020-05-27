using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargilClass
{
    public partial class Targil : Form
    {
        // prefernece
        const int MAX_OF_THE_HIGH_NUMBMER = 10;




        // global
        Label[] NumbersOnLabels = new Label[5];
        Random random_generator = new Random();
       TextBox[] TextBoxes = new TextBox[5];

        int sum_of_correct_gusses = 0;
        string menake = string.Empty;
        public Targil()
        {
            InitializeComponent();
        }

        private void Targil_Load(object sender, EventArgs e)
        {
            
            SetLabelsIntoArray();
            SetupRandomNum();
            SetListBoxIntoArray();
        }

        private void SetListBoxIntoArray()
        {
            TextBoxes[0] = textBox1;
            TextBoxes[1] = textBox2;
            TextBoxes[2] = textBox3;
            TextBoxes[3] = textBox4;
            TextBoxes[4] = textBox5;
        }

        private void SetLabelsIntoArray()
        {
            NumbersOnLabels[0] = LbNo1;
            NumbersOnLabels[1] = LbNo2;
            NumbersOnLabels[2] = LbNo3;
            NumbersOnLabels[3] = LbNo4;
            NumbersOnLabels[4] = LbNo5;
        }

        private void StartBt_Click(object sender, EventArgs e)
        {
            
            StartGame();


        }



        private void StartGame()
        {
            for (int i = 0; i < NumbersOnLabels.Length; i++)
            {
                NumbersOnLabels[i].Visible = false;
                TextBoxes[i].Visible = true;
               
            }
        }

        private void SetupRandomNum()
        {
          

           for (int i = 0; i < NumbersOnLabels.Length; i++)
           {
              NumbersOnLabels[i].Text = Convert.ToString(random_generator.Next(1, MAX_OF_THE_HIGH_NUMBMER));
             
            
            }         
        }

        private void FinishBt_Click(object sender, EventArgs e)
        {
            GameLoop();

        }

        private void GameLoop()
        {
            if (NumbersOnLabels[0].Text == textBox1.Text)
            {
                sum_of_correct_gusses++;

            }
            else
            {
                NumbersOnLabels[0].ForeColor = Color.Red;
                NumbersOnLabels[0].Visible = true;
            }
            if (NumbersOnLabels[1].Text == textBox2.Text)
            {
                sum_of_correct_gusses++;
            }
            else
            {
                NumbersOnLabels[1].ForeColor = Color.Red;
                NumbersOnLabels[1].Visible = true;
            }
            if (NumbersOnLabels[2].Text == textBox3.Text)
            {
                sum_of_correct_gusses++;
            }
            else
            {
                NumbersOnLabels[2].ForeColor = Color.Red;
                NumbersOnLabels[2].Visible = true;
            }
            if (NumbersOnLabels[3].Text == textBox4.Text)
            {
                sum_of_correct_gusses++;
            }
            else
            {
                NumbersOnLabels[3].ForeColor = Color.Red;
                NumbersOnLabels[3].Visible = true;
            }
            if (NumbersOnLabels[4].Text == textBox5.Text)
            {
                sum_of_correct_gusses++;
            }
            else
            {
                NumbersOnLabels[4].ForeColor = Color.Red;
                NumbersOnLabels[4].Visible = true;
            }
            MessageBox.Show($"u have {sum_of_correct_gusses} correct gusses");
            ScoreBox.Items.Add(sum_of_correct_gusses);
            SetupRandomNum();
            for (int i = 0; i < NumbersOnLabels.Length; i++)
            {
                NumbersOnLabels[i].ForeColor = Color.Black;
                NumbersOnLabels[i].Visible = true;
                TextBoxes[i].Visible = false;
                TextBoxes[i].Text = menake;


            }
            sum_of_correct_gusses = 0;

        }

        private void RestBt_Click(object sender, EventArgs e)
        {
            ScoreBox.Items.Clear();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rulseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On the board shown 5 digits when you click the Start Button the digits disappear you need to guess which numbers were in the correct order, each digit you guessed correctly will give you one point", "Game Rules");
        }


    }
}
