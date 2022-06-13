#include "NumberOctal.h"

NumberOctal::NumberOctal(int num) {
    value = FromInt(num);
}

NumberOctal::NumberOctal(const string &s) {
    value = FromInt(stoi(s));
}

void NumberOctal::NumUp() {
    value = FromInt(ToInt() + 1);
}

void NumberOctal::NumDown() {
    value = FromInt(ToInt() - 1);
}

int NumberOctal::ToInt() {
    string temp = to_string(value);
    int res = 0;
    for (int i = 0; i < temp.length(); ++i) {
        res += (temp[temp.length() - 1 - i] - '0') * (int) pow(8, i);
    }
    return res;
}

int NumberOctal::FromInt(int num) {
    string tmpNumRow = "";
    stack<int> s;
    int y = 0;
    do
    {
        y = num % 8;
        num = num / 8;
        s.push(y);
    } while (num != 0);

    while (!s.empty())
    {
        tmpNumRow += to_string(s.top());
        s.pop();
    }
    return stoi(tmpNumRow);
}

string NumberOctal::ToString() const { return to_string(value); }
