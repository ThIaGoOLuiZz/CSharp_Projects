namespace NumeroMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for(int x=0;x<numeros.Length;x++)
            {
                Console.Write("Digite um numero inteiro: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine($"O maior numero é: {NumMaior(numeros)}"); 
        }

        static int NumMaior(int[] numero) {
            if (numero[0] > numero[1] && numero[0] > numero[2])
            {
                return numero[0];
            }
            else if(numero[1] > numero[0] && numero[1] > numero[2])
            {
                return numero[1];
            }
            return numero[2];
        }
    }
}