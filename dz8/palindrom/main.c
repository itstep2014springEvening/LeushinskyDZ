#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteredNumber, sum, inverseNumber=0, processingNumber;
    printf("Enter your number: ");
    scanf("%d", &enteredNumber);
    processingNumber=enteredNumber;
    while(enteredNumber>0)
    {
        sum=enteredNumber%10;
        inverseNumber=(inverseNumber*10)+sum;
        enteredNumber/=10;
    }
    processingNumber==inverseNumber?printf("%d = %d => palindrome.",processingNumber,inverseNumber):printf("%d != %d => not a palindrome.",processingNumber,inverseNumber);
    return 0;
}
