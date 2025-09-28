#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double budget;
	int videoCards, processors, memory;

	cin >> budget;
	cin >> videoCards >> processors >> memory;

	int videoCardsPrice = videoCards * 250;
	double processorsPrice = processors * (videoCardsPrice * 0.35);
	double memoryPrice = memory * (videoCardsPrice * 0.1);

	double totalPrice =
		videoCardsPrice +
		processorsPrice +
		memoryPrice;

	if (videoCards > processors)
	{
		totalPrice -= totalPrice * 0.15;
	}

	cout << fixed;
	cout << setprecision(2);

	if (budget >= totalPrice)
	{
		cout << "You have " << budget - totalPrice << " leva left!";
	}
	else
	{
		cout << "Not enough money! You need " << totalPrice - budget << " leva more!" << endl;
	}

	return 0;
}