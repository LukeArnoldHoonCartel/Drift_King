using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Drift_King
{
    class cars
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image carsImage;//variable for the cars image

        public Rectangle carsRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public cars()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            carsImage = Image.FromFile("car4.png");
            carsRec = new Rectangle(x, y, width, height);
        }

    }
}
