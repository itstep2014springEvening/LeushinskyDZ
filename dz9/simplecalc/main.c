#include <stdio.h>
#include <stdlib.h>

int main()
{
    int firstNumber, secondNumber;
    char operation;
    printf("Enter operation: ");
    scanf("%c", &operation);
    printf("Enter first number: ");
    scanf("%d", &firstNumber);
    printf("Enter second number: ");
    scanf("%d", &secondNumber);
    switch(operation)
    {
    case '+':
        printf("%d + %d = %d", firstNumber, secondNumber, firstNumber+secondNumber);
        break;
    case '-':
        printf("%d - %d = %d", firstNumber, secondNumber, firstNumber-secondNumber);
        break;
    case '*':
        printf("%d * %d = %d", firstNumber, secondNumber, firstNumber*secondNumber);
        break;
    case '/':
        if(secondNumber!=0)
        {
            printf("%d / %d = %d", firstNumber, secondNumber, firstNumber/secondNumber);
        }
        else
        {
            return 0;
        }
        break;
    case '%':
        if(secondNumber!=0)
        {
            printf("%d %% %d = %d", firstNumber, secondNumber, firstNumber%secondNumber);
        }
        else
        {
            return 0;
        }
        break;
    }
    return 0;
}
