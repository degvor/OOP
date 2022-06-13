//
// Created by Andrey on 13.06.2022.
//

#ifndef LAB_6_C___NUMBEROCTAL_H
#define LAB_6_C___NUMBEROCTAL_H
#include "Number.h"
#include <string>
#include <stack>
#include <cmath>
#include <iostream>
using namespace std;

class NumberOctal : public Number{
public:
    NumberOctal(int num = 0);
    NumberOctal(const string& s);
    void NumUp() override;
    void NumDown() override;
    int ToInt() override;
    string ToString() const override;
protected:
    int FromInt(int num) final;
};
#endif //LAB_6_C___NUMBEROCTAL_H
