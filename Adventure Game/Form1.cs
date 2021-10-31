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
namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You wake up 10 minutes before class starts, " +
                "you quickly get ready and get out the door. Do you choose to run or ride the bike?";
            option1Label.Text = "Run.";
            option2Label.Text = "Use the bike";
            option3Label.Text = "";

        }

        private void option1Button_Click(object sender, EventArgs e)
        {

            if (page == 1) { page = 2;}
            else if (page == 2) { page = 4;}
            else if (page == 3) { page = 6;}
            else if (page == 4) { page = 9;}
            else if (page == 5) { page = 11;}
            else if (page == 6) { page = 1;}
            else if (page == 7) 
            { 
                Random randGen = new Random();
                int randValue = randGen.Next(1, 11);
                if( randValue < 7)
                {
                    page = 14;
                }
                else
                {
                    page = 13;
                }
            } 
            else if (page == 8) { page = 1;}
            else if (page == 9) { page = 1;}
            else if (page == 10) { page = 1;}
            else if (page == 11) { page = 1;}
            else if (page == 12) { page = 16;}
            else if (page == 13) { page = 1;}
            else if (page == 14) { page = 19;}
            else if (page == 15) { page = 1;}
            else if (page == 16) { page = 1;}
            else if (page == 17) { page = 1;}
            else if (page == 18) { page = 1;}
            else if (page == 19) { page = 18;}
            else if (page == 20) {  page = 1;}
            else if (page == 21) {  page = 1;}
            else if (page == 22) { page = 1;}
 
            switch(page)
            {
                case 1:
                    outputLabel.Text = "You wake up 10 minutes before class starts, " +
                "you quickly get ready and get out the door. Do you choose to run or ride the bike?";
                    option1Label.Text = "Run instead.";
                    option2Label.Text = "Use the bike.";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.house;
                    break;
                case 2:
                    outputLabel.Text = "You choose to run. As you are rapidly running to school," +
                        " you see a lady that needs help crossing the road. " +
                        "do you stop and help her or keep running to school?";
                    option1Label.Text = "Stop and help her.";
                    option2Label.Text = "Don't help her and keep running.";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.crosswalk;
                    break;
                case 3:
                    outputLabel.Text = "You choose to bike. As you're biking, you see a train is quickly " +
                        "coming. Do you keep biking to get across or stop and let the train go by?";
                    option1Label.Text = "Keep biking and try to get across.";
                    option2Label.Text = "Stop and wait until the train goes by.";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.train;
                    break;
                case 4:
                    outputLabel.Text = "You decide to stop and help the lady cross the road." +
                        " She rewards you with a turnip. You say your goodbyes and you rush off quickly." +
                        " You see a shortcut in a alleyway, and you decidee to take it. As you are running " +
                        "down the ally you see a biker gang making food. They seemed to be pissed off about" +
                        " something, and it turns out they were making food but forgot to buy turnips." +
                        "they get so pissed that they threaten you for you everything you have. do you give " +
                        "them everything, try and run. Or give them the turnip you got from the lady?";
                    option1Label.Text = "You try and fight them";
                    option2Label.Text = "You give them the turnip.";
                    option3Label.Text = "You try and run away";

                    imageBox.Image = Properties.Resources.giving_turnip;
                   
                    break;
                case 5:
                    outputLabel.Text = "You decide to run past the lady. " +
                        "As you are running towards school, you see a family of geese blocking your path." +
                        "Do you try and jump over the family of geese? Or do you try and rush the gesse out of your way?";
                    option1Label.Text = "try and rush the family of geese";
                    option2Label.Text = "you jump over the family of geese";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.geese;
                    break;
                case 6:
                    outputLabel.Text = "you try and beat the train. the train is a speed-demon and you got hit and died. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 7:
                    outputLabel.Text = "You paitiantly wait unitl the train has passed." +
                        "You try and compensate for the wasted time waiting so you head down road that's downhill" +
                        "As you're biking downhill, you see a pothole. Do you try and jump over the pothole?" +
                        " Or do you stop and walk around the pothole? ";
                    option1Label.Text = "you try and jump over the pothole";
                    option2Label.Text = "you wait";
                    option3Label.Text = "";
                    
                    imageBox.Image = Properties.Resources.sink_hole;
                    break;
                case 8:
                    outputLabel.Text = "You stop and walk around the pothole, but you are too slow to school and this results in " +
                        "detention for 2 weeks. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 9:
                    outputLabel.Text = "You try and stand up for yourself. They beat you up and take your money and bike." +
                        " You are late for class :(. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 10:
                    outputLabel.Text = "You try and run away. but you trip on a rock while trying to escape. " +
                        "They catch you and beat you up so bad that you get hospitalized. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 11:
                    outputLabel.Text = "You rush the family of geese, but they end up getting annoyed and attack you." +
                        "You get plucked to death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 12:
                    outputLabel.Text = "You jump over the family of geese with ease. You see the school in eyes view. " +
                        "as you're about to reach the school you see a 10$ bill on the ground. Do you pick up the money or leave it.";
                    option1Label.Text = "Happily pick up the money";
                    option2Label.Text = "Leave the money but keep your pride";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.money;
                    break;
                case 13:
                    outputLabel.Text = "You break your leg and your bike is total trying to" +
                        " jump the pothole. You are in a cast for 1 year and you have to pay 1200$ to repair your bike," +
                        " and the icing on the cake is that you are late for school with a week of detention. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 14:
                    outputLabel.Text = "You are successful jumping the pothole whilge going downhill at 40 km/h. as you're biking," +
                        "you see that you hit traffic. This blocks your route to school, luckily you see a forest that is somewhat familiar." +
                        "Do you try your luck and go through the forest? Or try risking it all crossing the road?";
                    option1Label.Text = "Go through the forest";
                    option2Label.Text = "Risk it crossing the road";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.traffic;
                    break;
                case 15:
                    outputLabel.Text = "You give them the turnip and they are so very happy. They reward you for giving them the turnip." +
                        "They help you get to school with their motorcycles. You get to school with 5 minutes to spare! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 16:
                    outputLabel.Text = "You left the 10$ Bill and as you're running you come across the lady you didn't help at the light." +
                        "It turns out that you bummed the her groceries onto the road and they got squished." +
                        "You try and apologize to the lady but her sons deliquent gang comes and takes all your money  and beat you up. " +
                        "You are late for class. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 17:
                    outputLabel.Text = "you picked up the 10$ bill and as you're happily running to school you come across the lady from the light." +
                        "It turns out that you knocked her phone from her hand as she is talking to her son. " +
                        "You try and apologize to the lady but her sons deliquent gang comes and takes all your money  and beat you up. " +
                        "You are late for class. Play Again?"; 
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 18:
                    outputLabel.Text = "As you go left, you trip and roll down a hill. 15 bears show up becaue they hear noise right outside their home." +
                        "They are so hungry since they haven't eaten for 2 days. you get mauled and eaten. Play Again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 19:
                    outputLabel.Text = "As you go in the forest you see the path splits into two. Do you go Left or Right?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.forest;
                    break;
                case 20:
                    outputLabel.Text = "You get hit by a car trying to cross the road. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 21:
                    outputLabel.Text = "You somehow get through traffic without a scratch, and you get to school with a 4 minutes to spare. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 22:
                    outputLabel.Text = "As you choose right, You see a white light at the end of the forest. You somehow get out!" +
                        "You get to school with 2 minutes to spare. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for Playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    imageBox.Image = Properties.Resources.thanks;

                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;

            }
         
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 3; }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 7; }
            else if (page == 4) { page = 15; }
            else if (page == 5) { page = 12; }
            else if (page == 6) { page = 99; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 99; }
            else if (page == 9) { page = 99; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 99; }
            else if (page == 12) { page = 16; }
            else if (page == 13) { page = 99; }
            else if (page == 14) 
            {
                Random randGen = new Random();
                int randValue = randGen.Next(1, 11);
                if (randValue < 3)
                {
                    page = 21;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 17) { page = 99; }
            else if (page == 18) { page = 99; }
            else if (page == 19) { page = 18; }
            else if (page == 20) { page = 99; }
            else if (page == 21) { page = 99; }
            else if (page == 22) { page = 99; }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wake up 10 minutes before class starts, " +
                "you quickly get ready and get out the door. Do you choose to run or ride the bike?";
                    option1Label.Text = "Run.";
                    option2Label.Text = "Use the bike.";
                    option3Label.Text = "";
                  
                    SoundPlayer Alarm = new SoundPlayer(Properties.Resources._219244__zyrytsounds__alarm_clock_short);
                    Alarm.Play();
                   
                    imageBox.Image = Properties.Resources.house;
                    break;
                case 2:
                    outputLabel.Text = "You choose to run. As you are rapidly running to school," +
                        " you see a lady that needs help crossing the road. " +
                        "do you stop and help her or keep running to school?";
                    option1Label.Text = "Stop and help her.";
                    option2Label.Text = "Don't help her and keep running.";
                    option3Label.Text = "";

                    SoundPlayer run = new SoundPlayer(Properties.Resources._443218__topschool__running);
                    run.Play();

                    imageBox.Image = Properties.Resources.crosswalk;
                    break;
                case 3:
                    outputLabel.Text = "You choose to bike. As you're biking, you see a train is quickly " +
                        "coming. Do you keep biking to get across or stop and let the train go by?";
                    option1Label.Text = "Keep biking and try to get across.";
                    option2Label.Text = "Stop and wait until the train goes by.";
                    option3Label.Text = "";

                    SoundPlayer train = new SoundPlayer(Properties.Resources.);
                    train.Play();

                    imageBox.Image = Properties.Resources.train;
                    break;
                case 4:
                    outputLabel.Text = "You decide to stop and help the lady cross the road." +
                        " She rewards you with a turnip. You say your goodbyes and you rush off quickly." +
                        " You see a shortcut in a alleyway, and you decidee to take it. As you are running " +
                        "down the ally you see a biker gang making food. They seemed to be pissed off about" +
                        " something, and it turns out they were making food but forgot to buy turnips." +
                        "they get so pissed that they threaten you for you everything you have. do you give " +
                        "them everything, try and run. Or give them the turnip you got from the lady?";
                    option1Label.Text = "You try and fight them";
                    option2Label.Text = "You give them the turnip.";
                    option3Label.Text = "You try and run away";

                    imageBox.Image = Properties.Resources.giving_turnip;

                    break;
                case 5:
                    outputLabel.Text = "You decide to run past the lady. " +
                        "As you are running towards school, you see a family of geese blocking your path." +
                        "Do you try and jump over the family of geese? Or do you try and rush the gesse out of your way?";
                    option1Label.Text = "try and rush the family of geese";
                    option2Label.Text = "you jump over the family of geese";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.geese;
                    break;
                case 6:
                    outputLabel.Text = "you try and beat the train. the train is a speed-demon and you got hit and died. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 7:
                    outputLabel.Text = "You paitiantly wait unitl the train has passed." +
                        "You try and compensate for the wasted time waiting so you head down road that's downhill" +
                        "As you're biking downhill, you see a pothole. Do you try and jump over the pothole?" +
                        " Or do you stop and walk around the pothole? ";
                    option1Label.Text = "you try and jump over the pothole";
                    option2Label.Text = "you wait";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.sink_hole;
                    break;
                case 8:
                    outputLabel.Text = "You stop and walk around the pothole, but you are too slow to school and this results in " +
                        "detention for 2 weeks. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 9:
                    outputLabel.Text = "You try and stand up for yourself. They beat you up and take your money and bike." +
                        " You are late for class :(. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 10:
                    outputLabel.Text = "You try and run away. but you trip on a rock while trying to escape. " +
                        "They catch you and beat you up so bad that you get hospitalized. PLay again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 11:
                    outputLabel.Text = "You rush the family of geese, but they end up getting annoyed and attack you." +
                        "You get plucked to death. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 12:
                    outputLabel.Text = "You jump over the family of geese with ease. You see the school in eyes view. " +
                        "as you're about to reach the school you see a 10$ bill on the ground. Do you pick up the money or leave it.";
                    option1Label.Text = "Happily pick up the money";
                    option2Label.Text = "Leave the money but keep your pride";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.money;
                    break;
                case 13:
                    outputLabel.Text = "You break your leg and your bike is total trying to" +
                        " jump the pothole. You are in a cast for 1 year and you have to pay 1200$ to repair your bike," +
                        " and the icing on the cake is that you are late for school with a week of detention. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 14:
                    outputLabel.Text = "You are successful jumping the pothole whilge going downhill at 40 km/h. as you're biking," +
                        "you see that you hit traffic. This blocks your route to school, luckily you see a forest that is somewhat familiar." +
                        "Do you try your luck and go through the forest? Or try risking it all crossing the road?";
                    option1Label.Text = "Go through the forest";
                    option2Label.Text = "Risk it crossing the road";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.traffic;
                    break;
                case 15:
                    outputLabel.Text = "You give them the turnip and they are so very happy. They reward you for giving them the turnip." +
                        "They help you get to school with their motorcycles. You get to school with 5 minutes to spare! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 16:
                    outputLabel.Text = "You left the 10$ Bill and as you're running you come across the lady you didn't help at the light." +
                        "It turns out that you bummed the her groceries onto the road and they got squished." +
                        "You try and apologize to the lady but her sons deliquent gang comes and takes all your money  and beat you up. " +
                        "You are late for class. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 17:
                    outputLabel.Text = "you picked up the 10$ bill and as you're happily running to school you come across the lady from the light." +
                        "It turns out that you knocked her phone from her hand as she is talking to her son. " +
                        "You try and apologize to the lady but her sons deliquent gang comes and takes all your money  and beat you up. " +
                        "You are late for class. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 18:
                    outputLabel.Text = "As you go left, you trip and roll down a hill. 15 bears show up becaue they hear noise right outside their home." +
                        "They are so hungry since they haven't eaten for 2 days. you get mauled and eaten. Play Again? ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 19:
                    outputLabel.Text = "As you go in the forest you see the path splits into two. Do you go Left or Right?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.forest;
                    break;
                case 20:
                    outputLabel.Text = "You get hit by a car trying to cross the road. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.Game_over;
                    break;
                case 21:
                    outputLabel.Text = "You somehow get through traffic without a scratch, and you get to school with a 4 minutes to spare. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 22:
                    outputLabel.Text = "As you choose right, You see a white light at the end of the forest. You somehow get out!" +
                        "You get to school with 2 minutes to spare. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    imageBox.Image = Properties.Resources.win;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for Playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    imageBox.Image = Properties.Resources.thanks;
                    SoundPlayer HEHEHEHA = new SoundPlayer(Properties.Resources.clash_royale_laugh);
                    HEHEHEHA.Play();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;

            }
        }


    }
}
