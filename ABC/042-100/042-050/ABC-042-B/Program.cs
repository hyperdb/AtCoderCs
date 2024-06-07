namespace ABC_042_B;

class Program
{
    static void Main(string[] args)
    {
        int[] param = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string[] data = new string[param[0]];
        for(int i = 0; i < param[0]; i++)
        {
            data[i] = Console.ReadLine();
        }

        Array.Sort(data);

        string result = "";
        for(int i = 0; i < param[0]; i++)
        {
            result += data[i];
        }
        Console.WriteLine(result);
    }
}
