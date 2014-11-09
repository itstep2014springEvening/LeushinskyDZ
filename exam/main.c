#include <stdio.h>
#include <stdlib.h>

typedef struct _Mountain
{
    char mountainName [256];
    char mountainLocation [256];
    int mountainHeight;
    int mountainSlopeAngle;
    char mountainHasAGlacier [256];
} Mountain;

int main()
{
    int menuChooses;
    printf("Hello, user. It's mountains DB. What do you want?\n\n");
    printf("1. Create new DB.\n");
    printf("2. Add a new record.\n");
    printf("3. Edit record.\n");
    printf("4. Delete record.\n");
    printf("5. Sort fields.\n");
    printf("6. Exit.\n");
    scanf("%d", &menuChooses);


    switch (menuChooses)
{
case 1:

    break;
case 2:

    break;
case 3:

    break;
case 4:

    break;
case 5:

    break;
    case 6:
    system("cls");
    printf("Bye-bye, user.");
    return 0;
    break;
    default:
    printf("Error! Please, enter correct menu number.");
    break;
}

return 0;
}

void DBLoader()
{

}

void DBSaver()
{

}

void DBCreator()
{

}

void addRecord()
{

}

void deleteRecord()
{

}

void DBSort()
{

}










