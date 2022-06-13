#include "NumberBinary.h"

NumberBinary::NumberBinary(int num) {
    value = FromInt(num);
}

NumberBinary::NumberBinary(const string& s) {
    value = FromInt(stoi(s));
}

void NumberBinary::NumUp() {
    value = FromInt(ToInt() + 1);
}

void NumberBinary::NumDown() {
    value = FromInt(ToInt() - 1);
}

int NumberBinary::ToInt() {
    string temp = to_string(value);
    int res = 0;
    for (int i = 0; i < temp.length(); ++i) {
        res += (temp[temp.length() - 1 - i] - '0') * (int) pow(2, i);
    }
    return res;
}

int NumberBinary::FromInt(int num) {
    string tmpNumRow = "";
    stack<int> s;
    int y = 0;
    do
    {
        y = num % 2;
        num = num / 2;
        s.push(y);
    } while (num != 0);

    while (!s.empty())
    {
        tmpNumRow += to_string(s.top());
        s.pop();
    }
    return stoi(tmpNumRow);
}

string NumberBinary::ToString() const { return to_string(value); }