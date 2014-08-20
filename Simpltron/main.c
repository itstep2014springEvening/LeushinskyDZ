#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("!SIMPLTRON!\n");
    const int maxArraySize=100;
    int memory [maxArraySize];
    int instructionRegister=0,  battery=0;
    int adressRegister=0;
    int registerOperation=0;
    printf("Enter, your code: \n");
    do
    {
        int userCode;
        scanf("%d", &userCode);

        switch(instructionRegister)
        {
        case 10:

            break;
        case 11:

            break;
        case 20:

            break;
        case 21:

            break;
        case 30:

            break;
        case 31:

            break;
        case 32:

            break;
        case 33:

            break;
        case 40:

            break;
        case 41:

            break;
        case 42:

            break;
        case 43:

            break;
        case -99999:
            break;

        }
    }
    while(instructionRegister!=-99999);

    return 0;
}
