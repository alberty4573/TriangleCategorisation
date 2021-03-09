using System;

namespace TriangleCategorisation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            try
            {
                // Input three sides of the triangle
                Console.WriteLine("Please type in the first side of a triangle: ");
                var triSide1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please type in the second side of a triangle: ");
                var triSide2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please type in the third side of a triangle: ");
                var triSide3 = Convert.ToDecimal(Console.ReadLine());

                // Could use DI here
                var triangle = new Triangle();
                if (triangle.isTriangle(triSide1, triSide2, triSide3))
                {
                    Console.WriteLine("This is a " + triangle.catTriangle(triSide1, triSide2, triSide3)); 
                } else
                {
                    Console.WriteLine("This is not a triangle");
                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Here are the error message: " + ex);

            }

            
        }
    }
}
