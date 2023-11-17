#include <stdio.h>
#include "Poly.h"

#include<iostream>

using namespace std;
char* removeSpaces(char* str)
{
	int len = strlen(str);
	char* temp = new char[len];
	int i, j;
	for (i = 0, j = 0; i < strlen(str); i++, j++)
	{
		if (str[i] != ' ')
		{
			temp[j] = str[i];
		}
		else
		{
			j--;
		}
	}
	temp[j] = 0;
	return temp;
}
void func(string exp, double& coef, int& expo)
{
	int flag = 0;
	int posX = 0;
	int posE = 0;
	for (int i = 0; i < exp.length(); i++)
	{
		if (exp[i] == 'x' || exp[i] == '^')
		{
			flag += 1;
			if (flag == 1) posX = i; posE = i + 1;
		}
	}
	if (flag == 2) // 3x^2
	{
		string sub;
		sub = exp.substr(0, posX);
		if (sub == "" || sub == "+" || sub == "x")
		{
			coef = 1;
		}
		else if (sub == "-")
		{
			coef = -1;
		}
		else
		{
			coef = stod(sub);
		}
		sub = exp.substr(posE, exp.length());
		expo = stoi(sub);
	}
	else if (flag == 1) // 3x  +x, -x
	{
		exp.erase(exp.end() - 1, exp.end());
		if (exp == "+")
		{
			coef = 1;
		}
		else if (exp == "-")
		{
			coef = -1;
		}
		else
		{
			coef = stod(exp);
		}
		expo = 1;
	}
	else // 3
	{
		coef = stod(exp);
		expo = 0;
	}
	/*cout << "Coef: " << coef << endl;
	cout << "Exponent: " << expo << endl;*/
}
PolyNode *CreatePoly(char *expr)
{
	PolyNode* head = NULL;
	double coef = 0;
	int exponent = 0;
	char* temp = new char[strlen(expr)];
	temp = removeSpaces(expr);
	string str = temp;
	size_t pos = 0;
	string token;
	//sondan baþa doðru ayýrmasý lazým polinomu
	for (int i = 0; i < str.length(); i++) //parsing function(polinomu deðerlere ayýrma)
	{
		if (str[i] == '+' || str[i] == '-' || i == 0)
		{
			for (pos = i + 1; pos < str.length(); pos++)
			{
				if (str[pos] == '+' || str[pos] == '-')
				{
					break;
				}
			}
			token = str.substr(0, pos);
			/*cout << "----------------------------" << endl;
			cout << token << endl;*/
			func(token, coef, exponent);
			if (head == NULL)
			{
				head = AddNode(head, coef, exponent);
			}
			else AddNode(head, coef, exponent);
			/*cout << "----------------------------" << endl << endl;*/
			str.erase(0, pos);
			i--;
		}
	}
	return head;
} //end-CreatePoly

/// -------------------------------------------------
/// Walk over the poly nodes & delete them
///
void DeletePoly(PolyNode* poly) {
	// Fill this in
} // end-DeletePoly

//-------------------------------------------------
// Adds a node (coefficient, exponent) to poly. If there already 
// is a node with the same exponent, then you simply add the coefficient
// to the existing coefficient. If not, you add a new node to polynomial
// Returns a pointer to the possibly new head of the polynomial.
//
PolyNode* AddNode(PolyNode *head, double coef, int expo) {
	PolyNode* newNode = new PolyNode();
	PolyNode* first = head;
	PolyNode* last = head;
	int flag = 0;
	if (head == NULL) //head node ise
	{
		head = new PolyNode();
		head->coef = coef;
		head->exp = expo;
		head->next = NULL;
		return head;
	}
	else
	{
		newNode->coef = coef;
		newNode->exp = expo;
		newNode->next = NULL;
	}
	while (last != NULL)
	{
		// temp code.
		if (last->exp == newNode->exp)
		{
			flag = 2;
			last->coef += newNode->coef;
			if (last->exp == head->exp)
			{
				do
				{
					head = head->next;
				} while (head->coef != 0);
			}
			if (last->coef == 0)
			{
				last = last->next;
			}
			return head;
		}
		if (newNode->exp > last->exp) // eþit durum olursa
		{
			flag = 1;
			if (last->exp == head->exp) // head'den büyükse
			{
				newNode->next = last;
				head = newNode;
			}
			else
			{
				first->next = newNode;
				newNode->next = last;
			}
			return head;
		}
		if (first->next != last->next)
		{
			first = first->next;
		}
		last = last->next;
	}
	if (flag == 0) //küçük
	{
		first->next = newNode;
		return head;
	}
} // end-AddNode

//-------------------------------------------------
// Adds two polynomials and returns a new polynomial that contains the result
// Computes: poly3 = poly1 + poly2 and returns poly3
//
PolyNode *Add(PolyNode *poly1, PolyNode *poly2) {
	PolyNode* temp = new PolyNode();

	
		temp = poly2;
		while (poly2 != NULL)
		{
			if (poly1->exp == poly2->exp)
			{
				poly1->coef += poly2->coef;
				poly2 = poly2->next;
			}
			else
			{
				poly1 = poly1->next;
			}
		}
	
	

	return poly1;
} //end-Add

//-------------------------------------------------
// Subtracts poly2 from poly1 and returns the resulting polynomial
// Computes: poly3 = poly1 - poly2 and returns poly3
//
PolyNode *Subtract(PolyNode *poly1, PolyNode *poly2) {
	// Fill this in
	return NULL;
} //end-Substract

//-------------------------------------------------
// Multiplies poly1 and poly2 and returns the resulting polynomial
// Computes: poly3 = poly1 * poly2 and returns poly3
//
PolyNode *Multiply(PolyNode *poly1, PolyNode *poly2) {
	// Fill this in
	return NULL;
} //end-Multiply

//-------------------------------------------------
// Evaluates the polynomial at a particular "x" value and returns the result
//
double Evaluate(PolyNode *poly, double x) {
	// Fill this in
	return 0;
} //end-Evaluate

//-------------------------------------------------
// Computes the derivative of the polynomial and returns it
// Ex: poly(x) = 3x^4 - 2x + 1-->Derivative(poly) = 12x^3 - 2
//
PolyNode *Derivative(PolyNode *poly) {
	// Fill this in
	//x unutma x^1
	return NULL;
} //end-Derivative

//-------------------------------------------------
// Plots the polynomial in the range [x1, x2].
// -39<=x1<x2<=39
// -12<=y<=12
// On the middle of the screen you gotta have x & y axis plotted
// During evaluation, if "y" value does not fit on the screen,
// then just skip it. Otherwise put a '*' char depicting the curve
//
void Plot(PolyNode *poly, int x1, int x2) {
	// Fill this in	
	// 3x^2+5x-3
	// 3*1*1+5*1-3
	// 
	char dizi[79][79];
	int a;
	int b;
	int c;
	int r;

	int i = 0;
	int j = 0;

	void Axes();
	{
		for (int i = 0; i <= 79; i++)
		{
			for (int j = 0; j <= 25; j++)
			{
				if (i == 0 && j == 24)
				{
					dizi[i][j] = 'y';
				}
				else if (j == 24 && i == 78)
				{
					dizi[i][j] = 'x';
				}
				else if (j ==39)
				{
					dizi[i][j] = '|';
				}
				else if (i == 12)
				{

					dizi[i][j] = '-';
				}
				else
				{
					dizi[i][j] = ' ';
				}
			}
		}
	}
} //end-Plot