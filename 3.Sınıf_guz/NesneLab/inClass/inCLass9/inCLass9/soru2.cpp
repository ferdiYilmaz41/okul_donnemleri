#include<iostream>
#include<queue>
#include<stack>
using namespace std;
class Queue {
private:
	stack<int> s1, s2;
public:
	void enQueue(int x)
	{
		while (!s1.empty()) {
			s2.push(s1.top());
			s1.pop();
		}

		s1.push(x);

		while (!s2.empty()) {
			s1.push(s2.top());
			s2.pop();
		}
	}

	int deQueue()
	{
		if (s1.empty()) {
			cout << "Q is Empty";
			exit(0);
		}

		
		int x = s1.top();
		s1.pop();
		return x;
	}

	bool empty() {
		if (s1.empty()==1)
		{
			return true;
		}
		else
			return false;
	}
	int size() {
		return s1.size();
	}
	int front() {
		if (s1.empty())
			return -1;
		return s1.top();
	}
	void display() {
		stack<int> tmp ;
		stack<int> tmp2=s1;
		while (!tmp2.empty())
		{
			tmp.push(tmp2.top());
			tmp2.pop();
		}
		while (!tmp.empty())
		{
			cout<<tmp.top()<<" ";
			tmp.pop();
		}

	}
};



int main() {
	int n = 10;
	Queue q1;
	int x = 0;
	cout << "Created a queue" << endl;
	while (n != 0)
	{
		
		cout<< "1 to enqueue() " << endl
			<< "2 to dequeue()" << endl
			<< "3 to empty()" << endl
			<< "4 to front()" << endl
			<< "5 to size()" << endl
			<< "6 to display()" << endl
			<< "0 to exit" << endl;

		cin >> n;
		switch (n)
		{
		case 1:
			cout << " Enter a number to enqueue:" << endl;

			cin >> x;
			q1.enQueue(x);
			break;
		case 2:
			q1.deQueue();
			break;
		case 3:
			if (q1.empty() == 1)
			{
				cout << "Queue is empty" << endl;
			}
			else
			{
				cout << "Queue is not empty" << endl;
			}
			break;
		case 4:
			cout << "Front element of the queue is:" << q1.front() << endl;
			break;
		case 5:
			cout << "Size of the queue is:" << q1.size() << endl;
			break;
		case 6:
			cout << "Elements of the queue:";
			q1.display();
			cout << endl;
			break;
		case 0:
			break;
		default:
			break;
		}

	}


}