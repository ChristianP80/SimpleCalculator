using System;
namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }

        public Calculator()
        {
        }

        public double SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double SumInBetween()
        {
            double sum = 0;
            for (double i = FirstNumber; i <= SecondNumber; i++)
            {
                sum += i;
            }
            return sum;
        }

        public override string ToString()
        {
            string result =
                "First number: " + FirstNumber
                + "\n" + "Second number: " + SecondNumber
                + "\n" + "Number in memory: " + NumberInMemory;

            return result;
        }
    }
}
