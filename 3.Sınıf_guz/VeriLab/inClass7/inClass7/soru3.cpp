#include<stack>
#include<iostream>
#include<string>
using namespace std;

bool isPalindrome(string s)
{
	int length = s.size();

	
	stack<char> st;

	 
	int i, mid = length / 2;

	for (i = 0; i < mid; i++) {
		st.push(s[i]);
	}

	 
	if (length % 2 != 0) {
		i++;
	}

	char ele;
	 
	while (s[i] != '\0')
	{
		ele = st.top();
		st.pop();

		
		if (ele != s[i])
			return false;
		i++;
	}

	return true;
}

int main() {

	string kelime ;
	getline(cin,kelime);
	if (isPalindrome(kelime))
	{
		cout << "Yes";
	}
	else
	{
		cout << "No";
	}



	return 0;
}