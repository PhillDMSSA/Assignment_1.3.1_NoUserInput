namespace Practicing_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Square Area
            double squareLength = 5.5;
            double result = SqaureArea(squareLength);
            Console.WriteLine(result);

            //Triangle Area
            double triBaseLenth = 5.5;
            double triHeightLenth = 5.2;
            double triResult = TriangleArea(triBaseLenth, triHeightLenth);
            Console.WriteLine(triResult);

            //Rectangle Area
            double rectangleLength = 5.6;
            double rectangleWidth = 10;
            double recResult = RectangleArea(rectangleLength, rectangleWidth);
            Console.WriteLine(recResult);

        }
        static double SqaureArea(double length)
        {
            double area = length * length;

            return area;
        }

        static double TriangleArea(double baseTri, double heightTri)
        {
            double areaTri = 0.50 * baseTri * heightTri;

            return areaTri;
        }
        static double RectangleArea(double recLenth, double recWidth)
        {
            double recArea = recLenth * recWidth;

            return recArea;
        }
    }
}
