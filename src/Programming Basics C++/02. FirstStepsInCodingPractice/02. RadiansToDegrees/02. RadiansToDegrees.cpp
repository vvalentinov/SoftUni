#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double radians;

	cin >> radians;

	double degrees = round(radians * 180 / 3.14);

	cout << degrees << endl;

	return 0;
}