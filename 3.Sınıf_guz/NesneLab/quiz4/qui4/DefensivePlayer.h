#pragma once
#include<iostream>
#ifndef DEFENSÝVEPLAYER_H_
#define DEFENSÝVEPLAYER_H_
#include"FootballPlayer.h"
#include"Player.h"
using namespace std;

class DefensivePlayer:public FootballPlayer {
private:
	double paymentPerMatch = 0;
	int playedMatchCount = 0;
public:

	DefensivePlayer(const string& name,int age,double payment,double paymenMatch)
		:FootballPlayer(name,age,payment),paymentPerMatch(paymenMatch){}
	~DefensivePlayer(){}
	double CalculatePaymentForThisYear() {
		return paymentPerYear + paymentPerMatch * playedMatchCount;
	}
	void Defense() {
		cout << Player::getName() << " is defending..." << endl;

	}
	int getPlayedMatchCount() { return playedMatchCount; }
	void setPlayedMatchCount(int number) {
		playedMatchCount = number;
	}
	void TripUp( Player* oyuncu) {
		cout<< Player::getName() <<" is tripped up " 
			<< oyuncu->Player::getName()<<" ..." << endl;
	}
	
	


};
#endif
