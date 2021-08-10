#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <vector>

using namespace std;

vector<int> calc_fib_4mill(void);

int main (){

    vector<int> fib_nums;
    int sum;

    fib_nums = calc_fib_4mill();

    for (int x: fib_nums){
        if (x % 2 == 0){
            sum += x;
        }
    }
    cout <<  "Size of array is: " << fib_nums.size() << endl;
    cout <<  "Sum of even terms in fib seq: " << sum << endl;
    return 0;
}

vector<int> calc_fib_4mill(void){

    vector<int> fib_nums;
   
    fib_nums.push_back(1);
    fib_nums.push_back(2);
    int i = 2;

   while(i < 300){
        fib_nums.push_back(fib_nums[i-1] + fib_nums[i-2]);
       
        if (fib_nums.at(i) > 4000000){
            fib_nums.pop_back();
            break;
        }

        i++;  
    } 
    return fib_nums;
}


 