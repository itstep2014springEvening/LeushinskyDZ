#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("!REVERSE POLISH NOTATION!");
    double stack [256];
    char currentValue;
    int top=-1, temporaryVariableOne=0, temporaryVariableTwo=0;
    do
    {
        scanf("%c", &currentValue);
        if(currentValue>='0' && currentValue<='9')
        {
            stack[++top]=(double)(currentValue-('1'-1));

        }
        if(currentValue=='+')
        {
            ++top;
            temporaryVariableTwo=stack[--top];
            temporaryVariableOne=stack[--top];
            stack[top]=temporaryVariableTwo+temporaryVariableOne;
        }
        if(currentValue=='=')
        {
            break;
        }
    }
    while(currentValue != '=');
    printf("%f", stack[top]);
    return 0;
}


