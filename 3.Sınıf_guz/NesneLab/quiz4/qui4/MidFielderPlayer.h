#pragma once
#pragma once
#include<iostream>
#include"FootballPlayer.h"
#ifndef MIDFIELDERPLAYER_H_
#define MIDFIELDERPLAYER_H_

using namespace std;

class MidFielderPlayer:public FootballPlayer {
	int assistCount = 0;
	double paymentPerAssist = 0;
public:
	MidFielderPlayer(const string& name, int age, double payment, double paymentperassist)
		:FootballPlayer(name, age, payment), paymentPerAssist(paymentperassist) {}
	~MidFielderPlayer() {}
	int getAssistCount() { return assistCount; }
	double CalculatePaymentForThisYear() {
		return paymentPerYear + paymentPerAssist * assistCount;
	}
	void Press() {
		cout << Player::getName() << " is pressing..." << endl;
	}
	void setAssistCount(int asist) {
		assistCount = asist;
	}
	void TryThroughBall(Player* player){
		cout << Player::getName() << " is trying a through ball to "
			 << player->Player::getName()<<endl;
	}
	
};
#endif

