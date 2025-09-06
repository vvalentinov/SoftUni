#include <iostream>
using namespace std;

int main()
{
	int dogPackages;
	int catPackages;

	cin >> dogPackages >> catPackages;

	double finalPrice = (dogPackages * 2.5) + (catPackages * 4);

	cout << finalPrice << " lv." << endl;

	return 0;
}