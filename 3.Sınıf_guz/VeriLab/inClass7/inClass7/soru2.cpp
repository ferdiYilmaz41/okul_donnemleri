#include<iostream>
#include<stack>

using namespace std;


stack<int> sortStack(stack<int> &input)
{
	stack<int> tmpStack;

	while (!input.empty())
	{
		
		int tmp = input.top();
		input.pop();

		
		while (!tmpStack.empty() && tmpStack.top() > tmp)
		{
			
			input.push(tmpStack.top());
			tmpStack.pop();
		}

		
		tmpStack.push(tmp);
	}

	return tmpStack;
}

int main() {

	stack<int> st;

	

	cout << endl << "First stack:" << endl;
	st.push(21);
	st.push(22);
	st.push(43);
	st.push(25);
	
	cout << endl;
	stack<int> sorted = sortStack(st);
	while (!sorted.empty())
	{
		cout << sorted.top() << " ";
		sorted.pop();
	}



	return 1;
}