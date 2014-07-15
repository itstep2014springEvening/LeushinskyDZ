#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteredNumber, sum=1, randomName;
    printf("Enter your number: ");
    scanf("%d", &enteredNumber);
    for(;enteredNumber>0;)
    {

        sum=enteredNumber%10;
        sum=sum+0;
        enteredNumber=enteredNumber/10;
printf("%d,%d\n", enteredNumber,sum);

    }
    printf("%d", sum);
    return 0;
}
