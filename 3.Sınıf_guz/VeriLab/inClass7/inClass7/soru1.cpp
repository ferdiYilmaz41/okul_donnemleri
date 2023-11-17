#include<iostream>
#include<stack>

using namespace std;

void print(stack<int> st) {
	while (!st.empty())
	{
		cout << st.top() << " ";
		st.pop();
	}
}
void rprint(stack<int> tmp) {
	stack<int> tst;
	while (!tmp.empty())
	{

		tst.push(tmp.top());
		tmp.pop();
	}
	while (!tst.empty())
	{
		cout << tst.top() << " ";
		tst.pop();
	}
}
void tersHaldenAzalt(stack<int> tmp,int n) {
	stack<int> tst;
	while (!tmp.empty())
	{

		tst.push(tmp.top());
		tmp.pop();
	}
	int i = 0;
	while (i<n)
	{
		tst.pop();
		i++;
	}
	while (!tst.empty())
	{
		cout << tst.top() << " ";
		tst.pop();
	}

}
int main() {

	stack<int> st;

	cout << " Check stack initial state:";
	if (st.empty())
	{
		cout << "empty";

	}
	else
		cout << "not empty";


	cout <<endl<< "Add element to stack:" << endl;
	st.push(21);
	st.push(22);
	st.push(24);
	st.push(25);
	
	cout << endl;
	
	print(st);
	cout << endl;
	rprint(st);
	

	cout << endl;
	tersHaldenAzalt(st, 2);
	


	return 1;
}