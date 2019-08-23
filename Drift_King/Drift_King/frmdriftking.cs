using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Drift_King
{
    public partial class Driftking : Form
    
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called cars 
        Car[] car = new Car[3];
        Random xspeed = new Random();
        Player player = new Player();
        bool left, right, up, down;
        int score, lives;
        string move;
        private GifImage gifImage = null;
        private string filePath = "Road.gif";
        string playerName;


        public Driftking()
        {
            InitializeComponent();
            //b) We control the animation
            gifImage = new GifImage(filePath);
            gifImage.ReverseAtEnd = false; //dont reverse at end
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 3; i++)
            {
                int x = 185 + (i * 65);
                car[i] = new Car(x);
                
            }


        }

        private void Driftking_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left, right , up and down arrow keys to move the car. \n Don't get hit by the Cars! \n Every car that gets past scores a point. \n If a car hits you loss a life! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            txtName.Focus();


        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //Start the time/animation
           
            //get the graphics used to paint on the panel control
            g = e.Graphics;
           
            for (int i = 0; i < 3; i++)
            {

                if (score < 6)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    int rndmspeed = xspeed.Next(1, 15);
                    car[i].x -= rndmspeed;
                }


                if (score > 5)
                {
                    int rndmspeed = xspeed.Next(15, 20); //each missile has a higher random speed
                    car[i].x -= rndmspeed;
                }

                if (score > 15)
                {
                    int rndmspeed = xspeed.Next(20, 50); //each missile has a higher random speed
                    car[i].x -= rndmspeed;
                }

                if (score > 30)
                {
                    int rndmspeed = xspeed.Next(50, 75); //each car has a higher random speed
                    car[i].x -= rndmspeed;
                }
                if (score > 50)
                {
                    int rndmspeed = xspeed.Next(50, 100); //each car has a higher random speed
                    car[i].x -= rndmspeed;
                }


                //call the car class's drawcar method to draw the images
                car[i].drawCar(g);
            }


            
        



        player.drawPlayer(g);
        }

        

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i < 3; i++)
            {
                car[i].moveCar();
                if (player.playerRec.IntersectsWith(car[i].carRec))
                {
                    //reset planet[i] back to top of panel
                    car[i].x = 600; // set  y value of planetRec
                    lives -= 1;// lose a life
                    txtlives.Text = lives.ToString();// display number of lives
                    checkLives();
                }

                score += car[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score

            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
        private void TmrPlayer_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.movePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.movePlayer(move);
            }
            if (up) // if right arrow key pressed
            {
                move = "up";
                player.movePlayer(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                player.movePlayer(move);
            }

        }

        

        private void mnuStart_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Starting");
                score = 0;
                lblScore.Text = score.ToString();
                lives = int.Parse(txtlives.Text);// pass lives entered from textbox to lives variable
                tmrCar.Enabled = true;
                TmrPlayer.Enabled = true;
                tmrpic.Enabled = true;
                
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                txtName.Clear();
                txtName.Focus();
                tmrCar.Enabled = false;
                TmrPlayer.Enabled = false;
                tmrpic.Enabled = false;
            }
            
            
            
           
        }

        

        private void picgame_Click_1(object sender, EventArgs e)
        {
        //Start the time/animation
        //tmrpic.Enabled = true;
              
                             

        }

        private void tmrpic_Tick(object sender, EventArgs e)
        {
            //picgame.Image = gifImage.GetNextFrame();
        }

        

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            string context = txtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))//if current character not a letter
                {
                    isletter = false;//make isletter false
                    break;//exit the for loop
                }
            }

            //if not a letter clear the textbox and focus on it to enter name again
            if (isletter == false)
            {
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrCar.Enabled = false;
            TmrPlayer.Enabled = false;
            tmrpic.Enabled = false;
            MessageBox.Show("Use the left, right , up and down arrow keys to move the car. \n Don't get hit by the Cars! \n Every car that gets past scores a point. \n If a car hits you loss a life! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            txtName.Focus();
        }

        private void txtlives_TextChanged(object sender, EventArgs e)
        {
            string context = txtlives.Text;
            bool isnumber = true;
            //for loop checks for numbers as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsNumber(context[i]))//if current character not a number
                {
                    isnumber = false;//make isnumber false
                    break;//exit the for loop
                }
            }

            //if not a number clear the textbox and focus on it to enter lives again
            if (isnumber == false)
            {
                txtlives.Clear();
                txtlives.Focus();
            }
            else
            {
                mnuStart.Enabled = true;
            }
        }

        private void reseatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quitmmu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
           
            
            tmrCar.Enabled = false;
            TmrPlayer.Enabled = false;
            tmrpic.Enabled = false;

        }
        private void Driftking_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void Driftking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void checkLives()
        {
            if (lives == 0)
            {
                tmrCar.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");
                Application.Restart();
            }
            if (lives == -1)
            {
                tmrCar.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");
                Application.Restart();
            }
        }


    }
}
