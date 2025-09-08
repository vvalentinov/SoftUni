#include <iostream>

using namespace std;

int main()
{
	double sum;
	int months;
	double interest;

	cin >> sum >> months >> interest;

	double result = sum + months * ((sum * (interest / 100)) / 12);

	cout << result << endl;

	return 0;
}