#include <iostream>
#include <fstream>
#include <cstdio>

using namespace std;

int main()
{
    ofstream fout("hairypidgeon.txt", ios::out|ios::trunc|ios::binary);
    int n=7788;
    char *s=(char*)&n;
    fout.write((char*)&n, sizeof(int));
    fout.close();
    return 0;
}
