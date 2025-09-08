#include <iostream>

using namespace std;

int main()
{
	int pensPackagesCount;
	int markersPackagesCount;
	int litresDetergent;

	double discountPercentage;

	cin >>
		pensPackagesCount >>
		markersPackagesCount >>
		litresDetergent >>
		discountPercentage;

	discountPercentage /= 100;

	double pensPrice = pensPackagesCount * 5.8;
	double markersPrice = markersPackagesCount * 7.2;
	double detergentPrice = litresDetergent * 1.2;

	double sum = pensPrice + markersPrice + detergentPrice;

	double sumAfterDiscount = sum - (sum * discountPercentage);

	cout << sumAfterDiscount << endl;

	return 0;
}