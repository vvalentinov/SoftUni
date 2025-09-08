#include <iostream>

using namespace std;

int main()
{
	int annualTax;

	cin >> annualTax;

	double basketballShoes = annualTax - (annualTax * 0.4);
	double basketballUniform = basketballShoes - (basketballShoes * 0.2);
	double basketball = basketballUniform / 4;
	double basketballAccessories = basketball / 5;

	double result =
		basketballShoes +
		basketballUniform +
		basketball +
		basketballAccessories +
		annualTax;

	cout << result << endl;

	return 0;
}