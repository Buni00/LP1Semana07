using System;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color color;
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

        public int GetTimesThrown()
        {
            return nThrows;
        }

        public float GetRadius 
        {
            get { return radius; }
        }


    }

}