#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double
		recordSeconds,
		meters,
		oneMeterSeconds;

	cin >>
		recordSeconds >>
		meters >>
		oneMeterSeconds;

	int timesDelayed = meters / 15;
	double secondsDelayed = timesDelayed * 12.5;

	double ivanTime = (meters * oneMeterSeconds) + secondsDelayed;

	cout << fixed;
	cout << setprecision(2);

	if (ivanTime < recordSeconds)
	{
		cout << "Yes, he succeeded! The new world record is " << ivanTime << " seconds." << endl;
	}
	else
	{
		cout << "No, he failed! He was " << ivanTime - recordSeconds << " seconds slower." << endl;
	}

	return 0;
}