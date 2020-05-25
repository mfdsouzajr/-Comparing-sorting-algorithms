namespace SortingAlgorithmsCompared {
    class SortingAlgorithms {

        public int[] BubbleSort(int[] vector) {
            for (int i = vector.Length - 1; i >= 1; i--) {
                for (int j = 0; j < i; j++) {
                    if (vector[j] > vector[j + 1]) {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }

            return vector;
        }

        public int[] InsertionSort(int[] vector) {
            for (int i = 0; i < vector.Length - 1; i++) {
                for (int j = i + 1; j > 0; j--) {
                    if (vector[j - 1] > vector[j]) {
                        int aux = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            return vector;
        }

        public int[] QuickSort(int[] vector, int begin, int end) {
            int i, j, pivot, aux;
            i = begin;
            j = end - 1;
            pivot = vector[(begin + end) / 2];

            while (i <= j) {
                while (vector[i] < pivot && i < end) {
                    i++;
                }
                while (vector[j] > pivot && j > begin) {
                    j--;
                }
                if (i <= j) {
                    aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;
                    i++;
                    j--;
                }
            }

            if (j > begin) {
                QuickSort(vector, begin, j + 1);
            }
            if (i < end) {
                QuickSort(vector, i, end);
            }

            return vector;
        }
    }
}