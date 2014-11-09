#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct _Mountain
{
    char mountainName [256];
    char mountainLocation [256];
    int mountainHeight;
    int mountainSlopeAngle;
    char mountainHasAGlacier [256];
} Mountain;

void DBCreator();
void addRecord(Mountain mountain);



int main()
{
    Mountain mountain;
    int menuChooses;
    do
    {

        printf("Hello, user. What do you want?\n\n");
        printf("1. Create new DB.\n");
        printf("2. Add a new record.\n");
        printf("3. Edit a record.\n");
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
        addRecord(mountain);
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
    }
    while(menuChooses!=0);
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
    char DBName [256];
    system("cls");
    //const char *DBName;
    printf("Hello, user. Let's create new DB.\n");
    printf("Enter new DB name: ");
    scanf("%s", &DBName);
    FILE *fp;
    fp=fopen(DBName, "a+t");
    if(fp=NULL)
    {
        printf("Error DB creating.\n");
        exit(0);
    }
    system("cls");
    printf("DB created.\n");
    exit(1);
}

void addRecord(Mountain mountain)
{
    char mountainName[256];
    system("cls");
    printf("Let's add a record.\n");
    printf("mountainName\n");
    scanf("%s", &mountainName);
    /*printf("mountainLocation\n");
    scanf("%s", &mountain.mountainLocation);
    printf("mountainHeight\n");
    scanf("%d", &mountain.mountainHeight);
    printf("mountainSlopeAngle\n");
    scanf("%d", &mountain.mountainSlopeAngle);
    printf("mountainHasAGlacier\n");
    scanf("%s", &mountain.mountainHasAGlacier);*/
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "a+t");
    if(fp=NULL)
    {
        printf("Error");
        exit(1);
    }
    fwrite(mountainName, sizeof mountainName, 1, fp);
    fclose(fp);
    exit(0);

}

void deleteRecord()
{

}

void DBSort()
{

}










