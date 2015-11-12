#include <stdio.h>
#include <stdlib.h>
int NODmaker(int stringI, int columnJ);
int main()
{
    int stringI, columnJ, n;
    printf("Enter field size: ");
    scanf("%d", &n);
    for(stringI=1; stringI<=n; ++stringI)
    {
        for(columnJ=1; columnJ<=n; ++columnJ)
        {
            printf("%c",NODmaker(stringI, columnJ)==1?'#':' ');
        }
        printf("\n");
    }
    return 0;
}

int NODmaker(int stringI, int columnJ)
{
    int a,b,c,NOD;
    a=stringI+0;
    b=columnJ+0;
    while(a%b!=0)
    {
        c=a%b;
        a=b;
        b=c;
    }
    NOD=b;
    return b;
}


