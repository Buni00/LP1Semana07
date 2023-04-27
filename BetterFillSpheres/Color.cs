namespace FillSpheres
{

    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = ColorMaxID(red);
            this.green = ColorMaxID(green);
            this.blue = ColorMaxID(blue);
            this.alpha = ColorMaxID(alpha);
        }

        public Color(int red, int green, int blue)
        {
            this.red = ColorMaxID(red);
            this.green = ColorMaxID(green);
            this.blue = ColorMaxID(blue);
            this.alpha = 255;
        }

        public int Red
        {
            get {return red; }
            set { red = ColorMaxID(value); }
        }

        public int Green
        {
            get {return green; }
            set { green = ColorMaxID(value); }
        }

        public int Blue
        {
            get {return blue; }
            set { blue = ColorMaxID(value); }
        }

        public int Alpha
        {
            get {return alpha; }
            set { alpha = ColorMaxID(value); }
        }

        public int GetGrey()
        {
            int grey = (red + green + blue)/3;
            return grey;
        }

        private int ColorMaxID(int value)
        {
            if (value < 0)
                return 0;
            else if (value > 255)
                return 255;
            else
                return value;
        }
    }
}