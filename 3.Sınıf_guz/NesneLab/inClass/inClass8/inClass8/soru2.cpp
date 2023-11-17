#include<iostream>
#include<queue>
#include<stack>
#include<stdlib.h>
#include<string>
using namespace std;



int main() {

	stack<char> st1;
	string kelime = "";
	cout << "STACK KULLANIM" << endl;
	cout << "Bir ifade giriniz:";
	cin >> kelime;
	for (int i = 0; i < kelime.size(); i++)
	{
		st1.push(kelime[i]);
	}
	string pKelime = "";
	while (1)
	{
		if (st1.empty()==0)
		{
			char a = ' ';
			a=st1.top();
			pKelime += a;
			st1.pop();
		}
		else
		{
			break;
		}
	}

	if (kelime==pKelime)
	{
		cout << "Ifade bir Palindrom. ";
	}
	else
	{
		cout<<"Ifade bir palindrom degil.";
	}

	cout <<endl<< "QUEUE KULLANIM" << endl;
	queue<char> kuyruk1;
	queue<char> kuyruk2;
	string s1="";
	cout << "Bir ifade giriniz:";
	cin >> s1;
	string s2 = "";
	for (int i = s1.size(); i >=0; i--)
	{
		kuyruk1.push(s1[i]);
	}
	while (1)
	{
		if (kuyruk1.empty() == 0)
		{
			char b = ' ';
			b = kuyruk1.front();
			s2 += b;
			kuyruk1.pop();
		}
		else
		{
			break;
		}
	}
	int index = 0;
	for (int j = 0; j < s1.size(); j++)
	{
		if (s1[j] == s2[j])
		{
			index = 1;
			continue;
		}
		else
		{
			index = 0;
			cout << "Ifade palindrom degil";
		}
	}
	if (index==1)
	{
		cout << "Ifade palindrom";
	}
}