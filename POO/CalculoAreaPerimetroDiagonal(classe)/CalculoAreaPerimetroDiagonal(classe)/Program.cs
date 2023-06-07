namespace CalculoAreaPerimetroDiagonal_classe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Digite o valor da Largura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da Altura do retangulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(r);
        }
    }
}