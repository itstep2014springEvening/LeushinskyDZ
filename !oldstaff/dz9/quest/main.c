#include <stdio.h>
#include <stdlib.h>

int main()
{
    int choice1,choice2;
    printf("Hello stranger. Bad day, hah?\n");
    printf("Make your choice.\n");
    printf("Does our live has any sense?\n");
    printf("1.Yes\n");
    printf("2.No\n");
    printf("3.I don't know\n");
    printf("4.I want a depressive poem.\n");
    printf("0.Exit.\n");
    scanf("%d", &choice1);
    switch(choice1)
    {
    case 1:
        printf("Fool!Do you have any idea, what you should do?\n");
        printf("1.Yes.\n");
        printf("2.No.\n");
        scanf("%d", &choice2);
        switch(choice2)
        {
        default:
            printf("Anyway, in future you will die.\n");
            break;
        }
        break;
    case 2:
        printf("Nice point of view, but you fool too.\n");
        break;
    case 3:
        printf("Good! Nobody knows, but, i think, you want to know?\n");
        printf("1.Yes.\n");
        printf("2.No.\n");
        scanf("%d", &choice2);
        switch(choice2)
        {
        default:
            printf("Anyway, in future you will die.\n");
            break;
        }
        break;
    case 4:
        printf("As you say. \n\n");
        printf("Once stood in an army of men\n"
               "Now I stand alone alone\n"
               "Humbled yet still proud proud\n"
               "Cold cell walls\n"
               "As darkness falls\n"
               "Sentenced to death\n"
               "For what I believe\n"
               "This cause of my sorrow\n"
               "Solitude provides solace\n"
               "Nothing left to give\n"
               "Only hollow days remain\n"
               "I die alone alone");
        break;
    case 0:
        return 0;
        break;
    default:
        printf("Are you illitirate? Try again.");
    }
    return 0;
}
