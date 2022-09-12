namespace ChangeCaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            char likeProgramming;

            //string
            Console.Write("What is your name? ");
            yourName = Console.ReadLine();

            Console.WriteLine($"Your name in lowercase is {yourName.ToLower()} and your name in upper case is {yourName.ToUpper()} and your name as you typed it is {yourName}");

            // char case
            Console.Write("Do you like programming? ");
            likeProgramming = char.Parse(Console.ReadLine());

            Console.WriteLine($"Your answer in lowercase is {char.ToLower(likeProgramming)} and your answer in uppercase is {char.ToUpper(likeProgramming)} and your answer as typed is {likeProgramming}");

        }
    }
}