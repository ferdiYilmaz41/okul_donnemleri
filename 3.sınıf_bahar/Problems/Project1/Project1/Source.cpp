#include <iostream>
#include <algorithm>
#include <cstring>
using namespace std;

bool tekrarlananSayisiEsitMi(string s) {
	int freq[26] = { 0 };
	int len = s.length();
	for (int i = 0; i < len; i++) {
		freq[s[i] - 'a']++;
	}
	sort(freq, freq + 26);
	if (freq[0] == 0) return false;
	int i = 0;
	while (freq[i] == freq[i + 1]) i++;
	if (i == 24) return true;
	return false;
}

int main() {
	string s;
	cout << "Bir string girin: ";
	cin >> s;
	if (tekrarlananSayisiEsitMi(s)) {
		cout << "Stringdeki harflerin tekrar sayýlarý eþit.\n";
	}
	else {
		cout << "Stringdeki harflerin tekrar sayýlarý eþit deðil.\n";
	}
	return 0;
}