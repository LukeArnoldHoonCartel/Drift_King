using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        bool left, right;
        int score, lives;
        string move;


        public Driftking()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                int x = 170 + (i * 60);
                car[i] = new Car(x);
            }


        }

        private void Driftking_Load(object sender, EventArgs e)
        {
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
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

        }

        private void Driftking_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        

        private void Driftking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
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
