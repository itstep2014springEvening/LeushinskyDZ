#include <stdio.h>
#include <stdlib.h>

int main()
{
    int m,n,square,newString;
    printf("WARNING!!! M or N have to be odd numbers, or both of them!\n");


    printf("Enter m: ");
    scanf("%d",&m);
    printf("Enter n: ");
    scanf("%d",&n);
    if(m%2==0 || n%2==0)
    {
        printf("WARNING!!! M or N have to be odd numbers, or both of them!");
    }
    else
    {
        square=m*n;
        newString=m+0;
        for(int counter1=0; counter1<square; ++counter1)
        {
            if(counter1==newString)
            {
                printf("\n");
                newString=newString+m;
            }
            counter1%2!=0?printf("*"):printf(" ");
        }
    }
    return 0;
}
