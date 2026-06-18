#include <iostream>
#include <string>
#include <iomanip>
#include <climits>

using namespace std;

int main() {

    string input;
    cin >> input;

    int currMin = INT_MAX;

    while (input != "Stop") {

        int number = stoi(input);

        if (number < currMin) {
            currMin = number;
        }

        cin >> input;
    }

    cout << currMin << endl;

    return 0;
}