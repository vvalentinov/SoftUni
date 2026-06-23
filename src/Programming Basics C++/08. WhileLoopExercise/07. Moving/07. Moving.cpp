#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    int widthFree, lengthFree, heightFree;
    cin >> widthFree >> lengthFree >> heightFree;

    int freeSpace = widthFree * lengthFree * heightFree;

    string input;
    cin >> input;

    while (input != "Done") {

        int boxesCount = stoi(input);

        freeSpace -= boxesCount;

        if (freeSpace <= 0) {
            break;
        }

        cin >> input;
    }

    if (freeSpace > 0) {
        cout << freeSpace << " Cubic meters left." << endl;
    }
    else {
        cout << "No more free space! You need " << abs(freeSpace) << " Cubic meters more." << endl;
    }

    return 0;
}