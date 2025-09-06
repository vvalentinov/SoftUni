#include <iostream>;
using namespace std;

int main()
{
	double meters;

	cin >> meters;

	double priceWithoutDiscount = meters * 7.61;

	double discount = priceWithoutDiscount * 0.18;

	double finalPrice = priceWithoutDiscount - discount;

	cout << "The final price is: " << finalPrice << " lv." << endl;
	cout << "The discount is: " << discount << " lv." << endl;

	return 0;
}