        static void Main(string[] args)
        {
            int[] a, b;
            InitializeArrays(a, b);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        private static void InitializeArrays(int[] a , int[] b)
        {
            Random r = new Random();
            a = new int[10];
            b = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
                b[i] = r.Next(101);
            }
        }