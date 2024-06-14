namespace ABC_042_A;

class Program
{
    static void Main(string[] args)
    {
        int[] param = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(param);

        string result = "NO";
        if(param.SequenceEqual(new int[] { 5, 5, 7 }))
        {
            result = "YES";
        }
        Console.WriteLine(result);
    }
}
