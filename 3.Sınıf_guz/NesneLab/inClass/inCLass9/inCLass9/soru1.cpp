#include<iostream>
#include<queue>

using namespace std;

class Stack {
private:

	queue<int> q1, q2;

public:

	void push(int x)
	{
		q2.push(x);

		
		while (!q1.empty()) {
			q2.push(q1.front());
			q1.pop();
		}

		queue<int> q = q1;
		q1 = q2;
		q2 = q;
	}

	void pop()
	{
		
		if (q1.empty())
			return;
		q1.pop();
	}

	int top()
	{
		if (q1.empty())
			return -1;
		return q1.front();
	}

	int size() { return q1.size(); }

	bool empty() {
		if (q1.empty())
		{
			return true;
		}
		else
			return false;

	}

	void display() {
		queue<int> q3 = q1;
		/*while (!q1.empty())
		{
			q2.push(q1.front());
			q1.pop();
		}*/
		while (!q3.empty()) {
			cout << q3.front()<<" ";
			q3.pop();
		}
	}


};


int main() {
	int n = 10;
	Stack st;
	int x = 0;
	while (n!=0)
	{
		cout<<"Created a stack"<<endl
			<< "1 to push() " << endl
			<< "2 to pop()" << endl
			<< "3 to empty()" << endl
			<< "4 to top()" << endl
			<< "5 to size()" << endl
			<< "6 to display()" << endl
			<< "0 to exit" << endl;

		cin >> n;
		switch (n)
		{
		case 1:
			cout << " Enter a number to push:" << endl;
			
			cin >> x;
			st.push(x);
			break;
		case 2:
			st.pop();
			break;
		case 3:
			if (st.empty()==1)
			{
				cout << "Stack is empty"<<endl;
			}
			else
			{
				cout << "Stack is not empty" << endl;
			}
			break;
		case 4:
			cout << "Top element of the stack is:" << st.top()<<endl;
			break;
		case 5:
			cout << "Size of the stack is:" << st.size() << endl;
			break;
		case 6:
			cout << "Elements of the stack:";
			st.display() ;
			break;
		case 0:
			break;
		default:
			break;
		}

	}


}