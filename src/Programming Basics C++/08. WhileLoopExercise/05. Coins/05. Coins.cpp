#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    double change;
    cin >> change;

    // coins -> 200, 100, 50, 20, 10, 5, 2, 1
    // 1 = 100

    int number = change * 100;

    int countCoins = 0;

    int coinA = 200;
    int coinB = 100;
    int coinC = 50;
    int coinD = 20;
    int coinE = 10;
    int coinF = 5;
    int coinG = 2;
    int coinH = 1;

    while (number > 0) {

        // change = 1.23
        // 100 + 23 = 123 = 100 + 20 + 2 + 1
        // smallest number of coins

        if (number >= 200) {
            countCoins++;
            number -= 200;
        }
        else if (number >= 100) {
            countCoins++;
            number -= 100;
        }
        else if (number >= 50) {
            countCoins++;
            number -= 50;
        }
        else if (number >= 20) {
            countCoins++;
            number -= 20;
        }
        else if (number >= 10) {
            countCoins++;
            number -= 10;
        }
        else if (number >= 5) {
            countCoins++;
            number -= 5;
        }
        else if (number >= 2) {
            countCoins++;
            number -= 2;
        }
        else if (number >= 1) {
            countCoins++;
            number -= 1;
        }
    }

    cout << countCoins << endl;

    return 0;
}