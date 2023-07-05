
namespace ListInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); // Insere o valor na última posição da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco"); // Recebe o índice onde será adicionado e o valor
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<string> list3 = new List<string>();

            foreach (var item in list)
            {
                list3.Add(item);
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("List count: " + list.Count()); ; // retorna o tamanho da lista

            string s1 = list.Find(item => item[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(item => item[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(item => item[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(item => item[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(item => item.Length == 5);

            Console.WriteLine("---------------------------");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------------");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(item => item[0] == 'M');
            Console.WriteLine("---------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(0);
            Console.WriteLine("---------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list3.RemoveRange(2,2);
            Console.WriteLine("---------------------------");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
        }
    }
}