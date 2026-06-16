#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int main() {

    int n;
    cin >> n;

    int sum = 0;
    int currNumber;

    for (int i = 1; i <= n; i++) {
        cin >> currNumber;
        sum += currNumber;
    }

    cout << sum << endl;

    return 0;
}