#include<iostream>

using namespace std;

int main() {

	int n;
	int r;
	cout << "Enter an integer:";
	cin >> n;
	
	cout << endl << "Enter a range:";
	cin >> r;

	for (int i = 1; i <= r; i++)
	{
		cout << n << "*" << i << "=" << i * n << endl;
	}


	return 0;
}