#include <iostream>

using namespace std;

int main()
{
	int length;
	int width;
	int height;
	double percentage;

	cin >> length >> width >> height >> percentage;

	double totalVolume = length * width * height;

	double volumeInLitres = totalVolume * 0.001;

	double result = volumeInLitres * (1 - (percentage / 100));

	cout << result << endl;

	return 0;
}