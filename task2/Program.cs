
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 1)
            {
                Console.WriteLine("Принимаетя только один аргумент");
                Environment.Exit(0);
            }

            string filename = args[0]; // имя файла из аргументов командной строки

            if (!File.Exists(filename))
            {
                Console.WriteLine("File {0} does not exist.", filename);
                Environment.Exit(0);
            }

            int[] numb = ReadFromFile.ReadFromFile1(filename);
            Engine.Engine1(numb);
        }
    }
}