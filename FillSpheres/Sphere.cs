namespace BetterFillSpheres
{
    public class Sphere
    {
        private float radius;
        private int timesThrown;

        public Color Color { get; set; }

        public float Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public int TimesThrown
        {
            get { return timesThrown; }
        }

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            timesThrown = 0;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
                timesThrown++;
        }
    }
}