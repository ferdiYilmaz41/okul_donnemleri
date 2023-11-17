#include<iostream>

using namespace std;

int faktoriyel(int n) {
	int total = 1;
	if (n > 1)
	{
		for (int i = 1; i <= n; i++)
		{
			total *= i;
		}
	}
	return total;
}

int main() {

	int n;

	cout << "Enter a number:";
	cin >> n;

	cout << "Factorial of " << n << " is " << faktoriyel(n);


	return 0;
}