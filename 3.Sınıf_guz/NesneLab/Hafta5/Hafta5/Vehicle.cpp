#include "Vehicle.h"

Vehicle::Vehicle(int _maxPassengerNumber, double _maxSpeed)
{
	setMaxPassNo(_maxPassengerNumber);
	setMaxSpeed(_maxSpeed);
	

}

bool Vehicle::Accelarate(double amount)
{
	double toplamH�z = getCurrentSpeed();

	toplamH�z += amount;
	if (toplamH�z>getMaxSpd())
	{
		toplamH�z = getMaxSpd();
		setCurSpd(toplamH�z);
	}
	else
	{
		setCurSpd(toplamH�z);
	}
	
	return true;
}

bool Vehicle::Decelerate(double amount)
{
	double toplamH�z=getCurrentSpeed();
	
	toplamH�z =toplamH�z- amount;
	if (toplamH�z<=0)
	{
		toplamH�z = 0;
		setCurSpd(toplamH�z);
		
	}
	else
	{
		setCurSpd(toplamH�z);
	}
	

	return true;
}

int Vehicle::getCurrentPassengerNumber()
{
	return currentPassengerNumber;
}

double Vehicle::getCurrentSpeed()
{
	return currentSpeed;
}

double Vehicle::getMaxSpd()
{
	return maxSpeed;
}

bool Vehicle::GetIn(int passengerNumber)
{
	if (getCurrentSpeed()==0)
	{
		setCurPassNo(getCurrentPassengerNumber() + 1);
		return true;
	}
	else
	{
		return false;
	}
	
}

bool Vehicle::GetOut(int passengerNumber)
{
	if (getCurrentSpeed() == 0)
	{
		setCurPassNo(getCurrentPassengerNumber() - 1);
		return true;
	}
	else
	{
		return false;
	}

}

void Vehicle::setCurPassNo(int _currentPassengerNumber)
{
	currentPassengerNumber = _currentPassengerNumber;
}

void Vehicle::setCurSpd(double _currentSpeed)
{
	currentSpeed = _currentSpeed;
}

void Vehicle::setEngStarted(bool _engineStarted)
{
	engineStarted = _engineStarted;
}

void Vehicle::setMaxPassNo(int _maxPassengerNumber)
{
	maxPassengerNumber = _maxPassengerNumber;
}

void Vehicle::setMaxSpeed(double _maxSpeed)
{
	maxSpeed = _maxSpeed;
}

bool Vehicle::IsEngineStarted()
{
	return engineStarted;
}

void Vehicle::StartEngine()
{
	setEngStarted(1);
}

void Vehicle::StopEngine()
{
	setEngStarted(0);
}

Vehicle::~Vehicle()
{
}
