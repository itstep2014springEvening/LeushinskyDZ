#include <stdio.h>
#include <stdlib.h>

int main()
{
    int firstNumber, secondNumber;
    printf("Hello user!\n");
    printf("Enter first number: ");
    scanf("%d", &firstNumber);
    printf("Enter second number: ");
    scanf("%d", &secondNumber);
    if(secondNumber!=0)
    {
        printf("%d / %d = %d\n", firstNumber, secondNumber, firstNumber/secondNumber);
        printf("%d %% %d = %d\n", firstNumber, secondNumber, firstNumber%secondNumber);
    }
    printf("%d + %d = %d\n", firstNumber, secondNumber, firstNumber+secondNumber);
    printf("%d - %d = %d\n", firstNumber, secondNumber, firstNumber-secondNumber);
    printf("%d * %d = %d\n", firstNumber, secondNumber, firstNumber*secondNumber);
    return 0;
}
