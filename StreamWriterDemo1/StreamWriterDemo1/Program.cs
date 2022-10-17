using System.IO;

namespace StreamWriterDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\..\marks.csv"))
                {
                    int mark = 0;


                    do
                    {
                        Console.Write("Enter a mark (0-100): ");
                        mark = int.Parse(Console.ReadLine());
                        if (mark >= 0 && mark <= 100)
                        {
                            writer.WriteLine(mark);
                        }
                    } while (mark >= 0 && mark <= 100);
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Error with exception {ex.Message}");
            }
        }
    }
}