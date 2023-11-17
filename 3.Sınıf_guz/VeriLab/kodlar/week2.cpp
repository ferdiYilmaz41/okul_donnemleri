// week2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

/* Computes 1+2+3+…+n */
int Sum(int n) {
    /* Base case */
    if (n == 1) return 1;

    /* Divide and conquer */
    int partialSum = Sum(n - 1);

    /* Merge */
    return partialSum + n;
} /* end-Sum */


/* Computes a^n */
double Power(double a, int n) {
    /* Base cases */
    if (n == 0) return 1;
    else if (n == 1) return a;

    return Power(a, n - 1) * a;
} /* end-Power */

/* Searches a key in A[0..N-1] */
int ForwardLinearSearch(int A[], int index, int N, int key) {
    /* Base cases */
    if (index == N) return -1; /* Unsuccessful search */
    if (key == A[index]) return index;   /* Success */

    /* Divide & Conquer & Merge */
    return ForwardLinearSearch(A, index + 1, N, key);
} // ForwardLinearSearch

/* Searches a key in A[0..N-1] */
int BackwardLinearSearch(int A[], int N, int key) {
    /* Base cases */
    if (N == 0) return -1; /* Unsuccessful search */
    if (key == A[N - 1]) return N - 1;   /* Success */

    /* Divide & Conquer & Merge */
    return BackwardLinearSearch(A, N - 1, key);
} // BackwardLinearSearch

/* Searches a key in sorted array A[index1..index2] */
int BinarySearch(int A[], int index1, int index2, int key) {
    /* Base case 1: No elements in the array */
    if (index1 > index2) return -1; /* Unsuccessful search */
    /* Compare the key with the middle element */
    int middle = (index1 + index2) / 2;
    if (key == A[middle]) return middle; /* Success */

    /* Conquer & Merge */
    else if (key < A[middle])
        return BinarySearch(A, index1, middle - 1, key);
    else
        return BinarySearch(A, middle + 1, index2, key);
} //end-BinarySearch

/* Computes nth Fibonacci number */
int Fibonacci(int n) {
    /* Base cases */
    if (n == 0) return 0;
    if (n == 1) return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
} /* end-Fibonacci */

/* Computes the super digit of “n” */
int superDigit(int n) {
    /* Base case */
    if (n < 10) return n;

    int digitSum = 0;
    while (n > 0) {
        digitSum += n % 10;
        n = n / 10;
} //end-while

    return superDigit(digitSum);
} /* end-superDigit */


int main()
{
#if 1    // Recursive Sum Test
    int x = Sum(4);
    cout << "Result: " << x << endl;
#endif

#if 0  // Recursive Power Test
    double x = Power(3, 4);
    cout << "Result: " << x << endl;
#endif

#if 0  // Recursive Forward Linear Search Test
    int A[] = { 9, 4, 10, 1, 20, 12, 3, 99, 65, 52, 25, 11, 91, 12, 62, 55 };
    int N = sizeof(A) / sizeof(int);  // 15 
    int index = ForwardLinearSearch(A, 0, N, 12);
    cout << "Result: " << index << endl;
#endif

#if 0  // Recursive Backward Linear Search Test
    int A[] = { 9, 4, 10, 1, 20, 12, 3, 99, 65, 52, 25, 11, 91, 12, 62, 55 };
    int N = sizeof(A) / sizeof(int);  // 15 
    int index = BackwardLinearSearch(A, N, 12);
    cout << "Result: " << index << endl;
#endif

#if 0  // Recursive Binary Search Test
    int A[] = { 1, 4, 5, 6, 10, 12, 13, 17, 25, 30, 32, 33, 50, 54, 55, 58 };
    int N = sizeof(A) / sizeof(int);  // 15 
    int index = BinarySearch(A, 0, N, 12);
    cout << "Result: " << index << endl;
#endif

#if 0  // Recursive Fibonacci Test
    double fb = Fibonacci(15);
    cout << "Result: " << fb << endl;
#endif

#if 0 // Recursive Super Digit Test
    double sd = superDigit(3434);
    cout << "Result: " << sd << endl;
#endif
    
    system("pause");
    return 0;

}

