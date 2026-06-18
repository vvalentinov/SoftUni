#include <iostream>
#include <string>

using namespace std;

int main() {

    int numberInput;
    cin >> numberInput;
    int currentNumber = 1;

    while (currentNumber <= numberInput) {
        cout << currentNumber << endl;
        currentNumber = currentNumber * 2 + 1;
    }

    return 0;
}