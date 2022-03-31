namespace BasycTypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incompleto = false; // bool
            bool completo = true; // bool
            char gender = 'F'; // characters unicode
            char leter = '\u0041'; // utilizing unicode 
            sbyte x = 126; // 1 Byte -128 to 127
            byte n1 = 255; // 1 Byte 0 to 255
            int n2 = 1000; // 4 Bytes -2³¹ to 2³¹    int.MinValue and int.MaxValue
            int n3 = 2147483647; // int max value
            long n4 = 2147483648L; // > int max value, utilizing L in the final
            float n5 = 4.5F; //floating point number, F required
            double n6 = 4.5; //floating point number
            string nome = "Maria Green"; // IMMUTABLE unicode string (safety, simplicity, thread safe)
            object obj1 = "Alex Brown"; // A generic object (all class in C3 is a subclass of object)
            object obj2 = 4.5F; // A generic object (all class in C3 is a subclass of object)


            Console.WriteLine("bool: " + completo);
            Console.WriteLine("bool: " + incompleto);
            Console.WriteLine("char: " + gender);
            Console.WriteLine("char unicode: " + leter);
            Console.WriteLine("sbyte: " + x);
            Console.WriteLine("byte: " + n1);
            Console.WriteLine("int: " + n2);
            Console.WriteLine("int: " + n3);
            Console.WriteLine("long: " + n4);
            Console.WriteLine("float: " + n5);
            Console.WriteLine("double: " + n6);
            Console.WriteLine("string: " + nome);
            Console.WriteLine("object: " + obj1);
            Console.WriteLine("object: " + obj2);
        }
    }
}
