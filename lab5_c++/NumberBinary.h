//
// Created by Andrey on 13.06.2022.
//

#ifndef LAB_6_C___NUMBERBINARY_H
#define LAB_6_C___NUMBERBINARY_H
#include "Number.h"
#include <iostream>
#include <string>
#include <stack>
#include <cmath>
using namespace std;

class NumberBinary : public Number{
public:
    NumberBinary(int num = 0);
    NumberBinary(const string& s);
    void NumUp() override;
    void NumDown() override;
    int ToInt() override;
    string ToString() const override;
protected:
    int FromInt(int num) final;
};

#endif //LAB_6_C___NUMBERBINARY_H
