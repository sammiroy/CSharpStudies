namespace QuestionSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double exP; // 30% of mark
            double qP; // 45% of mark
            double assP;// 25% of mark also lmao

            Console.Write("Input exercises percentage: ");
            exP = double.Parse(Console.ReadLine()) * 0.3;
            Console.Write("Input quiz percentage: ");
            qP = double.Parse(Console.ReadLine()) * 0.45;
            Console.Write("Input assignment percentage: ");
            assP = double.Parse(Console.ReadLine()) * 0.25;

            Console.WriteLine($"Exercises: {Math.Round(exP / 0.3)}");
            Console.WriteLine($"Quizes: {Math.Round(qP/0.45)}");
            Console.WriteLine($"Assignment: {Math.Round(assP/0.25)}");
            Console.WriteLine($"Course: {Math.Round((exP) + (assP) + (qP))}");

        }
    }
}