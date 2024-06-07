namespace ABC_042_A;

class Program
{
    static void Main(string[] args)
    {
        int[] param = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(param);

        int sum = param.Sum();

        string result = "NO";
        if(sum == 17 && param[0] == 5 && param[1] == 5)
        {
            result = "YES";
        }
        Console.WriteLine(result);
    }
}
