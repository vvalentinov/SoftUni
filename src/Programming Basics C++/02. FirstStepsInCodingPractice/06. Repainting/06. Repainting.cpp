#include <iostream>

using namespace std;

int main()
{
	int plasticNeeded;
	int paintLitresNeeded;
	int paintThinnerLitresNeeded;
	int hoursNeededForJob;

	cin >>
		plasticNeeded >>
		paintLitresNeeded >>
		paintThinnerLitresNeeded >>
		hoursNeededForJob;

	double paintLitresNeededTotal = paintLitresNeeded + (paintLitresNeeded * 0.1);
	plasticNeeded = plasticNeeded + 2;

	double materialsSum =
		(plasticNeeded * 1.5) +
		(paintLitresNeededTotal * 14.5) +
		(paintThinnerLitresNeeded * 5)
		+ 0.4;

	double workersPrice = hoursNeededForJob * (materialsSum * 0.3);

	double result = materialsSum + workersPrice;

	cout << result << endl;

	return 0;
}