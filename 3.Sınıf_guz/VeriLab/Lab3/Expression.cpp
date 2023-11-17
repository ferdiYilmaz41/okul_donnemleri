#include <string>
#include<stack>
#include<iostream>
using namespace std;

///----------------------------------------------------------------------------------
/// Given an expression in infix-notation, converts it to a string in post-fix notation 

int oncelik(char sembol) {
	if (sembol == '+' || sembol == '-')
		return 1;

	if (sembol == '*' || sembol == '/')
		return 2;

	return 0;
}

int applyOp(int a, int b, char op) {
	switch (op) {
	case '+': return a + b;
	case '-': return a - b;
	case '*': return a * b;
	case '/': return a / b;
	}
}

string Infix2Postfix(string &s) {
	
	string postfix = "";

	int i = 0;
	stack<int> st;

	while (s[i]!='\0')
	{
		//
		if (s[i] >= 'a'&&s[i] <= 'z' || s[i] >= 'A'&&s[i] <= 'Z') {
			postfix += s[i];
			i++;
		}

		else if (s[i] == '(') {
			st.push(s[i]);
			i++;
		}

		else if (s[i]==')')
		{
			while (st.top()!='(')
			{
				postfix += st.top();
				st.pop();
			}
			st.pop();
			i ++;
		}
		else
		{
			while (!st.empty() && oncelik(s[i])<=oncelik(st.top()))
			{
				postfix += st.top();
				st.pop();
			}
			st.push(s[i]);
			i++;
		}

		
	}

	while (!st.empty()) {
		postfix += st.top();
		st.pop();
	}

	///
	string result;
	result = postfix;
	return result;
} // end-Infix2Postfix






///----------------------------------------------------------------------------------
/// Given a string in post-fix notation, evaluates it and returns the result
/// 
int EvaluatePostfixExpression(string& tokens) {

	int i;

	// stack to store integer values.
	stack <int> values;

	// stack to store operators.
	stack <char> ops;

	for (i = 0; i < tokens.length(); i++) {

		// Current token is a whitespace,
		// skip it.
		if (tokens[i] == ' ')
			continue;

		// Current token is an opening
		// brace, push it to 'ops'
		else if (tokens[i] == '(') {
			ops.push(tokens[i]);
		}

		// Current token is a number, push
		// it to stack for numbers.
		else if (isdigit(tokens[i])) {
			int val = 0;

			// There may be more than one
			// digits in number.
			while (i < tokens.length() &&
				isdigit(tokens[i]))
			{
				val = (val * 10) + (tokens[i] - '0');
				i++;
			}

			values.push(val);

			// right now the i points to
			// the character next to the digit,
			// since the for loop also increases
			// the i, we would skip one
			//  token position; we need to
			// decrease the value of i by 1 to
			// correct the offset.
			i--;
		}

		// Closing brace encountered, solve
		// entire brace.
		else if (tokens[i] == ')')
		{
			while (!ops.empty() && ops.top() != '(')
			{
				int val2 = values.top();
				values.pop();

				int val1 = values.top();
				values.pop();

				char op = ops.top();
				ops.pop();

				values.push(applyOp(val1, val2, op));
			}

			// pop opening brace.
			if (!ops.empty())
				ops.pop();
		}

		// Current token is an operator.
		else
		{
			// While top of 'ops' has same or greater
			// precedence to current token, which
			// is an operator. Apply operator on top
			// of 'ops' to top two elements in values stack.
			while (!ops.empty() && oncelik(ops.top())
				>= oncelik(tokens[i])) {
				int val2 = values.top();
				values.pop();

				int val1 = values.top();
				values.pop();

				char op = ops.top();
				ops.pop();

				values.push(applyOp(val1, val2, op));
			}

			// Push current token to 'ops'.
			ops.push(tokens[i]);
		}
	}

	// Entire expression has been parsed at this
	// point, apply remaining ops to remaining
	// values.
	while (!ops.empty()) {
		int val2 = values.top();
		values.pop();

		int val1 = values.top();
		values.pop();

		char op = ops.top();
		ops.pop();

		values.push(applyOp(val1, val2, op));
	}

	// Top of 'values' contains result, return it.
	return values.top();



	
} // end-EvaluatePostfixExpression
