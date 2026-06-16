#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int main() {

    string text;
    getline(cin, text);

    int sum = 0;

    for (int i = 0; i < text.length(); i++) {

        char letter = text[i];

        switch (letter) {
        case 'a':
            sum++;
            break;
        case 'e':
            sum += 2;
            break;
        case 'i':
            sum += 3;
            break;
        case 'o':
            sum += 4;
            break;
        case 'u':
            sum += 5;
            break;
        }
    }

    cout << sum << endl;

    return 0;
}