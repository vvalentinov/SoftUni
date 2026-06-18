#include <iostream>
#include <string>
#include <iomanip>
#include <climits>

using namespace std;

int main() {

    string student;
    cin >> student;

    double sumGrades = 0;
    double currentGrade = 1;
    bool failed = false;

    while (true) {

        double grade;
        cin >> grade;

        if (grade < 4) {
            failed = true;
            break;
        }

        sumGrades += grade;

        if (currentGrade == 12) {
            break;
        }

        currentGrade++;
    }

    if (failed == true) {

        cout << student << " has been excluded at " << currentGrade << " grade" << endl;

    }
    else {

        cout << fixed;
        cout << setprecision(2);

        double avgGrade = sumGrades / currentGrade;

        cout << student << " graduated." << " Average grade: " << avgGrade << endl;
    }

    return 0;
}