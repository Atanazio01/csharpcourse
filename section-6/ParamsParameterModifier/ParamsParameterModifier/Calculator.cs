namespace ParamsParameterModifier
{
    class Calculator
    {
        public static int Sum(params int[] numbers) // o modificador params informa ao compilador que irá 
                                                    // receber uma funcao que recebe um número variavel de valores
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}

