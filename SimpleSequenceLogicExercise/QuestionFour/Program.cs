namespace QuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init & assign user variable
            int uNum;

            Console.Write("Enter a number:");
            uNum = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                    Console.WriteLine($"{uNum} x {i} = {uNum * i}");
            }
        }
    }
}