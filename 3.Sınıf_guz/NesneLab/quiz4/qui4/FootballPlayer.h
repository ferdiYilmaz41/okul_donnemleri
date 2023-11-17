#pragma once
#pragma once
#include<iostream>
#include "Player.h"
#ifndef FOOTBALLPLAYER_H_
#define FOOTBALLPLAYER_H_

using namespace std;

class FootballPlayer:public Player {
protected:
	double paymentPerYear = 0;
public:
	FootballPlayer(){}
	FootballPlayer(const string& name, int age, double paymentPerYear)
		:Player(name, age), paymentPerYear(paymentPerYear) {
	}
	double getPaymentPerYear() { return paymentPerYear; }
	void setPaymentPerYear(double _paymentPerYear)  {
		paymentPerYear = _paymentPerYear;
	}
	void Pas( Player* player) {
		cout << FootballPlayer::getName() << " is passing to "
			 << player->Player::getName() << endl;
	}
	string getName() {
		return name;
	}
	int getAge() {
		return age;
	}
	void Shot() {
		cout << getName() << " is shotting !!" << endl;
	}

	~FootballPlayer() {

	}
	
	
};
#endif