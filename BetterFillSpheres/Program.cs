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

            sphere1.Pop();
            sphere3.Pop();

            PrintSphereState("Sphere 1", sphere1);
            PrintSphereState("Sphere 2", sphere2);
            PrintSphereState("Sphere 3", sphere3);
        }

        static void PrintSphereState(string sphereName, Sphere sphere)
        {
            Console.WriteLine(sphereName);
            Console.WriteLine("Red: " + sphere.color.Red + ", Green: " + sphere.color.Green + ", Blue: " + sphere.color.Blue + ", Alpha: " + sphere.color.Alpha);
            Console.WriteLine("Radius: " + sphere.GetRadius);
            Console.WriteLine("Times Thrown: " + sphere.GetTimesThrown());
            Console.WriteLine();
        }
    }
}


