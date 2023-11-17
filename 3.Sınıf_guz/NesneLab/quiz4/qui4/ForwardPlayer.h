#pragma once
#pragma once
#include<iostream>
#include"FootballPlayer.h"
#ifndef FORWARDPLAYER_H_
#define FORWARDPLAYER_H_

using namespace std;

class ForwardPlayer:public FootballPlayer {
	int goalCount = 0;
	double paymentPerGoal = 0;
public:
	ForwardPlayer(const string& name,int age,double payment,double paymentpergoal)
		:FootballPlayer(name,age,payment),paymentPerGoal(paymentpergoal){}
	~ForwardPlayer(){}
	double CalculatePaymentForThisYear() {
		return paymentPerYear + paymentPerGoal * goalCount;
	}
	
	
	
	int getGoalCount() { return goalCount; }
	void setGoalCount(int gol) { goalCount = gol; }
	void ThrowYourSelf() {
		cout << Player::getName() << " is throwing himself..." << endl;
	}
	void TryDribblePast(Player* player) {
		cout << Player::getName() << " is trying a dribble past on " 
			 << player->Player::getName() << endl;

	}
	



};
#endif

