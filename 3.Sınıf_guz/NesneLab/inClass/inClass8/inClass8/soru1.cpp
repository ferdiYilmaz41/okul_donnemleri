#include<iostream>
#include<queue>
#include<stdlib.h>
using namespace std;



int main() {
	int count = 0;
	queue<int> kuyruk;
	int n=100;
	int size = 5;
	int a;
	queue<int> tmp;
	while (n!=0) {
		cout << endl << "What operation do you want to perform? Enter 0 to exit." << endl;
		cout << "1. Enqueue()"
			<< endl << "2. Dequeue()"
			<< endl << "3. IsEmpty()"
			<< endl << "4. IsFull()"
			<< endl << "5. Count()"
			<< endl << "6. Display()"
			<< endl << "7. Clear Screen"			<< endl;
		 n = 0;
		
		cin >> n;
		switch (n)
		{
		case 0:
			break;
		case 1:
			cout << "Enqueue islemi";
			if (kuyruk.size()>4)
			{
				cout <<endl<< "Kuyruk dolu, ekleme islemi yapamazsiniz!";
			}
			else
			{
				cout << endl << "Kuyruga eklenecek sayiyi giriniz:"
					<< endl;
				a = 0;
				cin >> a;
				kuyruk.push(a);
				count++;
			}
			
			break;
		case 2:
			cout << "Dequeue islemi" << endl << "Kuyruga eklenecek sayiyi giriniz:" 
				<< endl;
			kuyruk.pop();
			count--;
			break;
		case 3:
			cout << "Bos mu islemi" << endl;
			if (kuyruk.empty())
			{
				cout << "Kuyruk bos.";
			}
			else
			{
				cout << "Kuyruk bos degil.";
			}
			break;
		case 4:
			if (kuyruk.size() == size) {
				cout << "Kuyruk ful dolu."<<endl;
			}
			else
			{
				cout << "Kuyruk ful dolu degil"<<endl;
			}
			break;
		case 5:
			cout << "Kuyruk icindeki sayi sayisi:" << count << endl;
			break;
		case 6:
			
			tmp = kuyruk;
			while (1)
			{
				if (tmp.empty()==0)
				{
					cout << tmp.front() << endl;
					tmp.pop();
				}
				else
				{
					break;
				}
				
			}
			break;
		case 7:
			system("cls");
			break;
		default:
			break;
		}
		if (n==0)
		{
			break;
		}
	}

}


