#include<iostream>

using namespace std;

class StackNode {

public:
	int data;
	StackNode* next;
	StackNode(const int& data=0, StackNode* next=NULL):data(data),next(next){ }

};

class Stack {

	StackNode* root;
public:
	Stack():root(NULL){		}
	StackNode* begin()const { return root; }
	StackNode* end()const { return NULL; }
	bool isEmpty() {
		if (begin()==end())
		{
			return 1;
		}
		else
		{
			return 0;
		}
		
	}
	void push(const int& value) {
		StackNode* tmp = new StackNode(value, root);
		root = tmp;
	}
	void print() {
		StackNode* tmp =begin();
		while (tmp!=NULL)
		{
			cout << tmp->data << "  ";
			tmp=tmp->next;

		}
	}
	void pop() {
		if (isEmpty())
		{
			throw "Error!";

		}
		StackNode* tmp = root;
		root = tmp->next;
		delete tmp;

	}
	int top() {
		if (isEmpty())
		{
			throw "error!";
		}
		return begin()->data;
	}
};

int main() {
	Stack s;
	s.push(31);
	s.push(1);
	s.push(21);
	s.push(35);
	s.push(310);
	
	s.print();
	s.pop();
	cout << endl;
	s.print();
	cout << endl;
	cout<<s.top();
}