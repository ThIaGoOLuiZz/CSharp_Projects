namespace PessoaMaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa_1 = new Pessoa();
            Pessoa pessoa_2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa!");
            Console.Write("Nome: ");
            pessoa_1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa_1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome da segunda pessoa!");
            Console.Write("Nome: ");
            pessoa_2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa_2.Idade = int.Parse(Console.ReadLine());

            if(pessoa_1.Idade > pessoa_2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa_1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa_2.Nome}");
            }
        }
    }
}
