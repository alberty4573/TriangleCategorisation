namespace TriangleCategorisation
{
    class Triangle
    {
        public string type { get; set; }

        // Judge if its a triangle
        public bool isTriangle(decimal side1, decimal side2, decimal side3)
        {
            bool isTriangleVar = false;
            if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
            {
                isTriangleVar = true;
            }

            return isTriangleVar;
        }

        // Categorise different triangles
        public string catTriangle(decimal side1, decimal side2, decimal side3)
        {
            string result1 = "";
            string result2 = "";

            if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                if (side1 == side2 && side1 == side3)
                {
                    return result1 = "Equilateral Triangle";
                }

                result1 = "Isosceles Triangle";
            }

            // This result will not be printed since there is no suitable input
            if (side1 * side1 + side2 * side2 == side3 * side3 || side1 * side1 + side3 * side3 == side2 * side2 || side2 * side2 + side3 * side3 == side1 * side1)
            {
                result2 = "Right Triangle";
            }

            if (result1 == "" && result2 == "")
            {
                return "Normal Triangle";
            }

            return result1 + result2;
        }
    }
}
