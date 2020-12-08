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
            if (m.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene =4;
                }
                else if (scene == 2)
                {
                    scene =5;
                }
                else if (scene == 3)
                {
                    scene =99;
                }
                else if (scene == 4)
                {
                    scene =41;
                }
                else if (scene == 5)
                {
                    scene =11 ;
                }
                else if (scene == 6)
                {
                    scene =14;
                }
                else if (scene == 7)
                {
                    scene = 17;
                }
                if (scene ==8)
                {
                    scene =14;
                }
                //There was no 9,10,12 on the chart or plan 
                //note to self move these later in order
                else if (scene == 16)
                {
                    scene =20;
                }
                else if (scene == 18)
                {
                    scene =99;
                }
                else if (scene == 11)
                {
                    scene = 23;
                }
                else if (scene ==99)
                {
                    scene = ;
                }
                else if (scene == 13)
                {
                    scene = 99;
                }
                else if (scene == 14)
                {
                    scene =99;
                }
                else if (scene == 15)
                {
                    scene=19
                }
                if (scene == 16)
                {
                    scene = ;
                }

                else if (scene ==17 )
                {
                    scene = ;
                }
                else if (scene ==18 )
                {
                    scene = ;
                }
                else if (scene ==19 )
                {
                    scene = ;
                }
                else if (scene ==20 )
                {
                    scene = ;
                }
                else if (scene ==21 )
                {
                    scene = ;
                }
                else if (scene ==22 )
                {
                    scene = ;
                }
                else if (scene == )
                {

                }
            }
        }
    }
}
