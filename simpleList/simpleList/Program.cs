namespace simpleList;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        names.Add("Homer Simpson");
        names.Add("Lisa Simpson");
        names.Add("Bart Simpson");
        names.Add("Marge Simpson");
        names.Add("Marge Simpson");
        names.Add("Marge Simpson");

        // Elements can be accessed by index
        Console.WriteLine(names[2]);
        names[2] = "Ned Flanders";
        Console.WriteLine(names[2]);
        Console.WriteLine();

        // Remove data in the list by its content
        names.Remove("Ned Flanders");

        // Remove by index
        names.RemoveAt(1);

        // Find the index of a value 
        Console.WriteLine($"The index where marge is stored is: {names.IndexOf("Marge Simpson")}");

    }
}