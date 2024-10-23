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

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            textboxLabel.Text = "A new case just came in, should I take it?";
            questionLabel.Text = "Should I take the case?";
            option1Button.Text = "Yes";
            option2Button.Text = "No";
            option3Button.Visible = false;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if(page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                Random randGen = new Random();
                int randomValue = randGen.Next(1, 101);
                if(randomValue >= 80)
                {
                    page = 7;
                }
                else
                {
                    page = 5;
                }
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 9;
            }
            else if (page == 12)
            {
                page = 9;
            }
            else if (page == 2)
            {
                page = 4;
            }else if (page == 2)
            {
                page = 4;
            }
            displayPage();
        }

        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    textboxLabel.Text = "A new case just came in, should I take it?";
                    questionLabel.Text = "Should I take the case?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 2:
                    textboxLabel.Text = "Just looking at the file, it looks really complicated.";
                    questionLabel.Text = "Should I read the case?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 3:
                    textboxLabel.Text = "But I need the money...";
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    Refresh();
                    Thread.Sleep(1000);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    questionLabel.Text = "Should I take the case?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
            }
        }
    }
}
