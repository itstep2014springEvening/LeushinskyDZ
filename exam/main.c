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
void createDB();
void addRecord();
void deleteRecord();
void outputDB();
void saveDB();
void loadDB();
void mysortHeight();
void mysortSlopeAngle();

int main()
{
    int choice;
    init_mass_struct();
    for(;;)
    {
        printf("Program started. Select:\n\n");
        printf("1. Create new DB.\n");
        printf("2. Add record.\n");
        printf("3. Delete record.\n");
        printf("4. Otput DB.\n");
        printf("5. Sort DB.\n");
        printf("6. Save DB.\n");
        printf("7. Load DB.\n");
        printf("0. Exit.\n\n\n");
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
            outputDB();
            break;
        case 5:
            sortDB();
            break;
        case 6:
            saveDB();
            break;
        case 7:
            loadDB();
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
    return 0;
}

void createDB()
{
    system("cls");
    FILE *fp;
    fp=fopen("Mountain_DB", "wb");
    if(fp=NULL)
    {
        printf("Error DB creating.\n");
        exit(0);
    }
    printf("DB created.\n\n");
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
    printf("Mountain has a glacier(enter yes or no):\n");
    scanf("%s", &Mountain_list[slot].mountainHasAGlacier);
}

void deleteRecord()
{
    int slot;
    printf("Enter record N: ");
    scanf("%d", &slot);
    slot=slot-1;
    if(slot>=0 && slot<MAX)
    {
        Mountain_list[slot].mountainName[0]='\0';
    }
    return;
}

void sortDB()
{
    int choice;
    printf("Sort by:\n");
    printf("1. Height.\n");
    printf("2. Slope angle.\n");
    scanf("%d", &choice);
    switch(choice)
    {
    case 1:
        mysortHeight();
        break;
    case 2:
        mysortSlopeAngle();
        break;
    default:
        printf("Error.\n");
        break;
    }
}

void outputDB()
{
    system("cls");
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            printf("Rec:N%d  ", i+1);
            printf("Name:%s  ", Mountain_list[i].mountainName);
            printf("Loc:%s  ", Mountain_list[i].mountainLocation);
            printf("He-t:%dm  ", Mountain_list[i].mountainHeight);
            printf("Sl.a:%d'%'  ", Mountain_list[i].mountainSlopeAngle);
            printf("Gl-r:%s\n", Mountain_list[i].mountainHasAGlacier);
        }
    }
    printf("\n");
}

void mysortHeight()
{
    int firstElement, secondElement, counter=0;
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            counter++;
        }
    }
    for(int i=0; i<counter-1; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            if(Mountain_list[i].mountainHeight>Mountain_list[i+1].mountainHeight)
            {
                firstElement=Mountain_list[i].mountainHeight;
                secondElement=Mountain_list[i+1].mountainHeight;
                Mountain_list[i].mountainHeight=secondElement;
                Mountain_list[i+1].mountainHeight=firstElement;
            }

        }
    }
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            printf("Rec:N%d  ", i+1);
            printf("Name:%s  ", Mountain_list[i].mountainName);
            printf("Loc:%s  ", Mountain_list[i].mountainLocation);
            printf("He-t:%dm  ", Mountain_list[i].mountainHeight);
            printf("Sl.a:%d'%'  ", Mountain_list[i].mountainSlopeAngle);
            printf("Gl-r:%s\n", Mountain_list[i].mountainHasAGlacier);
        }
    }
}

void mysortSlopeAngle()
{
    int firstElement, secondElement, counter=0;
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            counter++;
        }
    }
    for(int i=0; i<counter-1; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            if(Mountain_list[i].mountainSlopeAngle>Mountain_list[i+1].mountainSlopeAngle)
            {
                firstElement=Mountain_list[i].mountainSlopeAngle;
                secondElement=Mountain_list[i+1].mountainSlopeAngle;
                Mountain_list[i].mountainSlopeAngle=secondElement;
                Mountain_list[i+1].mountainSlopeAngle=firstElement;
            }

        }
    }
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {
            printf("Rec:N%d  ", i+1);
            printf("Name:%s  ", Mountain_list[i].mountainName);
            printf("Loc:%s  ", Mountain_list[i].mountainLocation);
            printf("He-t:%dm  ", Mountain_list[i].mountainHeight);
            printf("Sl.a:%d'%'  ", Mountain_list[i].mountainSlopeAngle);
            printf("Gl-r:%s\n", Mountain_list[i].mountainHasAGlacier);
        }
    }
}

void mysortName()
{
    for(int i=0; i<MAX; ++i)
    {
        if(Mountain_list[i].mountainName[0])
        {

        }
    }
}

void saveDB()
{
    FILE *fp;
    fp=fopen("Mountain_DB", "wb");
    if(fp==NULL)
    {
        printf("Error DB opening.");
        exit(1);
    }
    for(int i=0; i<MAX; i++)
    {
        if(*Mountain_list[i].mountainName)
        {
            if(fwrite(&Mountain_list[i],sizeof(struct Mountain), 1, fp)!=1)
            {
                printf("Error DB writing.\n");
            }
        }
    }
    printf("DB saved.\n");
    fclose(fp);
}

void loadDB()
{
    FILE *fp;
    fp=fopen("Mountain_DB", "rb");
    if(fp==NULL)
    {
        printf("Error DB opening.");
        exit(1);
    }
    init_mass_struct();
    for(int i=0; i<MAX; i++)
    {
        if(fread(&Mountain_list[i],sizeof(struct Mountain), 1, fp)!=1)
        {
            if(feof(fp))
            {
                break;
                printf("Error DB reading.\n");
            }
        }
    }
    printf("DB loaded.\n");
    fclose(fp);
}

int find_free()
{
    int freeSlot;
    for(freeSlot=0; Mountain_list[freeSlot].mountainName[0] && freeSlot<MAX; ++freeSlot)
    {
        if(freeSlot==MAX) return -1;
    }
    return freeSlot;
}

void init_mass_struct()
{
    int i;
    for(i=0; i<MAX; ++i) Mountain_list[i].mountainName[0] = '\0';
}
