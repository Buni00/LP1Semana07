using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(123, 123, 123), 2.0f);
            Sphere sphere2 = new Sphere(new Color(50, 50, 50), 3.0f);
            Sphere sphere3 = new Sphere(new Color(255, 0, 0), 1.0f);

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

            Console.WriteLine(sphere3.Color.Name);

        }

        static void PrintSphereState(string sphereName, Sphere sphere)
        {
            Console.WriteLine(sphereName);
            Console.WriteLine("Red: " + sphere.Color.Red + ", Green: " + sphere.Color.Green + ", Blue: " + sphere.Color.Blue + ", Alpha: " + sphere.Color.Alpha);
            Console.WriteLine("Radius: " + sphere.Radius);
            Console.WriteLine("Times Thrown: " + sphere.TimesThrown);
            Console.WriteLine();
        }
    }
}

