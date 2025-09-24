#include <iostream>

using namespace std;

#define _USE_MATH_DEFINES

#include <math.h>

int main()
{
	string figure;

	cin >> figure;

	double result = 0;

	if (figure == "square")
	{
		double a;
		cin >> a;
		result = a * a;
	}
	else if (figure == "rectangle")
	{
		double a;
		double b;
		cin >> a >> b;
		result = a * b;
	}
	else if (figure == "circle")
	{
		double radius;
		cin >> radius;
		result = M_PI * radius * radius;
	}
	else if (figure == "triangle")
	{
		double a;
		double hA;
		cin >> a >> hA;
		result = (a * hA) / 2;
	}

	cout.setf(ios::fixed);
	cout.precision(3);

	cout << result << endl;

	return 0;
}