using System;

namespace SortingAlgorithmsCompared {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Cases cases = new Cases();

            int[] originalVectorBestCase = new int[n];
            int[] originalVectorMediumCase = new int[n];
            int[] originalVectorWorstCase = new int[n];

            originalVectorBestCase = cases.BestCase(n);
            originalVectorMediumCase = cases.MediumCase(n);
            originalVectorWorstCase = cases.WorstCase(n);

            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms();

            int[] orderedVectorBestCase = new int[n];
            int[] orderedVectorMediumCase = new int[n];
            int[] orderedVectorWorstCase = new int[n];

            int option;

            do {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Options Menu");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1 - Bubble Sort");
                Console.WriteLine("2 - Insertion Sort");
                Console.WriteLine("3 - Quick Sort");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.Write("Choose the sorting algorithm according to the option number: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (option == 1) {
                    Console.WriteLine("Bubble Sort with " + n + " elements:");
                    Console.WriteLine();

                    DateTime d1 = DateTime.Now;
                    orderedVectorBestCase = sortingAlgorithms.BubbleSort(originalVectorBestCase);
                    DateTime d2 = DateTime.Now;
                    TimeSpan timeIntervalBestCase = d2 - d1;
                    Console.WriteLine("Runtime to order the Best Case vector: " + timeIntervalBestCase.ToString());

                    DateTime d3 = DateTime.Now;
                    orderedVectorMediumCase = sortingAlgorithms.BubbleSort(originalVectorMediumCase);
                    DateTime d4 = DateTime.Now;
                    TimeSpan timeIntervalMediumCase = d4 - d3;
                    Console.WriteLine("Runtime to order the Medium Case vector: " + timeIntervalMediumCase.ToString());

                    DateTime d5 = DateTime.Now;
                    orderedVectorWorstCase = sortingAlgorithms.BubbleSort(originalVectorWorstCase);
                    DateTime d6 = DateTime.Now;
                    TimeSpan timeIntervalWorstCase = d6 - d5;
                    Console.WriteLine("Runtime to order the Worst Case vector: " + timeIntervalWorstCase.ToString());
                }
                else if (option == 2) {
                    Console.WriteLine("Insertion Sort with " + n + " elements:");
                    Console.WriteLine();

                    DateTime d1 = DateTime.Now;
                    orderedVectorBestCase = sortingAlgorithms.InsertionSort(originalVectorBestCase);
                    DateTime d2 = DateTime.Now;
                    TimeSpan timeIntervalBestCase = d2 - d1;
                    Console.WriteLine("Runtime to order the Best Case vector: " + timeIntervalBestCase.ToString());

                    DateTime d3 = DateTime.Now;
                    orderedVectorMediumCase = sortingAlgorithms.InsertionSort(originalVectorMediumCase);
                    DateTime d4 = DateTime.Now;
                    TimeSpan timeIntervalMediumCase = d4 - d3;
                    Console.WriteLine("Runtime to order the Medium Case vector: " + timeIntervalMediumCase.ToString());

                    DateTime d5 = DateTime.Now;
                    orderedVectorWorstCase = sortingAlgorithms.InsertionSort(originalVectorWorstCase);
                    DateTime d6 = DateTime.Now;
                    TimeSpan timeIntervalWorstCase = d6 - d5;
                    Console.WriteLine("Runtime to order the Worst Case vector: " + timeIntervalWorstCase.ToString());
                }
                else if (option == 3) {
                    Console.WriteLine("Quick Sort with " + n + " elements:");
                    Console.WriteLine();

                    DateTime d1 = DateTime.Now;
                    orderedVectorBestCase = sortingAlgorithms.QuickSort(originalVectorBestCase, 0, n);
                    DateTime d2 = DateTime.Now;
                    TimeSpan timeIntervalBestCase = d2 - d1;
                    Console.WriteLine("Runtime to order the Best Case vector: " + timeIntervalBestCase.ToString());

                    DateTime d3 = DateTime.Now;
                    orderedVectorMediumCase = sortingAlgorithms.QuickSort(originalVectorMediumCase, 0, n);
                    DateTime d4 = DateTime.Now;
                    TimeSpan timeIntervalMediumCase = d4 - d3;
                    Console.WriteLine("Runtime to order the Medium Case vector: " + timeIntervalMediumCase.ToString());

                    DateTime d5 = DateTime.Now;
                    orderedVectorWorstCase = sortingAlgorithms.QuickSort(originalVectorWorstCase, 0, n);
                    DateTime d6 = DateTime.Now;
                    TimeSpan timeIntervalWorstCase = d6 - d5;
                    Console.WriteLine("Runtime to order the Worst Case vctor: " + timeIntervalWorstCase.ToString());
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Invalid operation. Enter an existing numeric option.");
                }
            } while (option > 3 || option < 1);

        }
    }
}