using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    public struct Pixel
    {
        private double red;

        public double Red
        {
            get { return red; }
            set
            {
                red = Check(value);
            }
        }

        private double green;

        public double Green
        {
            get { return green; }
            set
            {
                green = Check(value);
            }
        }

        private double blue;

        public double Blue
        {
            get { return blue; }
            set
            {
                blue = Check(value);
            }
        }

        public Pixel(double red, double green, double blue)
        {
            this.red = this.green = this.blue = 0;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static Pixel operator *(Pixel pixel, double value)
        {
            return new Pixel(Trim(pixel.Red * value), Trim(pixel.Green * value), Trim(pixel.Blue * value));
        }

        public static Pixel operator *(double value, Pixel pixel)
        {
            return pixel * value;
        }

        private static double Trim(double value)
        {
            if (value < 0)
            {
                return 0;
            }
            if (value > 1)
            {
                return 1;
            }

            return value;
        }

        private static double Check(double value)
        {
            if(value < 0 || value > 1)
            {
                throw new ArgumentException("Wrong channel value {0} (the value must be between 0 and 1");
            }

            return value;
        }
    }
}
