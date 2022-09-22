namespace LoopProblems3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userVal;
            string userValString;
            int uLengthVal;
            int modVal = 1;
            int loopCount = 0;

            Console.Write("Enter integer: ");
            userVal = int.Parse(Console.ReadLine());
            userValString = $"{userVal}";
            uLengthVal = userValString.Length;  

            while(uLengthVal >= loopCount)
            {
                modVal *= 10;
                loopCount++;
                if (modVal == )
                {

                }

                    Console.WriteLine(userVal % modVal);
            }
       

        }
    }
}