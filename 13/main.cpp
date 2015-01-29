#include <iostream>

using namespace std;

int main()
{
    const int n = 7;
char array[n] = {’a’, ’b’, ’c’, ’d’, ’e’, ’f’, ’g’};
for(int i = 1; i < n; ++i)
array[i] = array[n - i];
for(int i = 0; i < n; ++i)
cout << array[i]; // printf(”%c”, array[i]);
cout << endl; // printf(”\n”);

}
