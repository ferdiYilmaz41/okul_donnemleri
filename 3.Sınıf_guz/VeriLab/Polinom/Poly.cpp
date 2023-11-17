#include <stdio.h>
#include "Poly.h"
#include "PolyNode.h"
#include<iostream>
#include<string>
#include <cstdlib>
using namespace std;
//-------------------------------------------------
// Creates a polynomial from an expression.
// Returns a pointer to the first PolyNode in the list (head of the list)
//
// Expression will be of the following sort:
// Ex1: 2.3x^4 + 5x^3 - 2.64x - 4
// Ex2: -4.555x^10 - 45.44
// Ex3: x^6 + 2x^4 - x^3 - 6.3x + 4.223 
// Ex4: 34
// Ex5: -x+1
// Ex6: -3x^4    +   4x
// Ex7: -2x  - 5
//
char* boslukKaldýr(char* string)
{
	int length = strlen(string);
	char* gecici = new char[length];
	int i = 0;
	int j = 0;
	while (i < strlen(string))
	{
		if (string[i] != ' ')
		{
			gecici[j] = string[i];
		}
		else
		{
			j--;
		}
		i++;
		j++;
	}

	gecici[j] = 0;
	return gecici;
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
	if (flag == 2) 
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
	temp = boslukKaldýr(expr);
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
	poly = NULL;
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
	
	
	PolyNode* poly3=new PolyNode() ;
	*poly3 = *poly1;  // direkt 1.yi 3e attýk
	
	while (poly2->next!=NULL) // addNode komutuyla da diðerini ekledik
	{	                      //ayný polinomu eklediðimi< için direkt topladý
		poly3 = AddNode(poly3, poly2->coef, poly2->exp);
		poly2 = poly2->next;
	}
	if (poly2->exp == 0 || poly2 != NULL)
	{
		poly3 = AddNode(poly3, poly2->coef, poly2->exp);
		poly2 = poly2->next;
	}

	
	

	


	return poly3;
} //end-Add

//-------------------------------------------------
// Subtracts poly2 from poly1 and returns the resulting polynomial
// Computes: poly3 = poly1 - poly2 and returns poly3
//
PolyNode *Subtract(PolyNode *poly1, PolyNode *poly2) {
	
	PolyNode* poly3=poly1;

	

 	for (int i = 0; i < sizeof(poly3); i++)
	{
		if (poly2==NULL)
		{
			break;
		}
		else
		{
			poly3 = AddNode(poly3, -1 * (poly2->coef), poly2->exp);
			poly2 = poly2->next;
		}
		
	}

	return poly3;
} //end-Substract

//-------------------------------------------------
// Multiplies poly1 and poly2 and returns the resulting polynomial
// Computes: poly3 = poly1 * poly2 and returns poly3
//
PolyNode *Multiply(PolyNode *poly1, PolyNode *poly2) {

	//int a = sizeof(poly1 )+sizeof(poly2) - 2;
	
	PolyNode* poly3=NULL;
	struct PolyNode* temp=NULL;
	PolyNode* temp1 = poly1;
	PolyNode* temp2 = poly2;
	int exp,coef;
	for (int i = 0; i < sizeof(poly1) ; i++)
	{
		for (int j = 0; j < sizeof(poly2) - 1; j++)
		{
			
			coef= temp1->coef * temp2->coef;
			exp = temp1->exp+ temp2->exp;

			temp = AddNode(temp, coef, exp);
			temp2 = temp2->next;
			
			coef = 0;
			exp = 0;
		}
		temp2 = poly2;
		temp1 = temp1->next;
	}
	
	


	return temp;
} //end-Multiply

//-------------------------------------------------
// Evaluates the polynomial at a particular "x" value and returns the result
//
double Evaluate(PolyNode *poly, double x) {
	double toplam = 0;
	for (int i = 0; i < sizeof(poly)-1; i++)
	{
		toplam += ((double)poly->coef * (double)pow(x, poly->exp));
		poly = poly->next;
	}
	if (poly->exp==0)
	{
		toplam += ((double)poly->coef);
	}

	return toplam;
} //end-Evaluate

//-------------------------------------------------
// Computes the derivative of the polynomial and returns it
// Ex: poly(x) = 3x^4 - 2x + 1-->Derivative(poly) = 12x^3 - 2
//
PolyNode *Derivative(PolyNode *poly) {

	PolyNode* temp= NULL;
	

	for (int i = 0; i < sizeof(poly)-1; i++)
	{
		if (poly->exp==0)
		{
			temp = AddNode(temp, 0, 0);
			break;
		}
		else
		{
			int coef = poly->coef * poly->exp;
			temp = AddNode(temp, coef, poly->exp - 1); 
			
			poly = poly->next;
		}
		
	}


	
	return temp;
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
} //end-Plot

