#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX 100


struct Mountain
{
    char mountainName [256];
    char mountainLocation [256];
    int mountainHeight;
    int mountainSlopeAngle;
    char mountainHasAGlacier [256];
} Mountain_list[MAX];

int find_free();
void DBCreator();
void addRecord();
void DBLoader();

void init_mass_struct()
{
  int i;
  for(i=0; i<MAX; ++i) Mountain_list[i].mountainName[0] = '\0';
}


int main()
{
    int choice;
    init_mass_struct();
    for(;;)
    {

        printf("Hello, user. What do you want?\n\n");
        printf("1. Create new DB.\n");
        printf("2. Add record.\n");
        printf("3. Delete record.\n");
        printf("4. Sort DB.\n");
        printf("5. Save DB.\n");
        printf("6. Load DB.\n");
        printf("0. Exit.\n");
        scanf("%d", &choice);

        switch (choice)
        {
        case 1:
            createDB();
            break;
        case 2:
            addRecord();
            break;
        case 3:
            deleteRecord();
            break;
        case 4:
            sortDB();
            break;
        case 5:
            saveDB();
            break;
       /*  case 6:
            loadDB();
            break;*/
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
    return 0;
}

void createDB()
{

    system("cls");
    //char DBName [256];
    //printf("Hello, user. Let's create new DB.\n");
    //printf("Enter new DB name: ");
    //scanf("%s", &DBName);
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "a+t");
    if(fp=NULL)
    {
        printf("Error DB creating.\n");
        exit(0);
    }
    system("cls");
    printf("DB created.\n");
    return;
}

void addRecord()
{
    system("cls");
    int slot;
    slot=find_free();
    if(slot==-1)
    {
        printf("DB is full");
        return 0;
    }

    printf("Enter mountain name:\n");
    scanf("%s", &Mountain_list[slot].mountainName);
    printf("Enter mountain location:\n");
    scanf("%s", &Mountain_list[slot].mountainLocation);
    printf("Enter mountain height:\n");
    scanf("%d", &Mountain_list[slot].mountainHeight);
    printf("Enter mountain slope angle:\n");
    scanf("%d", &Mountain_list[slot].mountainSlopeAngle);
    printf("Mountain as a glacier(enter yes or no):\n");
    scanf("%s", &Mountain_list[slot].mountainHasAGlacier);
}

/*
    char readFromFile [256];
    // printf("mountainName\n");
  // scanf("%s", &mountain.mountainName);
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "a+t");
    if(fp==NULL)
    {
        printf("Error");
        exit(1);
    }
    int count;
    char i=0;
    int writedElements;
    //writedElements=fwrite(mountain.mountainName, strlen(mountain.mountainName), 1, fp);
    printf("Catch from file\n");
   // printf("%d", writedElements);
    while (fscanf (fp, "%s", &(mountain.mountainName)) != EOF) {
		printf("%s", &(mountain.mountainName));
		i++;
    }
    if(count==0)
    {
        printf("!");
    }
    //printf("%d", count);
  // printf("%s", mountain.mountainName);

    fclose(fp);
    exit(1);
*/

void deleteRecord()
{
    system("cls");
    int slot;
    printf("Enter record N: ");
    scanf("%d", &slot);
    if(slot>=0 && slot<MAX)
    {
        Mountain_list[slot].mountainName[0]='\0';
    }
    return;
}

void sortDB()
{
    system("cls");
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            printf("Record N%d\n\n", i);
            printf("Mountain name - %s\n", Mountain_list[i].mountainName);
            printf("Mountain location - %s\n", Mountain_list[i].mountainLocation);
            printf("Mountain height - %d\n", Mountain_list[i].mountainHeight);
            printf("Mountain slope angle - %d\n", Mountain_list[i].mountainSlopeAngle);
            printf("Mountain has a glacier - %s\n\n\n", Mountain_list[i].mountainHasAGlacier);
        }
    }
    return;
}

void saveDB()
{
    FILE *fp;
    char buffer [256];
    fp=fopen("Mountain_DB.txt", "a+");
    if(fp==NULL)
    {
        printf("Error DB opening.");
        exit(1);
    }
    fwrite(Mountain_list[0].mountainName, sizeof buffer, 1, fp);
    fclose(fp);
    fp=fopen("Mountain_DB.txt", "a+");
    if(fp==NULL)
    {
        printf("Error DB opening.");
        exit(1);
    }
    fwrite(Mountain_list[0].mountainLocation, sizeof buffer, 1, fp);
   // fwrite(Mountain_list[0].mountainHeight, sizeof buffer, 1, fp);
    //fwrite(Mountain_list[0].mountainSlopeAngle, sizeof buffer, 1, fp);
    //fwrite(Mountain_list[0].mountainHasAGlacier, sizeof buffer, 1, fp);

}

/*
void addRecord(Mountain mountain)
{
    char jsutNewStroke [256]="\n";
    size_t readStatus;
    system("cls");
    printf("Let's add a record.\n");
   printf("mountainName\n");
   scanf("%s", &mountain.mountainName);
   // printf("mountainLocation\n");
   // scanf("%s", &mountain.mountainLocation);
    printf("mountainHeight\n");
    scanf("%d", &mountain.mountainHeight);
    printf("mountainSlopeAngle\n");
    scanf("%d", &mountain.mountainSlopeAngle);
    printf("mountainHasAGlacier\n");
    scanf("%s", &mountain.mountainHasAGlacier);
    FILE *fp;
    fp=fopen("Mountains_DB.txt", "r+t");
    if(fp==NULL)
    {
        printf("Error");
        exit(1);
    }
    readStatus=fwrite(mountain.mountainName, strlen(mountain.mountainName), 1, fp);
   // readStatus=fwrite(jsutNewStroke, strlen(jsutNewStroke), 1, fp);


    fclose(fp);
    exit(1);

}

void deleteRecord()
{

}

void DBSort()
{

}

*/
int find_free()
{
  int freeSlot;
  for(freeSlot=0; Mountain_list[freeSlot].mountainName[0] && freeSlot<MAX; ++freeSlot)
  {
       if(freeSlot==MAX) return -1;
  }
  return freeSlot;
}







