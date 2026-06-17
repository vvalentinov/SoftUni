#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    int groupsCount;
    cin >> groupsCount;

    double totalPeopleCount = 0;
    double mussalaCount = 0;
    double monblanCount = 0;
    double kilimandjaroCount = 0;
    double k2Count = 0;
    double everestCount = 0;

    for (int i = 1; i <= groupsCount; i++) {

        int peopleCount;
        cin >> peopleCount;

        totalPeopleCount += peopleCount;

        if (peopleCount <= 5) {
            mussalaCount += peopleCount;
        }
        else if (peopleCount <= 12) {
            monblanCount += peopleCount;
        }
        else if (peopleCount <= 25) {
            kilimandjaroCount += peopleCount;
        }
        else if (peopleCount <= 40) {
            k2Count += peopleCount;
        }
        else {
            everestCount += peopleCount;
        }
    }

    cout << fixed;
    cout << setprecision(2);

    cout << mussalaCount / totalPeopleCount * 100 << '%' << endl;
    cout << monblanCount / totalPeopleCount * 100 << '%' << endl;
    cout << kilimandjaroCount / totalPeopleCount * 100 << '%' << endl;
    cout << k2Count / totalPeopleCount * 100 << '%' << endl;
    cout << everestCount / totalPeopleCount * 100 << '%' << endl;

    return 0;
}