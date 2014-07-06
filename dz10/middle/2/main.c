#include <stdio.h>
#include <stdlib.h>

int main()
{
    int choosingVaryable;
    printf("Hello user, choose what you want!\n");
    printf("\n1. How are you, user?\n");
    printf("2. Bye - bye user.\n");
    printf("0. Exit.\n");
    scanf("%d", &choosingVaryable);
    switch(choosingVaryable)
    {
    case 1:
        printf("How are you, user?");
        break;
    case 2:
        printf("Bye - bye user.");
        break;
    case 0:
        break;
    default:
        printf("What?");
        break;
    }
    return 0;
}
