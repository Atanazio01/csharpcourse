using SolvedExerciseAbstractMethods.Entities.Enums;
using System.Globalization;

namespace SolvedExerciseAbstractMethods.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
