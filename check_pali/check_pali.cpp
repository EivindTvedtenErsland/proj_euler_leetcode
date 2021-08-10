#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <vector>
#include <math.h>  
#include <algorithm>


bool check_pali(int x);

using namespace std;

int main () {

    int x = 4044;
    bool check = check_pali(x);
    cout << "Yo " << endl;

    cout << check << endl;

    return 0;
}

bool check_pali(int x){

    string intToStr = to_string(x);
    bool check = true;

    if (x < 0){
        check = false;
    }

    else{
        for (int i = 0; i < intToStr.length(); i++){
            if (intToStr[i] == intToStr[intToStr.length() - (1 + i)]){
                    continue;
                }
           else{
                check = false;    
            }
        }
    }

    return check;   
}