#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main() {

    double sum = 0;

    cout << fixed;
    cout << setprecision(2);

    while (true) {

        string input;
        cin >> input;

        if (input == "NoMoreMoney") {
            break;
        }

        double number = stod(input);

        if (number < 0) {
            cout << "Invalid operation!" << endl;
            break;
        }

        sum += number;
        cout << "Increase: " << number << endl;
    }

    cout << "Total: " << sum << endl;

    return 0;
}