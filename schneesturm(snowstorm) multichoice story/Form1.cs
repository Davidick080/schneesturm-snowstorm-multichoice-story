using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schneesturm_snowstorm__multichoice_story
{
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs m)
        {//this is for if the player presses the m key
            // this key bind is blue in other words always left
            //If a same sanario has one option make both keybinds the same option 
            //
            if (m.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 99;
                }
                else if (scene == 4)
                {
                    scene = 42;
                }
                else if (scene == 5)
                {
                    scene = 11;
                }
                else if (scene == 6)
                {
                    scene = 14;
                }
                else if (scene == 7)
                {
                    scene = 17;
                }
                if (scene == 8)
                {
                    scene = 14;
                }
                //There was no 9,10,12 on the chart or plan 
                //note to self move these later in order
                else if (scene == 16)
                {
                    scene = 20;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 11)
                {
                    scene = 23;
                }
                else if (scene == 99)
                {
                    scene = 0;
                }
                else if (scene == 13)
                {
                    scene = 99;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 19;
                }
                if (scene == 16)
                {
                    scene = 20;
                }

                else if (scene == 17)
                {
                    scene = 99;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if (scene == 21)
                {
                    scene = 99;
                }
                else if (scene == 23)//there is also no 22,24
                {
                    scene = 99;
                }
                else if (scene == 25)
                {
                    scene = 99;
                }
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs E)
        {//this is for if the player presses the e key
            // this key bind is red in other words always right
            //If a same sanario has one option make both keybinds the same option 
            //
            if (E.KeyCode == Keys.E)
            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 1)
                {
                    scene = 6;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 99;
                }
                else if (scene == 4)
                {
                    scene = 8;
                }
                else if (scene == 5)
                {
                    scene = 13;
                }
                else if (scene == 6)
                {
                    scene = 16;
                }
                else if (scene == 7)
                {
                    scene = 15;
                }
                if (scene == 8)
                {
                    scene = 16;
                }
                //There was no 9,10,12 on the chart or plan 
                //note to self move these later in order
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 11)
                {
                    scene = 25;
                }
                else if (scene == 99)
                {
                    Application.Exit();
                }
                else if (scene == 13)
                {
                    scene = 99;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 21;
                }
                if (scene == 16)
                {
                    scene = 18;
                }

                else if (scene == 17)
                {
                    scene = 99;
                }
                else if (scene == 18)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 99;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if (scene == 21)
                {
                    scene = 99;
                }
                else if (scene == 23)//there is also no 22,24
                {
                    scene = 99;
                }
                else if (scene == 25)
                {
                    scene = 99;
                }
            }


            switch (scene)
            {

                case 0:  //start scene  
                    outputLabel.Text = "You Wake up in a snow storm you ";
                    redLabel.Text = "north";
                    blueLabel.Text = "south";
                    break;
                case 1:
                    outputLabel.Text = " you head north";
                    redLabel.Text = "yes";
                    blueLabel.Text = "no";
                    break;
                case 2:
                    outputLabel.Text = "You fall into a pitfall";
                    redLabel.Text = "Restart";
                    break;
                case 3:
                    outputLabel.Text = "You come to a lake";
                    redLabel.Text = "drink";
                    blueLabel.Text = "no";
                    break;
                case 4:
                    outputLabel.Text = "died of thirst";
                    redLabel.Text = "reststart";
                    break;
                case 5:
                    outputLabel.Text = "see horse";
                    redLabel.Text = "Eat ";
                    blueLabel.Text = "Nahh";
                    break;
                case 6:
                    outputLabel.Text = "died of no meat";
                    redLabel.Text = "Restart";
                    break;
                case 7:
                    outputLabel.Text = "you win";
                    break;
                default:
                    break;
            }
        }


    }
}








