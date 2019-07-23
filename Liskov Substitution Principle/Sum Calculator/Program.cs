using System;
using System.Linq;
using static System.Console;

namespace ConsoleApp
{
    public abstract class SumCalc
    {
        protected int[] _numbers;
        public SumCalc(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calc();
    }
    public class Sum : SumCalc
    {
        public Sum(int[] numbers) : base(numbers)
        {
            _numbers = numbers;
        }

        public override int Calc() => _numbers.Sum();
    }


    public class EvenSum : Sum
    {
        public EvenSum(int[] nums) : base(nums)
        {
        }

        public override int Calc() => _numbers.Where(n => n % 2 == 0).Sum();
    }

    public class OddSum : Sum
    {
        public OddSum(int[] nums) : base(nums)
        {
        }

        public override int Calc() => _numbers.Where(n => n % 2 != 0).Sum();

    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Even & Odd Numbers Sum from an array of Integers");

            int[] n = new int[] { 1, 2, 3, 4 };

            WriteLine();
            WriteLine($"Input Arrays: {String.Join(" ", n)}");

            
            Sum sum = new Sum(n);

            WriteLine();
            WriteLine($"Total Sum: { sum.Calc() }");

            sum = new EvenSum(n);
            WriteLine();
            WriteLine($"Total Even Numbers Sum: { sum.Calc() }");

            sum = new OddSum(n);
            WriteLine();
            WriteLine($"Total Odd Numbers Sum:  { sum.Calc() }");




        }
    }
}
