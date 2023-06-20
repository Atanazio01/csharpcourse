using System.Globalization;

namespace Exercise03
{
    internal class Student
    {
        public string Name;
        public double N1;
        public double N2;
        public double N3;

        public double SumOfGrades()
        {
            return N1 + N2 + N3;
        }

        public string CheckIsApproved()
        {
            if(SumOfGrades() >= 60.00)
            {
                return $"APROVADO";
            }
            else
            {
                double difference = 60.00 - SumOfGrades();
                return $"REPROVADO\nFALTARAM {difference.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }

        public override string ToString()
        {
            return $"NOTA FINAL = {SumOfGrades().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{CheckIsApproved()}";
        }
    }
}
