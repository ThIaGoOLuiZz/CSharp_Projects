using System.IO;

namespace File_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\thiag\Downloads\File.txt";
            string targetPath = @"C:\Users\thiag\Downloads\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
