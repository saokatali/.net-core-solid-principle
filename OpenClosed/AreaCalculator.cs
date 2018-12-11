namespace SolidPrinciple.OpenClosed
{
    public class AreaCalculator
    {

        public double TotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.Area();

            }

            return totalArea;

        }
            
    }
}
