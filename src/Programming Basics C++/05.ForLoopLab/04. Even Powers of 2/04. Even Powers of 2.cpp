#include <iostream>
#include <cmath>

using namespace std;

int main() {

    int number;
    cin >> number;

    for (int i = 0; i <= number; i += 2) {
        cout << pow(2, i) << endl;
    }

    return 0;
}