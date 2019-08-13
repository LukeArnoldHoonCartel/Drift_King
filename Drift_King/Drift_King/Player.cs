﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Drift_King
{
    class Player
    {
        public int x, y, width, height;//variables for the rectangle
        public Image player;//variable for the planet's image

        public Rectangle playerRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 5;
            y = 250;
            width = 180;
            height = 63;
            player = Image.FromFile("R34.png");
            playerRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawPlayer(Graphics g)
        {

            g.DrawImage(player, playerRec);
        }
        public void movePlayer(string move)
        {
            playerRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (playerRec.Location.X > 480) // is spaceship within 50 of right side
                {

                    x = 480;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    playerRec.Location = new Point(x, y);
                }
            }

                if (move == "left")
                {
                    if (playerRec.Location.X < 10) // is spaceship within 10 of left side
                    {

                        x = 10;
                        playerRec.Location = new Point(x, y);
                    }
                    else
                    {
                        x -= 5;
                        playerRec.Location = new Point(x, y);
                    }


                }

}   }   }   

