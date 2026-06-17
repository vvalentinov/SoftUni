#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    int n;
    cin >> n;

    double countP1 = 0;
    double countP2 = 0;
    double countP3 = 0;
    double countP4 = 0;
    double countP5 = 0;

    for (int i = 0; i < n; i++) {

        int number;
        cin >> number;

        if (number < 200) {
            countP1++;
        }
        else if (number <= 399) {
            countP2++;
        }
        else if (number <= 599) {
            countP3++;
        }
        else if (number <= 799) {
            countP4++;
        }
        else {
            countP5++;
        }
    }

    cout << fixed;
    cout << setprecision(2);

    cout << (countP1 / n) * 100 << '%' << endl;
    cout << (countP2 / n) * 100 << '%' << endl;
    cout << (countP3 / n) * 100 << '%' << endl;
    cout << (countP4 / n) * 100 << '%' << endl;
    cout << (countP5 / n) * 100 << '%' << endl;

    return 0;
}