namespace Assignment7._1._1
{
    //You are a student who has recently taken an exam with your classmates.
    //However, the professor has not yet provided the students with a sorted list of exam scores.
    //To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm.
    //This way, you can obtain the sorted list of scores and see how you performed compared to your classmates.
    //Also, you choose selection sort since that is an easy way of implementation.
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize an array of grades
            int[] grades = { 100, 88, 92, 77, 80, 70 };

            //call the SelectionSort method to sort the grades
            SelectionSort(grades);

            //print the sorted grades
            Console.WriteLine("Sorted Grades:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        //define the SelectionSort mehthod to perform a selction sort to sor the grades from the array
        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                //find the index of the minimum element in the unsorted part of the array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //swap the found minimum element with the first element of the unsorted part
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
