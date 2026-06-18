#include <iostream>
#include <string>
#include <iomanip>
#include <climits>

using namespace std;

int main() {

    string input;
    cin >> input;

    int currMax = INT_MIN;

    while (input != "Stop") {

        int number = stoi(input);

        if (number > currMax) {
            currMax = number;
        }

        cin >> input;
    }

    cout << currMax << endl;

    return 0;
}