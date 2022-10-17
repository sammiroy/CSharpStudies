namespace StreamReaderDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sum = 0;
                int counter = 0;
                const string DataFilePath = @"..\..\..\marks.txt";
                using (StreamReader reader = new StreamReader(DataFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int currentNumber = int.Parse(line);
                        sum += currentNumber;
                        counter++;
                    }
                    // Compute the average
                    double avergae = sum / counter;
                    Console.WriteLine($"The average of the {counter} marks is {avergae:F1}");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}