#include<iostream>
#include<vector>
#include<time.h>
using namespace std;

int main() {
	int n = 1;
	vector<int> v = { 0,1,2,3,4 };
	cout << "Size of vector is:"<<v.size() << endl;
	cout << "Vector elements are giiven below:" << endl;
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	cout << endl;
	reverse(v.begin(), v.end());
	v.push_back(20);
	reverse(v.begin(), v.end());
	cout << "Size of vector is:" << v.size() << endl;
	cout << "Updated Vector elements are given below:" << endl;
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i]<<"  ";
	}

	
	reverse(v.begin(), v.end());
	
	cout << endl<<"Output of reverse array: ";
	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}
	reverse(v.begin(), v.end());
	v.pop_back();
	cout << endl << "Output of after remove last array element: ";

	for (int i = 0; i < v.size(); i++)
	{
		cout << v[i] << "  ";
	}



	return 1;
}