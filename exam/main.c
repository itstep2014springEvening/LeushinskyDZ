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
void DBLoader(Mountain mountain);



int main()
{
    Mountain mountain;
    int menuChooses;
    do
    {

        printf("Hello, user. What do you want?\n\n");
        printf("1. Create new DB.\n");
        printf("2. Add a new record.\n");
        printf("3. Load DB.\n");
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
    DBLoader(mountain);
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

void DBLoader(Mountain mountain)
{
    system("cls");
    char readFromFile [256];
     printf("mountainName\n");
   scanf("%s", &mountain.mountainName);
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "r");
    /*if(fp==NULL)
    {
        printf("Error");
        exit(1);
    }*/
    int count;
    char i=0;
    int writedElements;
    //writedElements=fwrite(mountain.mountainName, strlen(mountain.mountainName), 1, fp);
    printf("Catch from file\n");
   // printf("%d", writedElements);
    while (fscanf (fp, "%s", &(mountain.mountainName)) != "\n") {
		//printf("%s", &(mountain.mountainName));
		i++;
    }
    if(count==0)
    {
        printf("!");
    }
    //printf("%d", count);
   printf("%s", mountain.mountainName);

    fclose(fp);
    exit(1);
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
    char jsutNewStroke [256]="\n";
    size_t readStatus;
    system("cls");
    printf("Let's add a record.\n");
   printf("mountainName\n");
   scanf("%s", &mountain.mountainName);
    printf("mountainLocation\n");
    scanf("%s", &mountain.mountainLocation);
    printf("%s\n", mountain.mountainName);
    printf("%s\n", mountain.mountainName);
    /*printf("mountainHeight\n");
    scanf("%d", &mountain.mountainHeight);
    printf("mountainSlopeAngle\n");
    scanf("%d", &mountain.mountainSlopeAngle);
    printf("mountainHasAGlacier\n");
    scanf("%s", &mountain.mountainHasAGlacier);*/
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "a+t");
    if(fp==NULL)
    {
        printf("Error");
        exit(1);
    }
    readStatus=fwrite(mountain.mountainName, strlen(mountain.mountainName), 1, fp);
    readStatus=fwrite(jsutNewStroke, strlen(jsutNewStroke), 1, fp);
    readStatus=fwrite(mountain.mountainLocation, strlen(mountain.mountainLocation), 1, fp);

    fclose(fp);
    exit(1);

}

void deleteRecord()
{

}

void DBSort()
{

}










