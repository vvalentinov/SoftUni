#include <iostream>
#include <string>
#include <climits>
#include <iomanip>
#include <limits>

using namespace std;

int main() {

    int badGradesCountTarget;
    cin >> badGradesCountTarget;

    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    int countBadGrades = 0;
    double totalGradesCount = 0;
    double totalGradesSum = 0;
    string lastProblem;

    string problemName;
    getline(cin, problemName);

    while (problemName != "Enough") {

        lastProblem = problemName;

        int problemGrade;
        cin >> problemGrade;

        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        if (problemGrade <= 4) {
            countBadGrades++;
        }

        if (countBadGrades >= badGradesCountTarget) {
            break;
        }

        totalGradesSum += problemGrade;
        totalGradesCount++;

        getline(cin, problemName);
    }

    if (countBadGrades >= badGradesCountTarget) {
        cout << "You need a break, " << countBadGrades << " poor grades." << endl;
    }
    else {

        cout << fixed;
        cout << setprecision(2);

        double avgGrades = totalGradesSum / totalGradesCount;

        cout << "Average score: " << avgGrades << endl;

        cout.unsetf(ios::fixed);
        cout.precision(6);

        cout << "Number of problems: " << totalGradesCount << endl;
        cout << "Last problem: " << lastProblem << endl;
    }

    return 0;
}