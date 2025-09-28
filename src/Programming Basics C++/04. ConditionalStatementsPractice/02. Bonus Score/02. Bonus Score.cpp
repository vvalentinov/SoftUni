#include <iostream>

using namespace std;

int main()
{
	int points;
	double bonus;

	cin >> points;

	if (points <= 100)
	{
		bonus = 5;
	}
	else if (points <= 1000)
	{
		bonus = 0.2 * points;
	}
	else
	{
		bonus = 0.1 * points;
	}

	if (points % 2 == 0)
	{
		bonus += 1;
	}
	else if (points % 10 == 5)
	{
		bonus += 2;
	}

	cout << bonus << endl;
	cout << points + bonus << endl;

	return 0;
}