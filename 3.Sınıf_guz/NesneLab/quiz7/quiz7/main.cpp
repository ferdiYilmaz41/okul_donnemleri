#include <iostream>
#include <time.h>
#include "ArrayHelper.h" // include the ArrayHelper header file

using namespace std;

template<class T>
T GenerateRandomNumber(int lowerBound, int upperBound, double scaler = 1)
{
	lowerBound *= scaler;
	upperBound *= scaler;
	T randomData = lowerBound + rand() % (upperBound - lowerBound + 1);
	randomData /= scaler;
	return randomData;
}

int main()
{
	srand(time(NULL));
	int minIndex, maxIndex;

	// Create an instance of ArrayHelper for integers
	ArrayHelper<int> IntegerArrayHelper;
	int IntegerArray1[10];
	for (size_t i = 0; i < 10; i++)
	{
		IntegerArray1[i] = GenerateRandomNumber<int>(-50, 50);
	}
	IntegerArrayHelper.Display(IntegerArray1, 10, 5, 4);
	IntegerArrayHelper.Sort(IntegerArray1, 10);
	IntegerArrayHelper.Display(IntegerArray1, 10, 5, 4);
	minIndex = IntegerArrayHelper.MinIndex(IntegerArray1, 10);
	maxIndex = IntegerArrayHelper.MaxIndex(IntegerArray1, 10);
	cout << "Min : " << IntegerArray1[minIndex] << endl;
	cout << "Max : " << IntegerArray1[maxIndex] << endl;
	int IntegerArray2[5];
	for (size_t i = 0; i < 5; i++)
	{
		IntegerArray2[i] = GenerateRandomNumber<int>(-50, 50);
	}
	IntegerArrayHelper.Display(IntegerArray2, 5, 5, 4);
	int* newArray = IntegerArrayHelper.Merge(IntegerArray1, 10, IntegerArray2, 5);
	IntegerArrayHelper.Display(newArray, 15, 5, 4);
	delete[] newArray;

	/* REPEAT SAME TEST FOR DOUBLE ARRAY */
	ArrayHelper<double> DoubleArrayHelper;
	double DoubleArray1[10];
	for (size_t i = 0; i < 10; i++)
	{
		DoubleArray1[i] = GenerateRandomNumber<double>(-50, 50, 1000);
	}
	DoubleArrayHelper.Display(DoubleArray1, 10, 5, 6);
	DoubleArrayHelper.Sort(DoubleArray1, 10);
	DoubleArrayHelper.Display(DoubleArray1, 10, 5, 6);
	minIndex = DoubleArrayHelper.MinIndex(DoubleArray1, 10);
	maxIndex = DoubleArrayHelper.MaxIndex(DoubleArray1, 10);
	cout << "Min : " << DoubleArray1[minIndex] << endl;
	cout << "Max : " << DoubleArray1[maxIndex] << endl;
	double DoubleArray2[5];
	for (size_t i = 0; i < 5; i++)
	{
		DoubleArray2[i] = GenerateRandomNumber<double>(-50, 50, 1000);
	}
	DoubleArrayHelper.Display(DoubleArray2, 5, 5, 6);
	double* newDoubleArray = DoubleArrayHelper.Merge(DoubleArray1, 10, DoubleArray2, 5);
	DoubleArrayHelper.Display(newDoubleArray, 15, 5, 6);
	delete[] newDoubleArray;

	return 0;
}

