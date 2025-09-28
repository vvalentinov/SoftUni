#include <iostream>

using namespace std;

int main()
{
	int hour, minutes;

	cin >> hour >> minutes;

	minutes += 15;

	if (minutes >= 60)
	{
		minutes -= 60;
		hour++;
	}

	if (hour == 24)
	{
		hour = 0;
	}

	if (minutes < 10)
	{
		cout << hour << ":0" << minutes << endl;
	}
	else {
		cout << hour << ":" << minutes << endl;
	}

	return 0;
}