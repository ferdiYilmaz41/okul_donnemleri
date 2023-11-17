#include<iostream>
#include<fstream>
#include<string>
const int MAXCHAR = 80;

using namespace std;
int BlobCount(int r, int c);
int main() {

	int row ;
	int col ;
	string satir = "";
	char blobArray[MAXCHAR][ MAXCHAR];

	ifstream myfile;
	myfile.open("blobs1.txt");
	
	if (myfile.is_open()) {

		getline(myfile, satir); 
		cout << satir << endl;
		

		myfile.close();
	}
	
	row = stoi(satir);
	col = stoi(satir);
	cout << row;


	



	return 0;
}
