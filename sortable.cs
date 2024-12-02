using System;
using SortingLibrary;
namespace SortingLibrary
{
    public interface Sortable
    {
        void Sort(int[] array, bool ascending = true); // اضافه کردن پارامتر برای مرتب‌سازی صعودی یا نزولی
    }

    public class MergeSort : Sortable
    {
        public void Sort(int[] array, bool ascending = true)
        {
            MergeSortAlgorithm(array, ascending);
        }

        private void MergeSortAlgorithm(int[] array, bool ascending)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSortAlgorithm(left, ascending);
            MergeSortAlgorithm(right, ascending);

            Merge(array, left, right, ascending);
        }

        private void Merge(int[] array, int[] left, int[] right, bool ascending)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (ascending ? left[i] <= right[j] : left[i] >= right[j])
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }

            while (i < left.Length)
                array[k++] = left[i++];

            while (j < right.Length)
                array[k++] = right[j++];
        }
    }

    public class SelectionSort : Sortable
    {
        public void Sort(int[] array, bool ascending = true)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int targetIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (ascending ? array[j] < array[targetIndex] : array[j] > array[targetIndex])
                        targetIndex = j;
                }

                // Swap
                int temp = array[i];
                array[i] = array[targetIndex];
                array[targetIndex] = temp;
            }
        }
    }

    public class BubbleSort : Sortable
    {
        public void Sort(int[] array, bool ascending = true)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (ascending ? array[j] > array[j + 1] : array[j] < array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

    public class InsertionSort : Sortable
    {
        public void Sort(int[] array, bool ascending = true)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && (ascending ? array[j] > key : array[j] < key))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // نمونه داده برای مرتب‌سازی
            int[] array = {22,834, 54,912, 98,413, 18,562, 23,991, 61,587, 27,301, 15,245, 43,598, 89,741, 37,269, 14,863, 65,928, 57,312, 13,584, 91,400, 72,048, 25,976, 30,365, 61,945, 88,155, 11,287, 40,236, 72,589, 62,759, 47,111, 81,832, 53,465, 92,303, 10,756, 34,249, 19,238, 14,827, 38,045, 16,192, 77,063, 94,273, 57,489, 26,510, 83,914, 48,641, 95,320, 32,704, 46,907, 24,559, 56,110, 18,904, 70,126, 73,334, 41,589, 62,191
};

            // منوی انتخاب الگوریتم مرتب‌سازی
            Console.WriteLine("Choose sorting algorithm:");
            Console.WriteLine("1. Merge Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Bubble Sort");
            Console.WriteLine("4. Insertion Sort");

            int choice = int.Parse(Console.ReadLine());

            // منوی انتخاب ترتیب مرتب‌سازی
            Console.WriteLine("Choose sorting order:");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");

            bool ascending = Console.ReadLine() == "1"; // صعودی یا نزولی بودن

            // انتخاب الگوریتم مرتب‌سازی براساس انتخاب کاربر
            Sortable sorter = choice switch
            {
                1 => new MergeSort(),
                2 => new SelectionSort(),
                3 => new BubbleSort(),
                4 => new InsertionSort(),
                _ => throw new ArgumentException("Invalid choice!")
            };

            // نمایش آرایه قبل از مرتب‌سازی
            Console.WriteLine("Original array: " + string.Join(", ", array));

            // مرتب‌سازی آرایه بر اساس انتخاب کاربر
            sorter.Sort(array, ascending);

            // نمایش آرایه مرتب‌شده
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }
    }
}
