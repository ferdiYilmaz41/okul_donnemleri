#include<iostream>
#ifndef _VECTOR_H_
#define _VECTOR_H_

using namespace std;

class Vector {
private:
	int dimension ;
	double* data;
	
public:

	friend ostream& operator<<(ostream& os, const Vector& v);
	friend istream& operator >> (istream &in, Vector &c);
	
	Vector(int dimension=3):dimension(dimension){
		data = new double[dimension];
	}
	Vector(double *data, int dimension)
	{
		this->dimension = dimension;
		this->data = new double[dimension];
		for (int i = 0; i < dimension; i++)
			this->data[i] = data[i];
	}
	Vector(const Vector &copyVector)
	{
		this->dimension = copyVector.dimension;
		this->data = new double[dimension];
		for (int i = 0; i < dimension; i++)
			this->data[i] = copyVector.data[i];
	}
	~Vector()
	{
		delete[] data;
	}
	
	int getDimension()const { return dimension; }
	
	bool operator!=(const Vector &other) const
	{
		if (dimension != other.dimension)
			return true;

		for (size_t i = 0; i < dimension; i++)
			if (data[i] != other.data[i])
				return true;

		return false;
	}
	bool operator==(const Vector &v) const
	{
		return !(*this != v);
	}
	void operator=(const Vector &v)
	{
		if (this == &v)
			return;
		
		delete[] data;

		dimension = v.dimension;
		data = new double[dimension];
		for (size_t i = 0; i < dimension; i++)
			data[i] = v.data[i];
	}
	double operator[](size_t index) const
	{
		if (index < 0 || index >= dimension)
			throw std::out_of_range("Index out of range!");

		return data[index];
	}

	Vector operator+(const Vector &v) const
	{
		if (dimension != v.dimension)
			throw std::invalid_argument("Vector dimensions must be equal!");

		Vector result(dimension);
		for (size_t i = 0; i < dimension; i++)
			result.data[i] = data[i] + v.data[i];

		return result;
	}
	Vector operator-(Vector &v) {
		if (dimension != v.dimension) {
			cout<<("Vectors must be in the same dimension to be subtracted!\n");
			return Vector();
		}
		Vector result(dimension);
		for (size_t i = 0; i < dimension; i++)
			result.data[i] = data[i] - v.data[i];

		return result;
	}
	

};
ostream& operator<<(ostream& os, const Vector& v)
{
	os << "[";
	for (int i = 0; i < v.getDimension(); ++i) {
		os << v[i];
		if (i != v.getDimension() - 1)
			os << ", ";
	}
	os << "]\n";
	return os;
}
istream& operator >> (istream &in, Vector &c)
{
	
	double arr[3];
	
	for (int i = 0; i < c.getDimension(); ++i) {
		in >> arr[i];
	}
	for (size_t i = 0; i < c.getDimension(); i++)
	{
		c.data[i] = arr[i];
	}
	return in;
}
#endif // !_VECTOR_H_