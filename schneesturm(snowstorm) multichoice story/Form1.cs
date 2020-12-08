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
        {
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
                    scene =8;
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

                else if (scene == 16)
                {
                    scene =20;
                }
                else if (scene == 10 )
                {
                    scene =;
                }
                else if (scene == 11)
                {
                    scene = ;
                }
                else if (scene == 12)
                {
                    scene = ;
                }
                else if (scene == 13)
                {
                    scene = ;
                }
                else if (scene == 14)
                {
                    scene = ;
                }
                else if (scene == 15)
                {

                }
            }
        }
    }
}
