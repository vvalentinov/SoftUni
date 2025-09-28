#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double holidayPrice;

	int puzzlesCount,
		dollsCount,
		bearsCount,
		minionsCount,
		trucksCount;

	cin >> holidayPrice;

	cin >>
		puzzlesCount >>
		dollsCount >>
		bearsCount >>
		minionsCount >>
		trucksCount;

	int toysOrderedCount =
		puzzlesCount +
		dollsCount +
		bearsCount +
		minionsCount +
		trucksCount;

	double profit =
		(puzzlesCount * 2.6) +
		(dollsCount * 3) +
		(bearsCount * 4.1) +
		(minionsCount * 8.2) +
		(trucksCount * 2);

	if (toysOrderedCount >= 50)
	{
		profit -= (profit * 0.25);
	}

	profit -= (profit * 0.1);

	cout << fixed;
	cout << setprecision(2);

	if (profit >= holidayPrice)
	{
		cout << "Yes! " << profit - holidayPrice << " lv left." << endl;
	}
	else
	{
		cout << "Not enough money! " << holidayPrice - profit << " lv needed." << endl;
	}

	return 0;
}