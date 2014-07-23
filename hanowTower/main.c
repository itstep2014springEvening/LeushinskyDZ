#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    scanf("%d",&n);
    hanoi('A','B','C',n);
    return 0;
}

void hanoi(char a, char b, char c, int n)
{
    if(n==1)
    {
        printf("%c -> %c", a,b);
    }
    else
    {
        hanoi(a,c,b,n-1);
        printf("%c -> %c", a,b);
        hanoi(c,b,a,n-1);
    }
}



