#include <iostream>
#include <cmath>
#include <string>
#include <climits>

using namespace std;

int main() {

    int n;
    cin >> n;

    int max = INT_MIN;
    int sum = 0;

    for (int i = 0; i < n; i++) {
        int number;
        cin >> number;

        sum += number;

        if (number > max) {
            max = number;
        }
    }

    sum -= max;

    if (sum == max) {
        cout << "Yes" << endl;
        cout << "Sum = " << sum << endl;
    }
    else {
        cout << "No" << endl;
        cout << "Diff = " << abs(sum - max) << endl;
    }

    return 0;
}