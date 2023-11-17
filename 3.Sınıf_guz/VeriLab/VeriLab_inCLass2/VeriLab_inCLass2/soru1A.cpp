#include<iostream>

using namespace std;

int faktoriyel(int n) {
	if (n > 1)
	{
		return n * faktoriyel(n - 1);

	}
	else
		return 1;
}

int main() {

	int n;

	cout << "Enter a number:";
	cin >> n;

	cout << "Factorial of " << n <<" is "<< faktoriyel(n);


	return 0;
}