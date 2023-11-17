#include<iostream>
#ifndef GOALKEEPER_H_
#define GOALKEEPER_H_
#include"FootballPlayer.h"
#include"Player.h"
using namespace std;

class GoalKeeper:public FootballPlayer {
public:
	GoalKeeper(const string& name,int age,double paymentPerYear)
		:FootballPlayer(name,age,paymentPerYear) {}
	~GoalKeeper() {

	}
	double CalculatePaymentForThisYear() {
		return paymentPerYear;
	}
	
	string getName() {
		return FootballPlayer::name;
	}
	int getAge() {
		return FootballPlayer::age;
	}
	void FlyAndTryCatch() {
		cout << getName()<<" is flying and trying to catch!" << endl;
	}
	

};
#endif
