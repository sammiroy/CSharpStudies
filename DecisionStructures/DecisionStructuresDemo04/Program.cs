namespace DecisionStructuresDemo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;

            Console.Write("What is your weight in pounds? ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("What is your height in inches? ");
            height = double.Parse(Console.ReadLine());

            bmi = 703 * weight / (Math.Pow(height, 2));

            if (bmi < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("norma");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("overweight");
            }else
            {
                Console.WriteLine("obese");
            }
        }
    }
}