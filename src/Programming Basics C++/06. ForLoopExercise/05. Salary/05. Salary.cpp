#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    int tabsOpen;
    double salary;

    cin >> tabsOpen >> salary;

    for (int i = 1; i <= tabsOpen; i++) {

        string site;
        cin >> site;

        if (site == "Facebook") {
            salary -= 150;
        }
        else if (site == "Instagram") {
            salary -= 100;
        }
        else if (site == "Reddit") {
            salary -= 50;
        }

        if (salary <= 0) {
            break;
        }

    }

    if (salary <= 0) {
        cout << "You have lost your salary." << endl;
    }
    else {
        cout << salary << endl;
    }

    return 0;
}