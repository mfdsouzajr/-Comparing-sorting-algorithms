using System;

namespace SortingAlgorithmsCompared {
    class Cases {

        // This method will create a random vector containing positive integers in ascending order.
        public int[] BestCase(int sizeVector) {
            int[] originalVector = new int[sizeVector];

            Random random = new Random();
            Console.WriteLine("Best Case vector:");

            for (int i = 0; i < sizeVector; i++) {
                originalVector[i] = random.Next(1, sizeVector + 1);
            }

            int aux = 0;

            for (int i = 0; i < originalVector.Length; i++) {
                for (int j = 0; j < originalVector.Length; j++) {
                    if (originalVector[i] < originalVector[j]) {
                        aux = originalVector[i];
                        originalVector[i] = originalVector[j];
                        originalVector[j] = aux;
                    }
                }
            }

            for (int i = 0; i < originalVector.Length; i++) {
                if ((i + 1) == originalVector.Length) {
                    Console.Write(originalVector[i] + ".");
                }
                else {
                    Console.Write(originalVector[i] + ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            return originalVector;
        }

        // This method will create a random vector containing positive integers in scrambled order.
        public int[] MediumCase(int sizeVector) {
            int[] originalVector = new int[sizeVector];

            Random random = new Random();
            Console.WriteLine("Medium Case vector:");

            for (int i = 0; i < originalVector.Length; i++) {
                originalVector[i] = random.Next(1, sizeVector + 1);

                if ((i + 1) == originalVector.Length) {
                    Console.Write(originalVector[i] + ".");
                }
                else {
                    Console.Write(originalVector[i] + ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            return originalVector;
        }

        //This method will create a random vector containing positive integers in decreasing order.
        public int[] WorstCase(int sizeVector) {
            int[] originalVector = new int[sizeVector];

            Random random = new Random();
            Console.WriteLine("Worst Case vector:");

            for (int i = 0; i < sizeVector; i++) {
                originalVector[i] = random.Next(1, sizeVector + 1);
            }

            int aux = 0;

            for (int i = 0; i < originalVector.Length; i++) {
                for (int j = 0; j < originalVector.Length; j++) {
                    if (originalVector[i] > originalVector[j]) {
                        aux = originalVector[i];
                        originalVector[i] = originalVector[j];
                        originalVector[j] = aux;
                    }
                }
            }

            for (int i = 0; i < originalVector.Length; i++) {
                if ((i + 1) == originalVector.Length) {
                    Console.Write(originalVector[i] + ".");
                }
                else {
                    Console.Write(originalVector[i] + ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            return originalVector;
        }
    }
}