
#ifndef VEHICLE_H_
#define VEHICLE_H_


#include<iostream>

using namespace std;

class Vehicle {
private:
	int currentPassengerNumber=1;
	double currentSpeed=0;
	bool engineStarted=0;
	int maxPassengerNumber=0;
	double maxSpeed=0;

public:

	Vehicle(int maxPassengerNumber=4 , double maxSpeed=180 ); 
	bool Accelarate(double amount);
	bool Decelerate(double amount);
	int getCurrentPassengerNumber();
	double getCurrentSpeed();
	double getMaxSpd();
	bool GetIn(int passengerNumber);
	bool GetOut(int passengerNumber);

	void setCurPassNo(int _currentPassengerNumber);
	void setCurSpd(double _currentSpeed);
	void setEngStarted(bool _engineStarted);
	void setMaxPassNo(int _maxPassengerNumber);
	void setMaxSpeed(double _maxSpeed);
	bool IsEngineStarted();
	void StartEngine();
	void StopEngine();
	~Vehicle();






};
#endif // !VEHHICLE_H_
