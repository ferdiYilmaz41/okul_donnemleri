#include<iostream>

using namespace std;

int main() {

	int n;
	cout << "Enter an integer:";
	cin >> n;

	for (int i = 1; i < 11; i++)
	{
		cout << n << "*" << i << "=" << i * n << endl;
	}


	return 0;
}