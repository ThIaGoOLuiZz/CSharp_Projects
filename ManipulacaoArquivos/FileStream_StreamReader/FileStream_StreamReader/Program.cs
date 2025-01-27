using System.IO;

namespace FileStream_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\thiag\Downloads\File.txt";

            StreamReader sr = null;
            string line = "";
            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
