#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <unistd.h>

void printfOnlyNumberReturn(int enteringNumber);

int main()
{
    int enteringNumber=321;
    printfOnlyNumberReturn(enteringNumber);
    return 0;
}

void printfOnlyNumberReturn(int enteringNumber)
{
    char currentSymbol[12];
    int i;
    for(i=0;enteringNumber;++i)
    {
        currentSymbol[i]=enteringNumber%10+'0';

        enteringNumber/=10;
    }
    write(1, currentSymbol, i);

}
