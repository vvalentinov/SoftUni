#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    string actor;
    double points;
    int juryCount;

    getline(cin, actor);
    cin >> points;
    cin >> juryCount;
    cin.ignore();

    for (int i = 1; i <= juryCount; i++) {

        string juryName;
        double juryPoints;

        getline(cin, juryName);
        cin >> juryPoints;
        cin.ignore();

        points += (juryName.length() * juryPoints) / 2;

        if (points > 1250.5) {
            break;
        }
    }

    cout << fixed;
    cout << setprecision(1);

    if (points > 1250.5) {
        cout << "Congratulations, " << actor << " got a nominee for leading role with " << points << "!" << endl;
    }
    else {
        cout << "Sorry, " << actor << " you need " << 1250.5 - points << " more!" << endl;
    }

    return 0;
}