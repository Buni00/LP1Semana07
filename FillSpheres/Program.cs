using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(123, 123, 123), 2.0f);
            Sphere sphere2 = new Sphere(new Color(50, 50, 50), 3.0f);
            Sphere sphere3 = new Sphere(new Color(0, 0, 0), 1.0f);

            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere2.Throw();
        }
    }
}
