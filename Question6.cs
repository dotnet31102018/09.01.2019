        private void Form1_Load(object sender, EventArgs e)
        {
            int[] a;
            a = new int[10];
            InitializeArrays();
            PrintArray();
        }

        private void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private void InitializeArrays()
        {
            Random r = new Random();
            a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
            }
        }