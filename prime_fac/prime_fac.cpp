#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <vector>
#include <math.h>  
#include <algorithm>

using namespace std;

vector<int> Eratosthenes(long long unsigned int n);
vector<int> Primes;

int main (){
    long long unsigned int find_prime_fact;

    cout << "Enter a number to find prime factors: " << endl;
    cin >> find_prime_fact;

    Primes = Eratosthenes(find_prime_fact);

    for (int i = 0; i < Primes.size(); i++){
            cout << Primes.at(i) << endl;
    }

    return 0;
}   

vector<int> Eratosthenes(long long unsigned int n) {

    vector<int>prime_vector;

    int i = 1;
    long long unsigned int d = 2;

    while (i < n){
        while (n % d == 0){
            prime_vector.push_back(d);
            n /= d;
        }

        d = d + 1; 

        if (d*d > n){
            if (i > n) {
                prime_vector.push_back(n);
                break;
            }
        }
    }
    return prime_vector;
}

