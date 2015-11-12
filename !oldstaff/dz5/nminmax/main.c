#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numberOfNumbers,a,min=1,max=1;
    printf("Enter amount of numbers: ");
    scanf("%d", &numberOfNumbers);
    if(numberOfNumbers<=0)
    {
        printf("WARNING! Amount of numbers > 0\n");
    }
    else
    {
        min=a;
        for(int counter1=0; counter1<numberOfNumbers; ++counter1)
        {
            printf("Enter %d number: ", counter1+1);
            scanf("%d", &a);
            if(a>max)
            {
                max=a;
            }
            if(min>a)
            {
                min=a;
            }
        }
        printf("MAX=%d\nMIN=%d", max,min);
    }
    return 0;
}
