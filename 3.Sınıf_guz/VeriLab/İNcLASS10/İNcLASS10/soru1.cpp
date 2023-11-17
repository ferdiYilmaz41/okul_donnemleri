// Binary Tree in C++

#include <stdlib.h>
#include<queue>
#include <iostream>

using namespace std;

struct Node {
	int data;
	Node* left;
	Node* right;
};

// Function to create a new node
Node* CreateNode(int data)
{
	Node* newNode = new Node();
	if (!newNode) {
		cout << "Memory error\n";
		return NULL;
	}
	newNode->data = data;
	newNode->left = newNode->right = NULL;
	return newNode;
}
Node* InsertNode(Node* root, int data)
{
	// If the tree is empty, assign new node address to root
	if (root == NULL) {
		root = CreateNode(data);
		return root;
	}

	// Else, do level order traversal until we find an empty
	// place, i.e. either left child or right child of some
	// node is pointing to NULL.
	queue<Node*> q;
	q.push(root);

	while (!q.empty()) {
		Node* temp = q.front();
		q.pop();

		if (temp->left != NULL)
			q.push(temp->left);
		else {
			temp->left = CreateNode(data);
			return root;
		}

		if (temp->right != NULL)
			q.push(temp->right);
		else {
			temp->right = CreateNode(data);
			return root;
		}
	}
}
// Traverse Preorder
void preOrder(Node* temp) {
	if (temp != NULL) {
		cout << " " << temp->data;
		preOrder(temp->left);
		preOrder(temp->right);
	}
}

// Traverse Inorder
void inOrder(Node* temp) {
	if (temp == NULL)
		return;

	inOrder(temp->left);
	cout << temp->data << ' ';
	inOrder(temp->right);
}

// Traverse Postorder
void postOrder(Node* temp) {
	if (temp != NULL) {
		postOrder(temp->left);
		postOrder(temp->right);
		cout << " " << temp->data;
	}
}
void insert(Node* current, int key) {
	if (current==NULL)
	{
		Node* temp = new Node;
		temp->data = key;
		current = temp;
	}
	else
	{
		cout << key;
		if (current->left==NULL)
		{
			current->left->data = key;
			return;
		}

		if (current->right==NULL)
		{
			current->right->data = key;
			return;
		}
		else
		{
			Node* newLeft= new Node() ;
			insert(newLeft,key);

		}

	}
	return;
}
int main() {
	
	

	Node* root=CreateNode(4);
	int arr[5] = { 6,12,45,7,1 };
	insert(root, 6);
	insert(root, 12);
	insert(root, 45);
	insert(root, 7);
	insert(root, 1);
	cout << "preorder:" << endl;
	preOrder(root);
	cout <<endl<< "inorder:" << endl;
	inOrder(root);
	cout <<endl<< "postorder:"<<endl;
	postOrder(root);
	
}