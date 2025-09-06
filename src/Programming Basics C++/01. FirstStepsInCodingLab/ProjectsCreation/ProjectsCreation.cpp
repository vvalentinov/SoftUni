#include <iostream>;
using namespace std;

int main()
{
	string name;
	int projectsCount;

	cin >> name >> projectsCount;

	cout << "The architect " << name << " will need " << projectsCount * 3 << " hours to complete " << projectsCount << " project/s." << endl;

	return 0;
}