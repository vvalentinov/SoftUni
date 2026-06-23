#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    int width, height;
    cin >> width >> height;

    int cakePieces = width * height;

    string input;
    cin >> input;

    while (input != "STOP") {

        int pieces = stoi(input);
        cakePieces -= pieces;

        if (cakePieces <= 0) {
            break;
        }

        cin >> input;
    }

    if (cakePieces > 0) {
        cout << cakePieces << " pieces are left." << endl;
    }
    else {
        cout << "No more cake left!" << " You need " << abs(cakePieces) << " pieces more." << endl;
    }

    return 0;
}