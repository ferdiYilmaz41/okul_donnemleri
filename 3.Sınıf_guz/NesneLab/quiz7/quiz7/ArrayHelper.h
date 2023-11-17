#include <iostream>
#include <algorithm> // for std::sort
#include <iomanip>

template <typename T>
class ArrayHelper {
public:
	ArrayHelper() {} // default constructor

	// Display the given array according to the 3rd and 4th arguments
	void Display(T* array, int size, int numberOfElementsInOneLine, int oneElementLength) {
		for (int i = 0; i < size; i++) {
			std::cout << std::setw(oneElementLength) << array[i]<<" ";
			if ((i + 1) % numberOfElementsInOneLine == 0) {
				std::cout << std::endl;
			}
		}
	}

	// Find the maximum element and return its index
	int MaxIndex(T* array, int size) {
		int maxIndex = 0;
		for (int i = 1; i < size; i++) {
			if (array[i] > array[maxIndex]) {
				maxIndex = i;
			}
		}
		return maxIndex;
	}

	// Merge the given arrays and return a new array containing the merged elements
	// Find the minimum element and return its index
	int MinIndex(T* array, int size) {
		int minIndex = 0;
		for (int i = 1; i < size; i++) {
			if (array[i] < array[minIndex]) {
				minIndex = i;
			}
		}
		return minIndex;
	}

	// Merge the given arrays and return a new array containing the merged elements
	T* Merge(T* firstArray, int firstArraySize, T* secondArray, int secondArraySize) {
		int newArraySize = firstArraySize + secondArraySize;
		T* newArray = new T[newArraySize];
		for (int i = 0; i < firstArraySize; i++) {
			newArray[i] = firstArray[i];
		}
		for (int i = 0; i < secondArraySize; i++) {
			newArray[i + firstArraySize] = secondArray[i];
		}
		return newArray;
	}

	// Sort the given array in ascending order
	void Sort(T* array, int size) {
		std::sort(array, array + size);
	}

	// Swap the given elements
	void Swap(T& operand1, T& operand2) {
		T temp = operand1;
		operand1 = operand2;
		operand2 = temp;
	}

	~ArrayHelper() {} // destructor
};