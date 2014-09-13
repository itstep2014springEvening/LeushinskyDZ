#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Stackpletron is ready, enter your code.\n");
    int adress=0, operation=0, instructions=0, read=0, battery=0, top=-1;
    int memory[100];
    while(read!=-99999)
    {
        printf("%2d ", top+1);
        scanf("%d", &read);
        memory[++top]=read;
    }
    printf("Your code was loaded.\n");
    do
    {
        operation=memory[instructions]/100;
        adress=memory[instructions]%100;
        switch(operation)
        {
        case 10:
            scanf("%d", &memory[adress]);
            instructions++;
            break;
        case 11:
            printf("%+05d\n", memory[adress]);
            instructions++;
            break;
        case 20:
            battery=memory[adress];
            instructions++;
            break;
        case 21:
            memory[adress]=battery;
            instructions++;
            break;
        case 22:
            memory[adress]=battery;
            instructions++;
            break;
        case 23:
            memory[adress]=battery;
            instructions++;
            break;
        case 24:
            memory[adress]=battery;
            instructions++;
            break;
        case 25:
            memory[adress]=battery;
            instructions++;
            break;
        case 26:
            memory[adress]=battery;
            instructions++;
            break;
        case 27:
            memory[adress]=battery;
            instructions++;
            break;
        case 30:
            battery+=memory[adress];
            instructions++;
            break;
        case 31:
            battery-=memory[adress];
            instructions++;
            break;
        case 32:
            battery/=memory[adress];
            instructions++;
            break;
        case 33:
            battery*=memory[adress];
            instructions++;
            break;
        case 34:
            memory[adress]=battery;
            instructions++;
            break;
        case 40:
            instructions=adress;
            break;
        case 41:
            if(battery<0)
            {
                instructions=adress;
            }
            else
                instructions++;
            break;
        case 42:
            if(battery==0)
            {
                instructions=adress;
            }
            else
                instructions++;
            break;
        case 43:
            printf("Program is finished.");
            break;
        case 44:
            memory[adress]=battery;
            instructions++;
            break;
        case 45:
            memory[adress]=battery;
            instructions++;
            break;
        }
    }
    while(operation!=43);
    return 0;
}
