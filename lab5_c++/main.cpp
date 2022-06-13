#include <iostream>
#include <vector>
#include "Number.h"
#include "NumberBinary.h"
#include "NumberOctal.h"
using namespace std;

vector<NumberBinary> GetBinNums(int size){
    vector<NumberBinary> binNums;
    for (int i = 0; i < size; ++i) {
        cout<<"Enter a number: ";
        int num;
        cin >> num;
        binNums.push_back(NumberBinary(num));
    }
    return binNums;
}

vector<NumberOctal> GetOctNums(int size){
    vector<NumberOctal> octNums;
    for (int i = 0; i < size; ++i) {
        cout<<"Enter a number: ";
        int num;
        cin >> num;
        octNums.push_back(NumberOctal(num));
    }
    return octNums;
}

template <typename T>
void PrintNumbers(const vector<T>& nums, string prePrint = ""){
    cout << prePrint << endl;
    for (int i = 0; i < nums.size(); ++i) {
        cout << nums[i].ToString() << '\t';
    }
    cout<<endl;
}

vector<int> GetIntNums(const vector<NumberBinary>& binNums, const vector<NumberOctal> &octNums){
    vector<int> intNums;
    for (auto num: binNums) {
        intNums.push_back(num.ToInt());
    }
    for(auto num : octNums){
        intNums.push_back(num.ToInt());
    }
    return intNums;
}

int Min(const vector<int> &nums){
    int min = nums[0];
    for (int num: nums) {
        if (num < min)
            min = num;
    }
    return min;
}


int main() {
    int binNumsCount, octNumsCount;
    cout<<"Enter number of binary numbers: ";
    cin >> binNumsCount;
    cout<<"Enter number of octal numbers: ";
    cin >> octNumsCount;

    cout<<"\nEnter numbers, that will be converted to binary"<<endl;
    auto binNums = GetBinNums(binNumsCount);
    cout<<"\nEnter numbers, that will be converted to octal"<<endl;
    auto octNums = GetOctNums(octNumsCount);
    PrintNumbers(binNums, "\nBinary numbers");
    PrintNumbers(octNums, "\nOctal numbers");

    for(NumberBinary &num : binNums){
        num.NumUp();
    }
    for(NumberOctal &num : octNums){
        num.NumDown();
    }
    PrintNumbers(binNums, "\nBinary numbers after increment: ");
    PrintNumbers(octNums, "\nOctal numbers after decrement: ");
    auto intNums = GetIntNums(binNums, octNums);
    cout<<"Min from all numbers: "<< Min(intNums)<<endl;

    system("pause");
    return 0;
}
