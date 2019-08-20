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
                //call the Planet class's drawPlanet method to draw the images
                car[i].drawCar(g);
                // generate a random number from 5 to 30 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 30);
                car[i].x -= rndmspeed;

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
                    txtLives.Text = lives.ToString();// display number of lives
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
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            tmrCar.Enabled = true;
            TmrPlayer.Enabled = true;
            tmrpic.Enabled = true;
        }

        

        private void picgame_Click_1(object sender, EventArgs e)
        {
        //Start the time/animation
        tmrpic.Enabled = true;
        }

        private void tmrpic_Tick(object sender, EventArgs e)
        {
            picgame.Image = gifImage.GetNextFrame();
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

            }
        }


    }
}
