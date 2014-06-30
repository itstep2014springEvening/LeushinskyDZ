#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteringNumber, counter1;
    printf("Hello user! Let's check your number.\n");
    printf("Please, enter the number: ");
    scanf("%d", &enteringNumber);
    for(counter1=enteringNumber-1;counter1>0;--counter1)
    {
        if(enteringNumber%counter1!=0)
        printf("Your number is not simple.");
    }
    else
    {
        printf("Your number is simple.");
    }
    return 0;
}
