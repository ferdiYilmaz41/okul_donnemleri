#include<iostream>
#include<iterator>
#include<list>
#include<vector>

using namespace std;

int main() {

	int n=10;

	
	cout << "VEKTOR ICIN ADRESLER:" << endl;

	vector<int> intvector(n);
	vector<char> charvector(n);
	vector<double> doublevector(n);

	for (int i = 0; i < n; i++)
	{
		intvector[i] = i + 1;

	}
	cout << "int turundeki bir vektorun adresleri asagıdaki gibidir:" << endl;
	for (int a = 0; a < (int)intvector.size(); a++)
	{
		cout << &intvector[a]<<endl;
	}

	for (int i = 0; i < n; i++)
	{
		charvector[i] = i + 1;

	}
	cout << "char turundeki bir vektorun adresleri asagıdaki gibidir:" << endl;
	for (int a = 0; a < (int)intvector.size(); a++)
	{
		cout << (void*)&charvector[a] << endl;
	}

	for (int i = 0; i < n; i++)
	{
		doublevector[i] = i + 1;

	}
	cout << "double turundeki bir vektorun adresleri asagıdaki gibidir:" << endl;
	for (int a = 0; a < (int)doublevector.size(); a++)
	{
		cout << &doublevector[a] << endl;
	}

	cout << "LINKEDLIST int ICIN ADRESLER:" << endl;

	list<int> intlist = { 5,6,7,8,9 };
	list<int>::iterator it;
	for (it = intlist.begin(); it != intlist.end(); ++it)
		cout << endl << &(*it);
	cout <<endl<< "LINKEDLIST char ICIN ADRESLER:" << endl;

	list<char> charlist = { 'a','b','c','d','e' };
	list<char>::iterator ik;
	for (ik = charlist.begin(); ik != charlist.end(); ++ik)
		cout << endl <<(void*)(&(*ik));
	
	return 0;
}