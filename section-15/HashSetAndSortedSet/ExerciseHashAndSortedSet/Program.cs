using ExerciseHashAndSortedSet.Entities;

namespace Class221.ExerciseHashAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Course> A = new HashSet<Course>();
            HashSet<Course> B = new HashSet<Course>();
            HashSet<Course> C = new HashSet<Course>();

            Console.Write("How many students for course A?");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                A.Add(new Course(int.Parse(Console.ReadLine())));
            }
            

            Console.Write("How many students for course B?");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                B.Add(new Course(int.Parse(Console.ReadLine())));
            }
            
            
            Console.Write("How many students for course C?");
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; i < z; i++)
            {
                C.Add(new Course(int.Parse(Console.ReadLine())));
            }

            HashSet<Course> all = new HashSet<Course>(A);
            all.UnionWith(B);
            all.UnionWith(C);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}