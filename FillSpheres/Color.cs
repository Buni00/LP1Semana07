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