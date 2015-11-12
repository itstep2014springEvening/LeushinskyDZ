#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Task1!\n");
    char letter='A';
    for(int counter1=0;counter1<10;++counter1)
    {
        printf("%c\n",letter);
        letter++;
    }


    printf("\nTask2!\n");
    int firstNumber, secondNumber;
    printf("Please enter first number: ");
    scanf("%d", &firstNumber);
    printf("Please enter second number: ");
    scanf("%d", &secondNumber);
    firstNumber%secondNumber==0?printf("a/b\n"):printf("a!/b\n");
    secondNumber%firstNumber==0?printf("b/a\n"):printf("b!/a\n");


    printf("\nTask3!\n");
    int a,b,c;
    printf("Please enter a: ");
    scanf("%d", &a);
    printf("Please enter b: ");
    scanf("%d", &b);
    printf("Please enter c: ");
    scanf("%d", &c);
    (a+b)>c?printf("a+b>c"):printf("a+b<c");
    return 0;
}
