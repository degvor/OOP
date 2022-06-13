//
// Created by Andrey on 13.06.2022.
//

#ifndef LAB_6_C___NUMBER_H
#define LAB_6_C___NUMBER_H
#include <string>

using namespace std;

class Number {
public:
    virtual void NumUp() = 0;
    virtual void NumDown() = 0;
    virtual int ToInt() = 0;
    virtual string ToString() const = 0;
protected:
    virtual int FromInt(int num) = 0;
    int value;
};

#endif //LAB_6_C___NUMBER_H
