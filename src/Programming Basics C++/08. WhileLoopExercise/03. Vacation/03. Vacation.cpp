#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    double moneyNeeded, moneyAvailabe;
    cin >> moneyNeeded >> moneyAvailabe;

    int daysSpending = 0;
    int daysCount = 0;

    while (moneyAvailabe < moneyNeeded) {

        string action; // spend, save
        cin >> action;
        double money;
        cin >> money;

        daysCount++;

        if (action == "spend") {

            daysSpending++;

            if (daysSpending == 5) {
                break;
            }

            if (moneyAvailabe - money < 0) {
                moneyAvailabe = 0;
            }
            else {
                moneyAvailabe -= money;
            }

        }
        else {
            daysSpending = 0;
            moneyAvailabe += money;
        }
    }

    if (moneyAvailabe >= moneyNeeded) {
        cout << "You saved the money for " << daysCount << " days." << endl;
    }
    else {
        cout << "You can't save the money." << endl;
        cout << daysCount << endl;
    }

    return 0;
}