using System;

namespace Program
{
    class B
    {
        public static void Main(string[] args)
        {
            string[,] a = new string[10, 10];
            char[] x = new char[10];
            int[] t = new int[10];
            string[] g = new string[10];
            string b;
            Console.WriteLine("Enter Rows: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Columns: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Console.ReadLine();
                }
            }

            int k = 0, c = 0, s = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b = a[i, j];
                    c = 0;

                    for (k = 0; k < b.Length; k++)
                    {
                        if (b[k] == 'a' || b[k] == 'e' || b[k] == 'i' || b[k] == 'o' || b[k] == 'u')
                        {
                            c++;
                        }
                    }

                    g[s] = b;
                    t[s] = c;
                    s++;
                }
            }

            int temp;
            string tem;
            for (int j = 0; j < s; j++)
            {
                for (int i = 0; i < s; i++)
                {
                    if (t[i] >= t[j])
                    {
                        temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                        tem = g[i];
                        g[i] = g[j];
                        g[j] = tem;
                    }
                }
            }

            Console.WriteLine("Strings having more numbers of vowels are: ");
            for (int i = 0; i < s; i++)
            {
                if (t[i] == t[s - 1])
                {
                    Console.WriteLine(g[i]);
                }
            }

            Console.WriteLine("Word has " + t[s - 1] + " Vowels");
            Console.ReadKey();
        }
    }
}
