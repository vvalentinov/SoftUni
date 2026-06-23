#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    int stepsCount = 0;

    while (stepsCount < 10000) {

        string input;
        getline(cin, input);

        if (input == "Going home") {

            int finalSteps;
            cin >> finalSteps;
            stepsCount += finalSteps;
            break;

        }

        int currentSteps = stoi(input);
        stepsCount += currentSteps;

    }

    if (stepsCount < 10000) {
        cout << 10000 - stepsCount << " more steps to reach goal." << endl;
    }
    else {
        cout << "Goal reached! Good job!" << endl;
    }

    return 0;
}