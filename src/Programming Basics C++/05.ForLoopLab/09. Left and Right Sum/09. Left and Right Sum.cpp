#include <iostream>
#include <cmath>
#include <string>
#include <climits>

using namespace std;

int main() {

    int n;
    cin >> n;

    int leftSum = 0;
    int rightSum = 0;

    // left sum
    for (int i = 0; i < n; i++) {
        int number;
        cin >> number;
        leftSum += number;
    }

    // right sum
    for (int i = 0; i < n; i++) {
        int number;
        cin >> number;
        rightSum += number;
    }

    if (leftSum == rightSum) {
        cout << "Yes, sum = " << leftSum << endl;
    }
    else {
        cout << "No, diff = " << abs(leftSum - rightSum) << endl;
    }

    return 0;
}