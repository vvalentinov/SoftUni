#include <iostream>

using namespace std;

int main()
{
	int chickenMenusCount;
	int fishMenusCount;
	int veganMenusCount;

	cin >>
		chickenMenusCount >>
		fishMenusCount >>
		veganMenusCount;

	double menusPrice =
		(chickenMenusCount * 10.35) +
		(fishMenusCount * 12.4) +
		(veganMenusCount * 8.15);

	double dessertPrice = menusPrice * 0.2;

	double totalPrice = menusPrice + dessertPrice + 2.5;

	cout << totalPrice << endl;

	return 0;
}