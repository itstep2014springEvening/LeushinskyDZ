#include <stdio.h>
#include <stdlib.h>

void DBCreator();

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
    do
    {

        printf("Hello, user. It's mountains DB. What do you want?\n\n");
        printf("1. Create new DB.\n");
        printf("2. Add a new record.\n");
        printf("3. Edit record.\n");
        printf("4. Delete record.\n");
        printf("5. Sort fields.\n");
        printf("0. Exit.\n");
        scanf("%d", &menuChooses);




        switch (menuChooses)
        {
        case 1:
        DBCreator();
            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;
        case 0:
            system("cls");
            printf("Bye-bye, user.");
            return 0;
            break;
        default:
            system("cls");

            printf("Error! Please, enter correct menu number, or 0 to exit.\n\n");
            break;
        }
    }while(menuChooses!=0);
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
    system("cls");
    //const char *DBName;
    printf("Hello, user. Let's create new DB.\n");
    //printf("Enter new DB name: ");
    //scanf("%c", &DBName);
    FILE *fp;
    fp=fopen("Mountains DB.txt", "a+t");
    if(fp=NULL)
    {
        printf("Error DB creating\n");
        exit(0);
    }
    system("cls");
    printf("DB created.\n");
    exit(1);
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










