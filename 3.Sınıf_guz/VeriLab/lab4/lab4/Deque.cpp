#include "Deque.h"
#include<iostream>

using namespace std;
///------------------------------------------------------
/// Default constructor
/// 
Deque::Deque() {
	head = tail = NULL;
	itemSayisi = 0;
	// Fill this in
} //end-Deque

///------------------------------------------------------
/// Destructor
/// 
Deque::~Deque() {
	delete head, tail;
	// Fill this in
} //end-~Deque

///------------------------------------------------------
/// Adds a new item to the front of the Deque
/// 
void Deque::AddFront(int item) {
	DequeNode* newNode = new DequeNode(item);
	
	
	// deque bo�sa
	if (head == NULL)
		tail = head = newNode;
	// listenin sonuna eleman� ekleriz
	else
	{
		newNode->next = head;
		head->prev = newNode;
		head = newNode;
	}
	// item say�s� 1 art�r�l�r
	itemSayisi++;
	


} //end-AddFront

///------------------------------------------------------
/// Adds a new item to the end of the Deque
/// 
void Deque::AddRear(int item) {
	DequeNode* newNode = new DequeNode(item);

	
	// deque bo�sa
	if (tail == NULL){ head = tail = newNode; }		
	else//listenin sonuna eleman� ekleriz
		
		newNode->prev = tail;
		tail->next = newNode;
		tail = newNode;
	
		// item say�s� 1 art�r�l�r
		itemSayisi++;
	


} //end-AddRear

///------------------------------------------------------
/// Remove and return the item at the front of the Deque
/// If the Deque is empty, throw an exception
/// 
int Deque::RemoveFront() {
	int front = 0;
	if (IsEmpty()) { cout<<"Bo� kuyruktan item silinemez."; }// kuyruk bo�sa bi �ey silinemez
	else
	{

		
		DequeNode* temp = head;
		front = Front();
		head = head->next;
		if (head == NULL){	tail = NULL;}
		else{ head->prev = NULL; }
			
		free(temp);
		// item sayisi 1 azal�r
		itemSayisi--;
	}


	return front;
} //end-RemoveFront

///------------------------------------------------------
/// Remove and return the item at the rear of the Deque
/// If the Deque is empty, throw an exception
/// 
int Deque::RemoveRear() {
	int rear = 0;
	if (IsEmpty()) { cout << "Bo� kuyruktan item silinemez."; }// kuyruk bo�sa bi �ey silinemez
	else
	{
		DequeNode* temp = tail;
		rear = Rear();
		tail = tail->prev;
		
		if (tail == NULL){ head = NULL; }	
		else{ tail->next = NULL; }
			
		free(temp);
		// item sayisi 1 azal�r
		itemSayisi--;
	}
	return rear;


} //end-RemoveRear

///------------------------------------------------------
/// Return the item at the front of the Deque (do not remove the item)
/// If the Deque is empty, throw an exception
/// 
int Deque::Front() {
	if (IsEmpty()) { cout << "Kuyruk bo�"; }
	return head->item;

} //end-Front

///------------------------------------------------------
/// Return the item at the rear of the Deque (do not remove the item)
/// If the Deque is empty, throw an exception
/// 
int Deque::Rear() {
	if (IsEmpty()) { cout<<"Kuyruk bo�"; }
	return tail->item;

} //end-Rear
