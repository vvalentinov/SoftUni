#include <iostream>
#include <cmath>
#include <string>
#include <climits>

using namespace std;

int main() {

    int n;
    cin >> n;

    int currNumber;
    int currMax = INT_MIN;
    int currMin = INT_MAX;

    for (int i = 1; i <= n; i++) {
        cin >> currNumber;

        if (currNumber > currMax) {
            currMax = currNumber;
        }

        if (currNumber < currMin) {
            currMin = currNumber;
        }
    }

    cout << "Max number: " << currMax << endl;
    cout << "Min number: " << currMin << endl;

    return 0;
}