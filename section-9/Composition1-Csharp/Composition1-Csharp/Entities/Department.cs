namespace Composition1_Csharp.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }
}
