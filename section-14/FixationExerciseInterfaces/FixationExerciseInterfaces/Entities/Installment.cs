using System.Globalization;

namespace FixationExerciseInterfaces.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"\n{DueDate.ToShortDateString()} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
