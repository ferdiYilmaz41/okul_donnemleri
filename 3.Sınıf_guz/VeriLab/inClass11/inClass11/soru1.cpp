#include<iostream>

using namespace std;

class TreeNode {
public:
	int data;
	TreeNode* left;
	TreeNode* right;
	TreeNode(int data = 0, TreeNode* left = NULL,
		TreeNode* right = NULL)
		:data(data), left(left), right(right) {

	}

};

class BinarySearchTree {
	TreeNode* root;
public:
	BinarySearchTree() :root(NULL) {

	}
	bool isEmpty()const { return root == NULL; }
	void insert(int data) {
		root = insert(root, data);
	}
	void preOrder(TreeNode* start) {
		if (start)
		{
			cout << start->data << " ";
			preOrder(start->left);
			preOrder(start->right);
		}
	}
	void inOrder(TreeNode* start) {
		if (start)
		{
			inOrder(start->left);
			cout << start->data << " ";
			inOrder(start->right);

		}
	}
	void postOrder(TreeNode* start) {
		if (start)
		{
			postOrder(start->left);
			postOrder(start->right);
			cout << start->data << " ";
		}
	}
	
	TreeNode* getRoot()const { return root; }
	TreeNode* insert(TreeNode* start, int data) {
		if (start)
		{
			if (data<start->data)
			{
				start->left = insert(start->left, data);
			}
			else
			{
				start->right = insert(start->right, data);
			}
		}
		else
		{
			return new TreeNode(data);
		}
		return start;
	}
};

int main() {

	BinarySearchTree bst;
	bst.insert(1);
	bst.insert(12);
	bst.insert(34);
	bst.insert(41);
	bst.insert(52);

	bst.inOrder();

}