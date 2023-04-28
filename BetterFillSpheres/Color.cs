namespace BetterFillSpheres
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = ColorMaxID(red);
            Green = ColorMaxID(green);
            Blue = ColorMaxID(blue);
            Alpha = ColorMaxID(alpha);
        }

        public Color(int red, int green, int blue)
        {
            Red = ColorMaxID(red);
            Green = ColorMaxID(green);
            Blue = ColorMaxID(blue);
            Alpha = 255;
        }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
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

        public string Name
        {
            get
            {
                return (Red, Green, Blue) switch
                {
                    (255, 0, 0) => "Red 100%",
                    (0, 255, 0) => "Green 100%",
                    (0, 0, 255) => "Blue 100%",
                    _ => "Mixed"
                };
            }
        }
    }
}