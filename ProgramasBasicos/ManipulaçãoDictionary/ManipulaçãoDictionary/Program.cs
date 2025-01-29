using System.Collections.Generic;

namespace ManipulaçãoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["Email"] = "maria@gmail.com";
            cookies["Fone"] = "999999999";
            cookies["Fone"] = "000000000";

            Console.WriteLine(cookies["Email"]);
            Console.WriteLine(cookies["Fone"]);

            cookies.Remove("Email");
            
            if (cookies.ContainsKey("Email")) Console.WriteLine(cookies["Email"]);
            else Console.WriteLine("Não existe o email");

            Console.WriteLine("Tamanho: " + cookies.Count);

            Console.WriteLine("All Cookies");

            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
