using System;

class Random_num
{
    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[6];

        int index = 0;

        while (index < 6)
        {
            int r = rand.Next(1, 46);

            if (!Is_arr(arr, r))
            {
                arr[index] = r;
                index++;
                Console.WriteLine(r);
            }
        }
    }

    static bool Is_arr(int[] arr, int value)
    {
        foreach (int item in arr)
        {
            if (item == value)
            {
                return true;
            }
        }
        return false;
    }
}
