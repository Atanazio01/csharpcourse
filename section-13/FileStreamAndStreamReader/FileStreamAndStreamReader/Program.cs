using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path); // sintaxe enxuta,  já instancia o fs e instancia o sr em cima dele

                //string line = sr.ReadLine(); // lê uma linha

                while(!sr.EndOfStream) // utilizando o while para ler todas as linhas
                {
                    string line2 = sr.ReadLine();
                    Console.WriteLine(line2);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                // if (fs != null) fs.Close();
            }
        }
    }
}