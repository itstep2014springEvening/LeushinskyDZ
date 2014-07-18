#include <stdio.h>
#include <stdlib.h>

int main()
{
    int NODmaker(int firstNumber, int secondNumber);
    int NOKmaker (int firstNumber, int secondNumber);
    int firstNumber, secondNumber, NOK=1;
    printf("Enter first number: ");
    scanf("%d", &firstNumber);
    printf("Enter second number(!=0): ");
    scanf("%d", &secondNumber);
    if(secondNumber==0)
    {
        printf("secondNumber!=0");
        return 0;
    }
    else
    {
        printf("NOK = %d\n", NOKmaker(firstNumber, secondNumber));
        printf("NOD = %d\n", NODmaker(firstNumber, secondNumber));
        return 0;
    }
}

int NODmaker(int firstNumber, int secondNumber)
{
    int a,b,thirdNumber,NOD;
    a=firstNumber+0;
    b=secondNumber+0;
    while(a%b!=0)
    {
        thirdNumber=a%b;
        a=b;
        b=thirdNumber;
    }
    NOD=b;
    return NOD;
}

int NOKmaker (int firstNumber, int secondNumber)
{
    int NOK;
    NOK=(firstNumber*secondNumber)/NODmaker(firstNumber, secondNumber);
    return NOK;
}
