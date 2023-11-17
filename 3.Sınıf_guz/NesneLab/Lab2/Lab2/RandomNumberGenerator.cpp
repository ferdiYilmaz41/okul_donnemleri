/// RandomNumberGenerator.cpp 
#include "RandomNumberGenerator.h" 
#include <time.h> 
#include <iostream> 
#include<random>
#include<ctime>
#include<iomanip>
using namespace std;
RandomNumberGenerator::RandomNumberGenerator()
{
	srand(time(NULL));
}
RandomNumberGenerator::~RandomNumberGenerator()
{
}
int RandomNumberGenerator::getRandomInteger(int lowerBound, int upperBound)
{
	// Implement the function 
	int random = rand() % (upperBound - lowerBound, + 1) + lowerBound;
	return random;
}
float RandomNumberGenerator::getRandomFloat(float lowerBound, float upperBound,
	Precision precision)
{
	// Implement the function 
	// You are required to use switch case structure for the enum type 
	double random;
	int _upperBound = (int)upperBound;
	int _lowerBound = (int)lowerBound;
	switch (precision)
	{
	case ONE:
	{
		cout.precision(2);
		 random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case TWO:
	{
		cout.precision(3);
		 random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case THREE:
	{
		cout.precision(4);
		 random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case FOUR:
	{
		cout.precision(5);
		 random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		
		break;
	}
	default:
		break;
	}
	return random;
}
double RandomNumberGenerator::getRandomDouble(double lowerBound, double upperBound,
	Precision precision)
{
	// Implement the function 
	// You are required to use switch case structure for the enum type 
	double random;
	int _upperBound = (int)upperBound;
	int _lowerBound = (int)lowerBound;
	switch (precision)
	{
	case ONE:
	{
		cout.precision(2);
		random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case TWO:
	{
		cout.precision(3);
		random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case THREE:
	{
		cout.precision(4);
		random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	case FOUR:
	{
		cout.precision(5);
		random = double(rand()) / (double(RAND_MAX) + 1.0);
		int r = rand() % (_upperBound - _lowerBound + 1) + _lowerBound;
		random += r;
		break;
	}
	default:
		break;
	}
	return random;
}