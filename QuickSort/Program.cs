namespace QuickSort
{
    class Program
    {
        static int Partition(int[] data, int start, int end)
        {
            int pivot = data[start], left = start + 1, right = end, temp;
            bool done = false;

            while (!done)
            {
                while (left <= right && data[left] <= pivot) { left += 1; }
                while (data[right] >= pivot && right >= left) { right -= 1; }
                
                if (right < left) { done = true; }
                else
                {
                    temp = data[left];
                    data[left] = data[right];
                    data[right] = temp;
                }
                Animate(data);
            }
            temp = data[start];
            data[start] = data[right];
            data[right] = temp;
            Animate(data);
            return right;
        }
        static int[] QuickSort(int[] data, int start, int end)
        {
            int pivot;
            if (start < end)
            {
                pivot = Partition(data, start, end);
                QuickSort(data, start, pivot - 1);
                QuickSort(data, pivot + 1, end);
            }
            return data;
        }
        static void Animate(int[] data)
        {
            Console.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                int barLength = data[i];
                string bar = new string('▀', barLength);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(bar.PadRight(100));
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(100);
        }
        static void AnimationComplete(int[] data)
        {
            Console.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                int barLength = data[i];
                string bar = new string('▀', barLength);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(bar.PadRight(100));
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(500);
        }
        static void Main()
        {
            const int listlength = 25;
            int[] data = new int[listlength];
            int[] dataUnsorted = new int[listlength];
            Random num = new Random();

            for (int i = 0; i < listlength; i++)
            {
                data[i] = num.Next(1, 100);
                dataUnsorted[i] = num.Next(1, 100);
            }

            data = QuickSort(data, 0, listlength - 1);
            AnimationComplete(data);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-\t[COMPLETE]");
            Console.ResetColor();
            Console.WriteLine(); Console.Write("UNSORTED LIST\t->\t[");
            for (int i = 0; i < listlength; i++)
            {
                Console.Write($" {dataUnsorted[i]} ");
            }
            Console.Write("]\n");
            Console.Write("SORTED LIST\t->\t[");
            for (int i = 0; i < listlength; i++)
            {
                Console.Write($" {data[i]} ");
            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}