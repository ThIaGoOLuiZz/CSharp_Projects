using System.Globalization;

namespace AprovacaoNotas_classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            //NOTA 1
            do
            {
                Console.Write("Qual a primeira nota?: ");
                aluno1.Nota1 = int.Parse(Console.ReadLine());
                
                if(aluno1.Nota1 < 0 && aluno1.Nota1 > 100)
                {
                    Console.WriteLine("Digite uma nota valida!!!");
                    Console.WriteLine();
                }
            } while (aluno1.Nota1 < 0 && aluno1.Nota1 > 100);

            //NOTA 2
            do
            {
                Console.Write("Qual a primeira nota?: ");
                aluno1.Nota2 = int.Parse(Console.ReadLine());

                if (aluno1.Nota2 < 0 && aluno1.Nota2 > 100)
                {
                    Console.WriteLine("Digite uma nota valida!!!");
                    Console.WriteLine();
                }
            } while (aluno1.Nota2 < 0 && aluno1.Nota2 > 100);

            //NOTA 3
            do
            {
                Console.Write("Qual a primeira nota?: ");
                aluno1.Nota3 = int.Parse(Console.ReadLine());

                if (aluno1.Nota3 < 0 && aluno1.Nota3 > 100)
                {
                    Console.WriteLine("Digite uma nota valida!!!");
                    Console.WriteLine();
                }
            } while (aluno1.Nota3 < 0 && aluno1.Nota3 > 100);

            Console.Clear();

            Console.WriteLine(aluno1);
        }
    }
}