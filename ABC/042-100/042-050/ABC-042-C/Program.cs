namespace ABC_042_C;

class Program
{
    static void Main(string[] args)
    {
        int[] param = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = param[0];
        while(n < 100000)
        {
            int m;
            int d = n;
            bool r = true;

            while(d > 0)
            {
                m = d % 10;
                if(data.Contains(m))
                {
                    r = false;
                    break;
                }
                d = d / 10;
            }

            if(r)
            {
                Console.WriteLine(n);
                break;
            }
            n += 1;
        }

    }
}
