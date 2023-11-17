#pragma once
#pragma once
#include<iostream>
#include<string>
#ifndef PLAYER_H_
#define PLAYER_H_
#include"FootballPlayer.h"
using namespace std;

class Player {
protected:
	int age = 0;
	string name = "";
private:
	
	void MoveEast(){}
	void MoveNorth(){}
	void MoveNorthEast(){}
	void MoveNorthWest(){}
	void MoveSouth(){}
	void MoveSouthEast(){}
	void MoveSouthWest(){}
	void MoveWest(){}
public:
	Player(){}
	Player(const string& name, int age) :name(name), age(age) {}
	~Player() {};
	enum Direction { EAST, NORTH, NORTH_EAST, NORTH_WEST, SOUTH, SOUTH_EAST, SOUTH_WEST, WEST };

	int getAge() { return age; }
	string getName() { return name; }
	
	Direction Move(Direction direction){ 
		switch (direction)
		{
		case EAST:
			cout << getName() << " is moving to EAST" << endl;
			return EAST;
			break;
		case NORTH:
			cout << getName() << " is moving to NORTH"   << endl;
			return NORTH;
			break;
		case NORTH_EAST:
			cout << getName() << " is moving to NORTH_EAST"   << endl;
			return NORTH_EAST;
			break;
		case NORTH_WEST:
			cout << getName() << " is moving to NORTH_WEST" << endl;
			return NORTH_WEST;
			break;
		case SOUTH:
			cout << getName() << " is moving to SOUTH" << endl;
			return SOUTH;
			break;
		case SOUTH_EAST:
			cout << getName() << " is moving to SOUTH_EAST" << endl;
			return SOUTH_EAST;
			break;
		case SOUTH_WEST:
			cout << getName() << " is moving to SOUTH_WEST" << endl;
			return SOUTH_WEST;
			break;
		case WEST:
			cout << getName() << " is moving to WEST"  << endl;
			return WEST;
			break;
		default:
			break;
		}
	
	}
	



};
#endif

