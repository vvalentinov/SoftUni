#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double budget;
	cin >> budget;

	int statists;
	cin >> statists;

	double statistClothingPrice;
	cin >> statistClothingPrice;

	double decor = budget * 0.1;
	double clothingPrice = statists * statistClothingPrice;

	if (statists > 150)
	{
		clothingPrice -= clothingPrice * 0.1;
	}

	double totalPrice = decor + clothingPrice;

	cout << fixed;
	cout << setprecision(2);

	if (budget >= totalPrice)
	{
		cout << "Action!" << endl;
		cout << "Wingard starts filming with " << budget - totalPrice << " leva left." << endl;
	}
	else
	{
		cout << "Not enough money!" << endl;
		cout << "Wingard needs " << totalPrice - budget << " leva more." << endl;
	}

	return 0;
}