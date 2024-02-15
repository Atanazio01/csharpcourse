namespace LinkWithLambda;
using LinkWithLambda.Entities;

internal class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Category c1 = new Category(1, "Tools", 2);
        Category c2 = new Category(2, "Computers", 1);
        Category c3 = new Category(3, "Electronics", 1);

        List<Product> Products = new List<Product>()
        {
            new Product(1, "Computer", 1100.0, c2),
            new Product(2, "Hammer", 90.0, c1),
            new Product(3, "TV", 1700.0, c3),
            new Product(4, "Notebook", 1300.0, c2),
            new Product(5, "Saw", 80.0, c1),
            new Product(6, "Tablet", 700.0, c2),
            new Product(7, "Camera", 700.0, c3),
            new Product(8, "Printer", 350.0, c3),
            new Product(9, "MacBook", 1800.0, c2),
            new Product(10, "Sound Bar", 700.0, c3),
            new Product(11, "Level", 70.0, c1)
        };

        //var r1 = Products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        var r1 = from p in Products where p.Category.Tier == 1 && p.Price < 900.0 select p;
        Print("TIER 1 AND PRICE < 900:", r1);

        //var r2 = Products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        var r2 = from p in Products where p.Category.Name == "Tools" select p.Name;
        Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

        //var r3 = Products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        var r3 = from p in Products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

        //var r4 = Products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        var r4 = from p in Products where p.Category.Tier == 1 orderby p.Price, p.Name select p;
        Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

        //var r5 = r4.Skip(2).Take(4);
        var r5 = (from p in Products where p.Category.Tier == 1 orderby p.Price, p.Name select p).Skip(2).Take(4);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

        //var r6 = Products.FirstOrDefault();
        var r6 = (from p in Products select p).FirstOrDefault();
        Console.WriteLine("First test1: " + r6);

        //var r7 = Products.Where(p => p.Price > 3000.0).FirstOrDefault();
        var r7 = (from p in Products where p.Price > 3000.0 select p).FirstOrDefault();
        Console.WriteLine("First test2: " + r7);

        //var r8 = Products.Where(p => p.Id == 3).SingleOrDefault();
        var r8 = (from p in Products where p.Id == 3 select p).SingleOrDefault();
        Console.WriteLine("Single or default test1: " + r8);

        //var r9 = Products.Where(p => p.Id == 30).SingleOrDefault();
        var r9 = (from p in Products where p.Id == 30 select p).SingleOrDefault();
        Console.WriteLine("Single or default test2: " + r9);

        //var r10 = Products.Max(p => p.Price);
        var r10 = (from p in Products select p.Price).Max();
        Console.WriteLine("Max price: " + r10);

        //var r11 = Products.Min(p => p.Price);
        var r11 = (from p in Products select p.Price).Min();
        Console.WriteLine("Min price: " + r11);

        //var r12 = Products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        var r12 = (from p in Products where p.Category.Id == 1 select p.Price).Sum();
        Console.WriteLine("Category 1 Sum prices: " + r12);

        //var r13 = Products.Where(p => p.Category.Id == 1).Average(p => p.Price);
        var r13 = (from p in Products where p.Category.Id == 1 select p.Price).Average();
        Console.WriteLine("Category 1 Average prices: " + r13);

        //var r14 = Products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
        var r14 = (from p in Products where p.Category.Id == 5 select p.Price).DefaultIfEmpty(0.0).Average();
        Console.WriteLine("Category 5 Average prices: " + r14);

        //var r15 = Products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        var r15 = (from p in Products where p.Category.Id == 1 select p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("Category 1 aggregate sum: " + r15);

        Console.WriteLine();

        //var r16 = Products.GroupBy(p => p.Category);
        var r16 = from p in Products group p by p.Category;
        foreach (IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine("Category " + group.Key.Name + ":");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
    }
}
