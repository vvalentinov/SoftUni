#include <iostream>
#include <string>

using namespace std;

int main() {

    int numberInput;
    cin >> numberInput;

    int sum = 0;

    while (sum < numberInput) {
        int number;
        cin >> number;
        sum += number;
    }

    cout << sum << endl;

    return 0;
}