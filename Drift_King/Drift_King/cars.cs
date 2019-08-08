using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Drift_King
{
    class Car
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image carImage;//variable for the cars image
        public Rectangle carRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Car(int spacing)
        {
            x = spacing;
            y = 10;
            width = 548;
            height = 193;
            carImage = Image.FromFile("car4.png");
            carRec = new Rectangle(x, y, width, height);
        }

        // Methods for the cars class
        public void drawCar(Graphics g)
        {
            carRec = new Rectangle(x, y, width, height);
            g.DrawImage(carImage, carRec);
        }

    }
}
