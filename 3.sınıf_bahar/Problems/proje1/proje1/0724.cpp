int pivotIndex(vector<int>& nums) {


	int sum = 0, sum1 = 0;
	for (int x = 0; x < nums.size(); x++) {
		sum += nums[x];
	}
	for (int i = 0; i < nums.size(); ++i) {
		if (sum1 == sum - sum1 - nums[i]) {
			return i;
		}
		sum1 += nums[i];
	}
	return -1;


}