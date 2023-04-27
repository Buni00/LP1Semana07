namespace FillSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int nThrows;

        public Sphere (Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.nThrows = 0;
        }


        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius >0)
                nThrows++;
        }


    }

}