#include <iostream>

using namespace std;

int main()
{
	int pagesCount;
	int pagesReadInOneHour;
	int daysToReadBook;

	cin >> pagesCount >> pagesReadInOneHour >> daysToReadBook;

	int result = (pagesCount / pagesReadInOneHour) / daysToReadBook;

	cout << result << endl;

	return 0;
}