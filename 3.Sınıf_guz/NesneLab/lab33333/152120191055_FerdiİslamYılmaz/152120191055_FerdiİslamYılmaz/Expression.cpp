#include <string>
#include<stack>
#include<iostream>
using namespace std;

int oncelik(char c)
{

	if (c == '/' || c == '*')
		return 2;
	else if (c == '+' || c == '-')
		return 1;
	else
		return -1;
}

string Infix2Postfix(string& s) {

	stack<char> st;
	string result;

	for (int i = 0; i < s.length(); i++) {
		char c = s[i];

		// Karakter bir operandsa ekliyoruz.


		if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
			result += c;

		// Karakter "(" ise stacke push ediyoruz.
		else if (c == '(') {

			st.push('(');
		}
		// Karakter ")" ise"("görene kadar stackten pop ediyoruz.
		else if (c == ')') {

			while (st.top() != '(') {
				result = result + st.top();
				st.pop();
			}
			st.pop();
		}
		else if (c == ' ')
		{
			continue;
		}
		// Operator varsa
		else {
			while (!st.empty() && oncelik(s[i]) <= oncelik(st.top())) {
				result = result + st.top();
				st.pop();
			}
			result += " ";
			st.push(c);
		}

	}

	while (!st.empty()) {
		result = result + st.top();
		st.pop();
	}

	return result;

} // end-Infix2Postfix







// iþlemleri yapar
int islemYap(int a, int b, char op) {
	switch (op) {
	case '+': return a + b;
	case '-': return a - b;
	case '*': return a * b;
	case '/': return a / b;
	}
}

int EvaluatePostfixExpression(string& tokens) {

	int i;

	stack <int> values;

	stack <char> ops;

	for (i = 0; i < tokens.length(); i++) {

		// Token boþluksa geç.
		if (tokens[i] == ' ')
			continue;

		else if (isdigit(tokens[i])) {
			int val = 0;

			// sayýda birden fazla rakam varsa
			while (i < tokens.length() &&
				isdigit(tokens[i]))
			{
				if (tokens.empty())
				{
					break;
				}
				val = (val * 10) + (tokens[i] - '0');
				i++;
			}

			values.push(val);

			i--;
		}
		else
		{

			if (tokens.empty())
			{
				break;
			}
			if (values.size() == 1)
			{
				return values.top();
			}
			else
			{
				int val2 = values.top();
				values.pop();

				int val1 = values.top();
				values.pop();

				char op = tokens[i];

				values.push(islemYap(val1, val2, op));
			}




		}


	}//end-for

	while (!ops.empty()) {
		if (ops.empty())break;
		else {

			int val2 = values.top();
			values.pop();

			int val1 = values.top();
			values.pop();

			char op = ops.top();
			ops.pop();

			values.push(islemYap(val1, val2, op));
		}


	}

	return values.top();

} // end-EvaluatePostfixExpression
