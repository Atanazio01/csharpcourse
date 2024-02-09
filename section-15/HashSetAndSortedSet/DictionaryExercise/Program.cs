namespace Class223.DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> eleitors = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        if (!eleitors.ContainsKey(line[0]))
                        {
                            eleitors.Add(line[0], int.Parse(line[1]));
                        }
                        else
                        {
                            eleitors[line[0]] += int.Parse(line[1]);
                        }
                    }

                    foreach (KeyValuePair<string, int> item in eleitors)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}