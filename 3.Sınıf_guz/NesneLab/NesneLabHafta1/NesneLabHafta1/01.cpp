#include<iostream>
#include<time.h>
#include<iomanip>
#include<ctime>

using namespace std;

int main() {
	//int data_size=1;
	//int min=0;
	//int max=0;
	//
	////const char* array = new char[data_size];

	//cout << "ENTER THE DATA SIZE:";
	//cin >> data_size;

	//
	//cout << endl << "ENTER THE MINIMUM NUMBER:";
	//cin >> min;

	//cout << endl << "ENTER THE MAXIMUM NUMBER:";
	//cin >> max;

	//int *myArray = new int[data_size];
	srand(time(0));
	//for (size_t i = 0; i < data_size; i++)
	//{
	//	myArray[i] = rand() % (max - min + 1) + min;

	//}

	//cout << "DATA ARRAY:" << endl;

	//for (int x = 0; x < data_size; x++)
	//{
	//	cout << myArray[x]<<endl;
	//}

	//cout << "MEAN:" ;
	//int sum = 0;
	//for (int a = 0; a < data_size; a++)
	//{
	//	sum += myArray[a];
	//}
	//int mean = sum / data_size;
	//cout << mean << endl;

	//cout << "STANDARD DEVIATION:";
	//double standard_deviation;
	//double temp_sapma=0;
	//for (int b = 0; b < data_size; b++)
	//{
	//	temp_sapma+=(myArray[b] - mean)^2;
	//}
	//standard_deviation = temp_sapma / (data_size - 1);

	//cout << standard_deviation<<endl;

	//double variance = standard_deviation * standard_deviation;
	//cout << "VARIANCE:"<<variance<<endl;

	//cout << "EXECUTION FINISHED SUCCESFULLY";
	//float r = 5 + static_cast<float>(rand()) * static_cast<float>(20 - 5) / RAND_MAX;
	//double f = (double)rand() / RAND_MAX;
	//return 5 + f * (20 - 5);
	////cout.precision(4);
	//cout << f;

	double random = double(rand()) / (double(RAND_MAX) + 1.0);
	int r= rand() % (19 - 5 + 1) + 5;
	random += r;
	cout << random;
}

