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

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer paperplayer = new SoundPlayer(Properties.Resources.paper);
        SoundPlayer gavelplayer = new SoundPlayer(Properties.Resources.gavel);

        public Form1()
        {
            InitializeComponent();
            displayPage();
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
                    page = 15;
                }
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 15)
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
            else if (page == 8)
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
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            displayPage();
        }

        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    textboxLabel.Text = "A new case just came in, should I take it?";
                    questionLabel.Text = "Should I take the case?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    Imagebox.Image = Properties.Resources.office;
                    break;
                case 2:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    textboxLabel.Text = "Just looking at the file, it looks really complicated.";
                    questionLabel.Text = "Should I read the case?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    paperplayer.Play();
                    break;
                case 4:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    textboxLabel.Text = "So my client was accused of murder...";
                    questionLabel.Text = "Should I bribe the judge?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    Imagebox.Image = Properties.Resources.think;
                    break;
                case 5:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    textboxLabel.Text = "I have no idea what's going on...\nConfused Ending";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    Imagebox.Image = Properties.Resources.sweat;
                    break;
                case 6:
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    option3Button.Visible = true;
                    option3Button.Enabled = true;
                    textboxLabel.Text = "No, that's obviously a bad idea.";
                    questionLabel.Text = "";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    Imagebox.Image = Properties.Resources.think;
                    Refresh();
                    Thread.Sleep(3500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "What should I present to prove my client innocent?";
                    questionLabel.Text = "What to present...";
                    gavelplayer.Play();
                    option1Button.BackgroundImage = Properties.Resources.badge;
                    option2Button.BackgroundImage = Properties.Resources.peel;
                    option3Button.BackgroundImage = Properties.Resources.Lorex_Camera;
                    break;
                case 7:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "I wonder if I have enough money... Let's go gambling!";
                    Imagebox.Image = Properties.Resources.gambling;
                    Refresh();
                    Thread.Sleep(3000);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text += "\nWHOA! I just won the lottery! Guess I'll giva half of it to the judge. \nRich Ending.";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    Imagebox.Image = Properties.Resources.rich;
                    break;
                case 8:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "I assume that means you have no more evidence, meaning the client is deemed...";
                    Imagebox.Image = Properties.Resources.judge;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.guilty;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "Guilty.";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 9:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "And how does that prove anything, defence?";
                    Imagebox.Image = Properties.Resources.judge;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.smug;
                    textboxLabel.Text = "It proves I'm an attourney!";
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.despair;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "As the defence is clearly incompetent, the case shall be suspended so that the accused can find a new attourney. \nFired Ending.";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 10:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "This footage shows the client near the scene of the crime, eating a banana. this clearly indicates that they were too preoccupied to commit murder.";
                    Imagebox.Image = Properties.Resources.page;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.judge;
                    textboxLabel.Text = "Are you aware the murder weapon was a banana peel?";
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.phoenix_wright_shocked;
                    textboxLabel.Text = "!?";
                    Refresh();
                    Thread.Sleep(3000);
                    Imagebox.Image = Properties.Resources.guilty;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "due to the client being in posession of a deadly weapon at the time of the murder, they are deemed... guilty.\nGuilty Ending.";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 11:
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "My client couldn't have murdered the victim because they were eating this banana peel!";
                    Imagebox.Image = Properties.Resources.smug;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.judge;
                    textboxLabel.Text = "How would you know that, Wright?";
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.page;
                    textboxLabel.Text = "My client told me!";
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.judge;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "Unfortunately, that isn't enough evidence. Do you have anything else to present?";
                    questionLabel.Text = "";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    break;
                case 12:
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "As you can see in this footage, the client was busy eating a banana just before the murder!";
                    Imagebox.Image = Properties.Resources.smug;
                    Refresh();
                    Thread.Sleep(3500);
                    textboxLabel.Text = "Are you aware the muder weapon was a banana peel?";
                    Imagebox.Image = Properties.Resources.phoenix_wright_shocked;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.think;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "Well, my client was definetely eating a different banana at the time, and I can prove it!";
                    questionLabel.Text = "What do I present to prove it?";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";
                    break;
                case 13:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "As you can see here, the banana that my client ate was clearly a different color than the murder peel! meaning that them eating a banana was completely unrelated!";
                    Imagebox.Image = Properties.Resources.smug;
                    Refresh();
                    Thread.Sleep(3500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    Imagebox.Image = Properties.Resources.not_guilty;
                    textboxLabel.Text = "And so, after a hard fought case, I finally won! \nGot paid Ending";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 14:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "As you can see here, the banana that my client ate was clearly the same color as the murder peel! meaning that them eating a banana was Entirely related!";
                    Imagebox.Image = Properties.Resources.smug;
                    Refresh();
                    Thread.Sleep(3500);
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    Imagebox.Image = Properties.Resources.judge;
                    textboxLabel.Text = "Are you sure that's the argument you want to make?";
                    questionLabel.Text = "Is that really what I want to say?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 15:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    Imagebox.Image = Properties.Resources.hobo;
                    textboxLabel.Text = "You succeed, but you're in such heavy debt that you all your assets get seized. In Debt Ending";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 16:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    textboxLabel.Text = "Well, thanks to the passionate argument of the defence, the defendant is deemed...";
                    Imagebox.Image = Properties.Resources.judge;
                    Refresh();
                    Thread.Sleep(3500);
                    Imagebox.Image = Properties.Resources.guilty;
                    option1Button.Enabled = true;
                    option2Button.Enabled = true;
                    textboxLabel.Text = "Guilty.\nYou won? Ending";
                    questionLabel.Text = "Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 17:
                    option3Button.Visible = false;
                    option3Button.Enabled = false;
                    questionLabel.Text = "Accuse my client?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    Imagebox.Image = Properties.Resources.think;
                    break;
                case 99:
                    textboxLabel.Text = "Thanks for paying.";
                    questionLabel.Text = "";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    Refresh();
                    Thread.Sleep(3500);
                    Close();
                    break;
                default:
                    textboxLabel.Text = "bro where are you";
                    Refresh();
                    Thread.Sleep(3500);
                    page = 1;
                    displayPage();
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if(page == 1)
            {
                textboxLabel.Text = "But I need the money...";
                Refresh();
                Thread.Sleep(3500);
                page = 1;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 11;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 8;
            }
            else if (page == 12)
            {
                page = 17;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                textboxLabel.Text = "Uhhh, nevermind.";
                Refresh();
                Thread.Sleep(3000);
                page = 13;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 13;
            }

            displayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if(page == 6)
            {
                page = 10;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 8;
            }
            displayPage();
        }
    }
}
