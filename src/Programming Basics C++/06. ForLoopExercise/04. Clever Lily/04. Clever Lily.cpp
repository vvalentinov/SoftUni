#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    int age, toyPrice;
    double dishwasherPrice;

    cin
        >> age
        >> dishwasherPrice
        >> toyPrice;

    double money = 0;

    for (int i = 1; i <= age; i++) {
        if (i % 2 == 0) {
            money += (i * 10) - (i / 2 * 10) - 1;
        }
        else {
            money += toyPrice;
        }
    }

    cout << fixed;
    cout << setprecision(2);

    if (money >= dishwasherPrice) {
        cout << "Yes! " << money - dishwasherPrice << endl;
    }
    else {
        cout << "No! " << dishwasherPrice - money << endl;
    }

    return 0;
}