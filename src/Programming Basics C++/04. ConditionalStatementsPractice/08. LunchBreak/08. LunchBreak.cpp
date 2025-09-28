#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>

using namespace std;

int main()
{
	string seriesName;
	int episodeRuntime, breakTime;

	getline(cin, seriesName);
	cin >> episodeRuntime >> breakTime;

	double lunchTime = breakTime / 8.0;
	double relaxTime = breakTime / 4.0;

	double timeToWatch = breakTime - (lunchTime + relaxTime);

	if (timeToWatch >= episodeRuntime * 1.0)
	{
		cout
			<< "You have enough time to watch "
			<< seriesName <<
			" and left with " << ceil(timeToWatch - episodeRuntime) <<
			" minutes free time."
			<< endl;
	}
	else
	{
		cout
			<< "You don't have enough time to watch "
			<< seriesName
			<< ", you need "
			<< ceil(episodeRuntime - timeToWatch)
			<< " more minutes." << endl;
	}

	return 0;
}