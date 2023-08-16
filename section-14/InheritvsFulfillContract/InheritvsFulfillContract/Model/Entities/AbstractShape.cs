using InheritvsFulfillContract.Model.Enums;

namespace InheritvsFulfillContract.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
