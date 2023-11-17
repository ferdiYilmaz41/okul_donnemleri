using namespace std;
#include<iostream>
#include<stack>
// Function to return precedence of operators
int prec(char c)
{
	if (c == '^')
		return 3;
	else if (c == '/' || c == '*')
		return 2;
	else if (c == '+' || c == '-')
		return 1;
	else
		return -1;
}


string Infix2Postfix(string& s) {
	// Fill this in
	stack<char> st; // For stack operations, we are using
					// C++ built in stack
	string result;

	for (int i = 0; i < s.length(); i++) {
		char c = s[i];

		// If the scanned character is
		// an operand, add it to output string.
		if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')
			|| (c >= '0' && c <= '9'))
			result += c;

		// If the scanned character is an
		// ‘(‘, push it to the stack.
		else if (c == '(') {

			st.push('(');
		}
		// If the scanned character is an ‘)’,
		// pop and to output string from the stack
		// until an ‘(‘ is encountered.
		else if (c == ')') {
			while (st.top() != '(') {
				result += st.top();
				st.pop();
			}
			st.pop();
		}

		// If an operator is scanned
		else {
			while (!st.empty()
				&& prec(s[i]) <= prec(st.top())) {
				result += st.top();
				st.pop();
			}
			st.push(c);
		}
	}

	// Pop all the remaining elements from the stack
	while (!st.empty()) {
		result += st.top();
		st.pop();
	}
	//cout << result << endl;
	return result;
} // end-Infix2Postfix

///----------------------------------------------------------------------------------
/// Given a string in post-fix notation, evaluates it and returns the result
/// 
/// HOCANIN KODU
int EvaluatePostfixExpression(string& s) {

	return 0;
} // end-EvaluatePostfixExpression


struct Stack
{
	int top;
	unsigned capacity;
	int* array;
};

// Stack Operations
struct Stack* createStack(unsigned capacity)
{
	struct Stack* stack = (struct Stack*)malloc(sizeof(struct Stack));

	if (!stack) return NULL;

	stack->top = -1;
	stack->capacity = capacity;
	stack->array = (int*)malloc(stack->capacity * sizeof(int));

	if (!stack->array) return NULL;

	return stack;
}

int isEmpty(struct Stack* stack)
{
	return stack->top == -1;
}

char peek(struct Stack* stack)
{
	return stack->array[stack->top];
}

char pop(struct Stack* stack)
{
	if (!isEmpty(stack))
		return stack->array[stack->top--];
	return '$';
}

void push(struct Stack* stack, char op)
{
	stack->array[++stack->top] = op;
}


// The main function that returns value of a given postfix expression
int evaluatePostfix(char* exp)
{
	// Create a stack of capacity equal to expression size
	struct Stack* stack = createStack(strlen(exp));
	int i;

	// See if stack was created successfully
	if (!stack) return -1;

	// Scan all characters one by one
	for (i = 0; exp[i]; ++i)
	{
		// If the scanned character is an operand (number here),
		// push it to the stack.
		if (isdigit(exp[i]))
			push(stack, exp[i] - '0');

		// If the scanned character is an operator, pop two
		// elements from stack apply the operator
		else
		{
			int val1 = pop(stack);
			int val2 = pop(stack);
			switch (exp[i])
			{
			case '+': push(stack, val2 + val1); break;
			case '-': push(stack, val2 - val1); break;
			case '*': push(stack, val2 * val1); break;
			case '/': push(stack, val2 / val1); break;
			}
		}
	}
	return pop(stack);
}


// Driver's code
int main()
{
	string exp = "20+2*3+(2*8+5)*4";

	// Function call
	Infix2Postfix(exp);

	char ex[] = "20+2*3+(2*8+5)*4";
	cout << "postfix evaluation: " << evaluatePostfix(Infix2Postfix(exp));
	return 0;
}