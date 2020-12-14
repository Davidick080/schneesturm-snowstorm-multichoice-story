using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
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
         //Reminder this is for inputs for blueLabel
         //TO fix list 
         //Bugs Some certain screens show continue and do not tranition to screen 27 case's ideentifed with bug (5,),
         //Flare gun shot choice screen needs to be fixed and not give game over screen this number for flare gun choice and choices are 7.17 and 15  
         //Reminder find canoot- erase or backspace on keyboard for some reason from the typeing of this typeing .
         //
         //
            if (m.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 6;
                }
                else if (scene == 2)
                {
                    scene = 5;
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
                else if(scene==11)
                {
                    scene = 25;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 27;
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
                    scene = 27;
                }
                else if (scene == 14)
                {
                    scene = 27;
                }
                else if (scene == 15)
                {
                    scene = 21;
                }
                else if (scene == 17)
                {
                    scene = 27;
                }
              
                else if (scene == 19)
                {
                    scene = 27;
                }
                else if (scene == 20)
                {
                    scene = 28;
                }
                else if (scene == 21)
                {
                    scene = 28;
                }
                else if (scene == 23)//there is also no 22,24
                {
                    scene = 27;
                }
                else if (scene == 25)
                {
                    scene = 28;
                }
                else if (scene == 27)
                {
                    scene = 0;
                }
                else if (scene == 42)
                {
                    scene = 27;
                }
                else if(scene==28)
                    {
                    scene = 0;
                }
            }
            //This is for the N keybind. or it is red button everythng on right of chart is for this option
            //For redLabel
            if (m.KeyCode == Keys.N)

            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 7;
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
                //There was no 3,9,10,12 on the chart or plan 
                //note to self move these later in order
                else if (scene == 16)
                {
                    scene = 20;
                }
                else if (scene == 18)
                {
                    scene = 27;

                }
                else if (scene == 11)
                {
                    scene = 23;
                }
                else if (scene == 99)
                {
                    Application.Exit();
                }
                else if (scene == 13)
                {
                    scene = 27;
                }
                else if (scene == 14)
                {
                    scene = 27;
                }
                else if (scene == 15)
                {
                    scene = 19;
                }
             

                else if (scene == 17)
                {
                    scene = 27;
                }
           
                else if (scene == 19)
                {
                    scene = 27;
                }
                else if (scene == 20)
                {
                    scene = 28;
                }
                else if (scene == 21)
                {
                    scene = 28;
                }
                else if (scene == 23)//there is also no 22,24
                {
                    scene = 27;
                }
                else if (scene == 25)
                {
                    scene = 28;
                }
                else if (scene == 27)
                {
                    scene = 99;
                }
                else if (scene == 42)
                {
                    scene = 27;
                }
                else if(scene==28)
                {
                    scene = 99;
                }
            }

            switch (scene)
            {
                //
                case 0:  //start scene  
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = "You Wake up in a snow storm. You contemoplate ether staying in your car or leaveing it ";
                  blueLabel.Text = "m to leave car";
                  redLabel.Text = "n to Stay in car. ";

                    break;
                case 1:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = " you decide to leave your car but you grab...";
                    redLabel.Text = "your coat";
                    blueLabel.Text = "Coat and bag";

                    break;
                case 2:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = "You decide to stay in your car for safty puposes. you look around your car for items to use.";
                    redLabel.Text = "Grab flare gun";
                    blueLabel.Text = "use phone";
                    break;
                case 4:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm;
                    outputLabel.Text = "You bring a coat with you and decide not to bring you bag. You dont know which direction the city is in though so you head";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 5:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    redLabel.Text = "The police";
                    blueLabel.Text = "Your work";
                    break;
                case 6:
                    carStuckSnow.BackgroundImage = Properties.Resources.quicksand;
                    outputLabel.Text = "You decide to bring both your bag & coat. You have a gps so you dont need to figure out which way you need to go. You come acroos an injured person  ";
                    redLabel.Text = "Help";
                    blueLabel.Text = "not help";
                    break;
                case 7:
                    carStuckSnow.BackgroundImage = Properties.Resources.flare_gun_being_used;
                    outputLabel.Text = "you decide to shot a flare off for help. You hear a snomobile going by you decide to...";
                    redLabel.Text = "not waven";
                    blueLabel.Text = "wave";
                    break;
                case 8:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm_trail;
                    outputLabel.Text = "You decide to head north. You come across an injured person";
                    redLabel.Text = "Will you help?";
                    blueLabel.Text = "not person";
                    break;
                case 11:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = " you call the police and are told to stay put. You decide to use while you wait to stay warm..";
                    redLabel.Text = "Coat";
                    blueLabel.Text = "Flare gun";
                    break;
                case 13:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = "You decide to call your work so you can get help but they mever come. you died of hypothermia";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 15:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowmobile_7_car;
                    outputLabel.Text = "You wave at the driver & he asks are you going to the nearby city?";
                    redLabel.Text = "yes";
                    blueLabel.Text = "Nope";
                    break;
                case 14:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm;
                    outputLabel.Text = "You do not help the injured person. You die of frostbite on the way to the city.congrats ";
                    redLabel.Text = "continue";
                    blueLabel.Text = "continue";
                    break;
                case 16:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm;
                    outputLabel.Text = "You see an injured person will you help them?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "nope";
                    break;
                case 17:
                    carStuckSnow.BackgroundImage = Properties.Resources.person_on_snow;
                    outputLabel.Text = "You for some reason never waved at the person on the snowmobile & died of hypothermia.";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 18:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm;
                    outputLabel.Text = "You decide to not wave at the person in the snowmobile & died of hypothermia.";
                    redLabel.Text = "continue";
                    blueLabel.Text = "continue";
                    break;
                case 19:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowmobile_7_car;
                    outputLabel.Text = "You say no to the driver of the snowmonile. He drives off then & you die of hypothermia ";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 20:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowmobile_7_car;
                    outputLabel.Text = " you wave to the person on the snowmobile & explain what happend and ask if he can drive you to the nearby city. Also you win ";
                    redLabel.Text = "continue";
                    blueLabel.Text = "continue";
                    break;
                case 21:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowmobile_7_car;
                    outputLabel.Text = "You say yes to the driver and are taken to the city. You Win";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 23:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = "You decide to use the flare gun for warmth for some reason. You set the car to go boom & you burn to death";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 25:
                    carStuckSnow.BackgroundImage = Properties.Resources.car_inside_snow;
                    outputLabel.Text = "You find a coat to keep yourself warm with & the police with eventually will come to get you out and take you to the city(or hospital in this case";
                    redLabel.Text = "continue?";
                    blueLabel.Text = "continue";
                    break;
                case 42:
                    carStuckSnow.BackgroundImage = Properties.Resources.snowstorm_trail;
                    outputLabel.Text = "You deide to go south.";
                    redLabel.Text = "continue";
                    blueLabel.Text = "continue";
                    break;

                case 27:
                    carStuckSnow.BackgroundImage = Properties.Resources.game_over;
                    outputLabel.Text = "you died of hypothermia congrats";
                    redLabel.Text = "log out?";
                    blueLabel.Text = "back to start";
                    break;

                case 28:
                    carStuckSnow.BackgroundImage = Properties.Resources.cityBlizzard;
                    outputLabel.Text = "you made it to the city";
                    redLabel.Text = "log out";
                    blueLabel.Text = "back to start";
                    break;
            }
        }

        private void CarStuckSnow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }


}







