#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Simpletron is ready, enter your code.\n");
    int top=-1, adress=0, operation=0, instructions=0, read=0, battery=0, turn=0;
    int memory[99];
    while(read!=-99999)
    {
        printf("%2d ", turn);
        scanf("%d", &read);
        memory[turn]=read;
        turn++;
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
        }
    }
    while(operation!=43);
    return 0;
}
