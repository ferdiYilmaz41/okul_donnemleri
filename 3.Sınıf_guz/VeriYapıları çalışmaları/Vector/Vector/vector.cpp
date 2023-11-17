#include<iostream>
using namespace std;

template<class T>
class vector {
	T* data;
	int cap;
	int index;
	void growth() {
		if (size()>=capacity())
		{
			cap *= 2;
			T* tmp = new T[cap];
			for (int i = 0; i < size(); i++)
			{
				tmp[i] = data[i];
			}
			delete[] data;
			data = tmp;
		}

	}
public:
	vector() : data(NULL), index(0), cap(1) {
		data = new T[cap];
	}
	int size() { return index; }
	
	int capacity() { return cap; }

	void push_back(const T& value) {
		growth();
		data[index++] = value;
	}
	
	void pop_back() {
		index--;
	}

	bool isEmpty() {
		return size() == 0;
	}

	T front()const { 
		
		return data[0]; }
	T back()const { return data[index - 1]; }
	T* begin()const { return data; }
	T* end() { return data + size(); }
};
int main() {
	vector<int> v;

	
	v.push_back(19);
	v.push_back(31);
	
	int* end = v.end();
	cout<<v.begin()<<endl;
	cout << end;
	
	
	



	return 0;
}