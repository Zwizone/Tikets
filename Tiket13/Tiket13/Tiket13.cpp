#include <iostream>

using namespace std;

double Cnk(int N, int K)
{
    double Sum = 1;
    for (int i = 1; i <= K; i++)
        Sum *= (N - i + 1) / float(i);
    return Sum;
}


int main()
{
    setlocale(LC_ALL, "Rus");
    int n;
    cout << "Введите число" << endl;
    cin >> n;

    for (int j = 0; j <= n; j++) {
        for (int i = 0; i <= j; i++) {
            cout << Cnk(j, i) << " ";
        }
        cout << endl;
    }

    return 0;
}
