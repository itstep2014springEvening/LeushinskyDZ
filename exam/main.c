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
    printf("3. Delete record.\n");
    printf("4. Sort fields.\n");
    printf("5. Exit.\n");
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

    default:

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

void DBCreation()
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










