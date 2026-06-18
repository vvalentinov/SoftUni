#include <iostream>
#include <string>

using namespace std;

int main() {

    string username, password, passAttempth;
    getline(cin, username);
    getline(cin, password);
    getline(cin, passAttempth);

    while (passAttempth != password) {
        getline(cin, passAttempth);
    }

    cout << "Welcome " << username << "!" << endl;

    return 0;
}