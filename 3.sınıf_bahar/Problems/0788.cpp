int rotatedDigits(int n) {
	int count = 0;


	for (int i = 1; i <= n; i++) {
		int x, rem;
		bool isGood = false;
		x = i;
		while (x > 0) {

			rem = x % 10;
			x = x / 10;
			if (rem == 3 || rem == 4 || rem == 7) {
				isGood = false;
				break;
			}
			else if (rem == 2 || rem == 5 || rem == 6 || rem == 9) {
				isGood = true;
			}
		}
		if (isGood) {
			count++;
		}




	}
	return count;
}