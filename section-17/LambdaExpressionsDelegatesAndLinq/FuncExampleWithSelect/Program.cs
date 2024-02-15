using PredicateRemoveAllExample.Entities;

namespace FuncExampleWithSelect;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        Func<Product, string> func = NameUpper; // Delegate instantiation

        List<string> result = list.Select(NameUpper).ToList();

        foreach (string s in result)
        {
            Console.WriteLine(s);
        }

    }

    public static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }
}
