#include <stdio.h>
#include <stdlib.h>

int main()
{
    int firstNumber, secondNumber, thirdNumber;
    printf("Hello user!\n");
    printf("Enter first number: ");
    scanf("%d", &firstNumber);
    printf("Enter second number: ");
    scanf("%d", &secondNumber);
    printf("Enter third number: ");
    scanf("%d", &thirdNumber);
    if(secondNumber!=0 && thirdNumber!=0)
    {
        printf("%d / %d / %d = %d\n", firstNumber, secondNumber, thirdNumber, firstNumber/secondNumber/thirdNumber);
        printf("%d %% %d %% %d = %d\n", firstNumber, secondNumber, thirdNumber, firstNumber%secondNumber%thirdNumber);
    }
    printf("%d + %d + %d = %d\n", firstNumber, secondNumber, thirdNumber, firstNumber+secondNumber+thirdNumber);
    printf("%d - %d - %d = %d\n", firstNumber, secondNumber, thirdNumber, firstNumber-secondNumber-thirdNumber);
    printf("%d * %d * %d = %d\n", firstNumber, secondNumber, thirdNumber, firstNumber*secondNumber*thirdNumber);
    return 0;
}
