class Solution {
public:
	ListNode* removeNodes(ListNode* head) {
		vector<int> nums;
		while (head) {
			nums.emplace_back(head->val);
			head = head->next;
		}
		vector<int> stk;
		for (int v : nums) {
			while (!stk.empty() && stk.back() < v) {
				stk.pop_back();
			}
			stk.push_back(v);
		}
		ListNode* dummy = new ListNode();
		head = dummy;
		for (int v : stk) {
			head->next = new ListNode(v);
			head = head->next;
		}
		return dummy->next;
	}
};