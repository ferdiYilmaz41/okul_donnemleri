#include<iostream>

using namespace std;

class Node {
public:
	Node(const int&data=0,Node* next=NULL){}
	int data;
	Node* next;
};

class list {
	Node* root;
public:
	list():root(NULL){}
	Node* begin()const {return root;	}
	Node* end()const {return NULL;}
	bool isEmpty()const  { return begin() == end(); }
	void pushBack(const int& value) {
		if (isEmpty()) {
			root = new Node(value);
		}
		else
		{
			Node* tmp = begin();
			while (tmp->next != end())
			{
				tmp = tmp->next;
			}
			tmp->next = new Node(value); 
		}
	}
	void print() {
		Node* tmp = begin();
		while (tmp!=end())
		{
			cout << tmp->data << " ";
			tmp = tmp->next;

		}

	}
};
int main() {





	return 0;
}