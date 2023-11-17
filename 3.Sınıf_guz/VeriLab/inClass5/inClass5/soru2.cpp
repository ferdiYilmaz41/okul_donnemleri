#include<iostream>
#include<vector>
#include<time.h>

using namespace std;

void bubbleSort(vector<int>& arr)
{
	int i, j;
	for (i = 0; i < arr.size() - 1; i++)
	{

		for (j = 0; j < arr.size() - i - 1; j++)
			if (arr[j] > arr[j + 1])
				swap(arr[j], arr[j + 1]);
	}

}
void insertionSort(vector<int>& data, int n)
{
	int i, j, tmp;

	for (i = 1; i < n; i++)
	{
		j = i;
		tmp = data[i];
		while (j > 0 && tmp < data[j - 1])
		{
			data[j] = data[j - 1];
			j--;
		}
		data[j] = tmp;
	}
}
int main() {
	int n = 1;
	vector<int> v = { 20,15,5,10,1};
	cout << "Size of vector is:" << v.size() << endl;
	cout << "Vector elements are given below:" << endl;
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	cout << endl;
	cout << endl;

	int ins = 1;

	cout << "Enter the value for insertion:";
	cin >> ins;
	v.insert(v.begin(), ins);
	cout << "Added to begin of the array:" << endl;
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	cout << endl;


	cout << endl << "Enter the value for insertion: ";
	int ins2;
	cin >> ins2;
	v.insert(v.end(), ins2);
	cout << "Added to end of the array:" << endl;
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	cout << endl;
	vector<int> tmpv(v.size());
	tmpv = v;
	cout << endl << "Bubble sort..... "<<endl;
	cout  << "Sorted element list....." << endl;
	bubbleSort(v);
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	cout << endl;
	cout << endl << "Insertion sort..... " << endl;
	cout << "Sorted element list....." << endl;
	insertionSort(tmpv, tmpv.size());
	reverse(tmpv.begin(), tmpv.end());
	for (int i = 0; i < tmpv.size(); i++)
	{
		cout << tmpv[i] << "  ";
	}

	return 1;
}