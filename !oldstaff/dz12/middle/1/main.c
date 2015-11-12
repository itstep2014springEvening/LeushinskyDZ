#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteringNumber, counter1;
    printf("Hello user!\n");
    printf("Enter the number: ");
    scanf("%d", &enteringNumber);
    if(enteringNumber%2==0)
    {
        printf("Your number is even\n");
    }
    else
    {
        printf("Your number is odd\n");
    }
    enteringNumber=0;
    printf("Enter the number: ");
    scanf("%d", &enteringNumber);
    for(counter1=0;counter1<=enteringNumber;)
    {
        printf("%d\n", enteringNumber);
        --enteringNumber;
    }
    return 0;
}
