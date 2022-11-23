namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movieTitle = new string[5];
            int[] rating = new int[5];
            double[] watchTime = new double[5];

            movieTitle[0] = "Star Wars";
            rating[0] = 5;
            watchTime[0] = 130.5;

            movieTitle[1] = "Raiders of the lost ark";
            rating[1] = 5;
            watchTime[1] = 140;

            // Loop through and display all the movies, one line per movie

            for (int i = 0; i < movieTitle.Length; i++)
            {
                Console.WriteLine($"{movieTitle[i]}, is {watchTime[i]} minutes long and has a rating of {rating[i]} stars.");
            }
        }
    }
}