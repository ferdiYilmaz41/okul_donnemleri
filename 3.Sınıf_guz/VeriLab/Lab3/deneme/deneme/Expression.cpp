#include <string>
#include<stack>
#include<iostream>
using namespace std;

///----------------------------------------------------------------------------------
/// Given an expression in infix-notation, converts it to a string in post-fix notation 

// Function to verify whether a character is english letter or numeric digit. 
// We are assuming in this solution that operand will be a single character
bool IsOperand(char C)
{
	if (C >= '0' && C <= '9') return true;
	if (C >= 'a' && C <= 'z') return true;
	if (C >= 'A' && C <= 'Z') return true;
	return false;
}

// Function to verify whether a character is operator symbol or not. 
bool IsOperator(char C)
{
	if (C == '+' || C == '-' || C == '*' || C == '/' || C == '$')
		return true;

	return false;
}

// Function to verify whether an operator is right associative or not. 
int IsRightAssociative(char op)
{
	if (op == '$') return true;
	return false;
}

// Function to get weight of an operator. An operator with higher weight will have higher precedence. 
int GetOperatorWeight(char op)
{
	int weight = -1;
	switch (op)
	{
	case '+':
	case '-':
		weight = 1;
	case '*':
	case '/':
		weight = 2;
	case '$':
		weight = 3;
	}
	return weight;
}

// Function to perform an operation and return output. 
int HasHigherPrecedence(char op1, char op2)
{
	int op1Weight = GetOperatorWeight(op1);
	int op2Weight = GetOperatorWeight(op2);

	// If operators have equal precedence, return true if they are left associative. 
	// return false, if right associative. 
	// if operator is left-associative, left one should be given priority. 
	if (op1Weight == op2Weight)
	{
		if (IsRightAssociative(op1)) return false;
		else return true;
	}
	return op1Weight > op2Weight ? true : false;
}

string Infix2Postfix(string &expression)
{
	// Declaring a Stack from Standard template library in C++. 
	stack<char> S;
	string postfix = ""; // Initialize postfix as empty string.
	for (int i = 0; i < expression.length(); i++) {

		// Scanning each character from left. 
		// If character is a delimitter, move on. 
		if (expression[i] == ' ' || expression[i] == ',') continue;

		// If character is operator, pop two elements from stack, perform operation and push the result back. 
		else if (IsOperator(expression[i]))
		{
			while (!S.empty() && S.top() != '(' && HasHigherPrecedence(S.top(), expression[i]))
			{
				postfix += S.top();
				S.pop();
			}
			S.push(expression[i]);
		}
		// Else if character is an operand
		else if (IsOperand(expression[i]))
		{
			postfix += expression[i];
		}

		else if (expression[i] == '(')
		{
			S.push(expression[i]);
		}

		else if (expression[i] == ')')
		{
			while (!S.empty() && S.top() != '(') {
				postfix += S.top();
				S.pop();
			}
			S.pop();
		}
	}

	while (!S.empty()) {
		postfix += S.top();
		S.pop();
	}

	return postfix;
}




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
