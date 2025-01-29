using Course.Services;

namespace MaxValueCalc
{
    delegate double BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);

            result = op2(a, b);
            Console.WriteLine(result);
        }
    }
}
