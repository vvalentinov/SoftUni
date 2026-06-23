#include <iostream>
#include <string>
#include <climits>

using namespace std;

int main() {

    string favBook;
    getline(cin, favBook);

    string input;
    getline(cin, input);

    int countCheckedBooks = 0;

    while (
        input != favBook &&
        input != "No More Books") {
        countCheckedBooks++;
        getline(cin, input);
    }

    if (input == favBook) {
        cout << "You checked " << countCheckedBooks << " books and found it." << endl;
    }
    else {
        cout << "The book you search is not here!" << endl;
        cout << "You checked " << countCheckedBooks << " books." << endl;
    }

    return 0;
}