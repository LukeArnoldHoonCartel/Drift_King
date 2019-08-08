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


        public Driftking()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                int x = 10 + (i * 75);
                car[i] = new Car(x);
            }


        }

        private void Driftking_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 3; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                car[i].drawCar(g);
            }

        }
    }
}
