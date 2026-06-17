#include <iostream>
#include <cmath>
#include <string>
#include <climits>
#include <iomanip>

using namespace std;

int main() {

    int toursCount, startPoints;
    cin >> toursCount >> startPoints;

    double wonTours = 0;
    int wonPoints = 0;

    for (int i = 1; i <= toursCount; i++) {

        string tourResult;
        cin >> tourResult;

        if (tourResult == "W") {
            startPoints += 2000;
            wonTours++;
            wonPoints += 2000;
        }
        else if (tourResult == "F") {
            startPoints += 1200;
            wonPoints += 1200;
        }
        else if (tourResult == "SF") {
            startPoints += 720;
            wonPoints += 720;
        }
    }

    double wonToursAvg = wonTours / toursCount * 100;
    double avgPointsPerTour = floor(wonPoints / toursCount);

    cout << "Final points: " << startPoints << endl;
    cout << "Average points: " << avgPointsPerTour << endl;
    cout << fixed;
    cout << setprecision(2);
    cout << wonToursAvg << '%' << endl;

    return 0;
}