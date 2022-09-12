namespace QuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"{num1} + {num2} = {num1 + num2}\n" +
                $"{num1} - {num2} = {num1 - num2}\n" +
                $"{num1} x {num2} = {num1 * num2}\n" +
                $"{num1} / {num2} = {num1 / num2}\n" +
                $"{num1} mod {num2} = {num1 % num2}");
        }
    }
}