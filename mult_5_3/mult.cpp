#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

int main (){

    int start = 1000;
    int sum = 0;

    for (int i = 0; i < start; i++){
        if (i % 3 == 0 || i % 5 == 0){
            sum += i;
        }
    }
    cout << sum << endl;

    return 0;
}